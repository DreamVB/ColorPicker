using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace inidemo
{
    class inifile
    {
        private static FileInfo fi;

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public void WriteString(string selection, string Key, string Value)
        {
            WritePrivateProfileString(selection, Key, Value, fi.FullName);
        }

        public string ReadString(string selection, string Key, string vDefault = "")
        {
            StringBuilder sb = new StringBuilder(256);
            //Get ini file.
            GetPrivateProfileString(selection, Key, vDefault, sb, 256, fi.FullName);
            //Return value.
            return sb.ToString();
        }

        public void DeleteSelection(string selection)
        {
            WritePrivateProfileString(selection, null, null, fi.FullName);
        }

        public void DeleteKey(string selection, string key)
        {
            WritePrivateProfileString(selection, key, null, fi.FullName);
        }

        public List<string> ReadSelections()
        {
            List<string> temp = new List<string>();
            string sLine = string.Empty;
            
            if (!fi.Exists)
            {
                return temp;
            }

            using (StreamReader sr = new StreamReader(fi.FullName))
            {
                while (!sr.EndOfStream)
                {
                    //Get and trim line
                    sLine = sr.ReadLine().Trim();
                    //Check for opening and closeing tags
                    if (sLine.StartsWith("[") && (sLine.EndsWith("]")))
                    {
                        //Add to collection.
                        temp.Add(sLine.Substring(1, sLine.Length - 2));
                    }
                }
                //close file
                sr.Close();
            }
            return temp;
        }

        public List<string> ReadSelectionKeys(string selection)
        {
            List<string> temp = new List<string>();
            string sLine = string.Empty;
            string SelName = string.Empty;

            if (!fi.Exists)
            {
                return temp;
            }

            using (StreamReader sr = new StreamReader(fi.FullName))
            {
                while (!sr.EndOfStream)
                {
                    //Get and trim line
                    sLine = sr.ReadLine().Trim();
                    //Check for opening and closeing tags
                    if (sLine.StartsWith("[") && (sLine.EndsWith("]")))
                    {
                        //Add to collection.
                        SelName = sLine.Substring(1,sLine.Length - 2);

                        if (!sr.EndOfStream)
                        {
                            //Get next line
                            sLine = sr.ReadLine().Trim();
                        }
                    }

                    //Compare selection names.
                    if (SelName.ToUpper() == selection.ToUpper())
                    {
                        if (sLine.Length > 0)
                        {
                            int pos = sLine.IndexOf("=");
                            //Check for equals sign
                            if (pos > 0)
                            {
                                //Extract key
                                temp.Add(sLine.Remove(pos, sLine.Length - pos));
                            }
                        }
                    }
                }
                //Close file.
                sr.Close();
            }
            return temp;
        }

        public inifile(string Filename)
        {
            fi = new FileInfo(Filename);
        }

    }
}
