using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DmColorPicker
{
    public partial class f : Form
    {

        [DllImport("shlwapi.dll")]
        static extern void ColorRGBToHLS(int RGB, ref int H, ref int L, ref int S);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        enum TColorFormat
        {
            RGB = 0,
            RGB_F,
            HEX,
            WEB,
            CSHARP,
            VB,
            VBLong,
            CPLUS
        };

        private bool MouseIsDown = false;
        private string CustPallete = string.Empty;
        private int CustomIndex = 0;
        private TColorFormat m_colfrmt = TColorFormat.RGB;
        private MouseButtons m_but;
        private Color m_color = Color.Empty;
        private FileInfo cfg = null;
        private Color MousePixel = Color.White;
        private Point MousePoint = new Point();
        private List<string> colors = new List<string>();
        private List<Color> htmlcolors = new List<Color>();
        private inidemo.inifile inifile;

        private void LoadHtmlColors()
        {
            //Path to the filename.
            string lzfile = AppPath() + @"data\htmlcolours.inc";

            string sLine = string.Empty;
            string sColor = string.Empty;
            int s_pos = 0;
            int iCount = 0;
            int R = 0;
            int G = 0;
            int B = 0;

            //Check for html colors.
            if (!File.Exists(lzfile)) { return; }

            try
            {
                using (StreamReader sr = new StreamReader(lzfile))
                {
                    while (!sr.EndOfStream)
                    {
                        //Get current line
                        sLine = sr.ReadLine().Trim();
                        //Find first space.
                        s_pos = sLine.IndexOf(' ');
                        //Check for position of space
                        if (s_pos != -1)
                        {
                            //Extract color
                            sColor = sLine.Substring(0, s_pos + 1).Remove(0, 1);
                            //Extract color name.

                            //Split HTML color
                            R = int.Parse(sColor.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                            G = int.Parse(sColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                            B = int.Parse(sColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

                            //Add to color collection.
                            htmlcolors.Add(Color.FromArgb(R, G, B));

                            //Add color name to listbox.
                            LstColors.Items.Add(sLine.Substring(s_pos + 1));

                            //INC Counter.
                            iCount++;
                        }
                    }
                    sr.Close();
                }
            }
            catch
            {
                return;
            }
        }

        private void LoadConfig()
        {
            int R = 128;
            int G = 128;
            int B = 128;
            //Load color picker image.
            LoadPickerPallete(AppPath() + @"data\" + inifile.ReadString("main", "picker", "windows.png"));
            //Set color format
            cboColors.SelectedIndex = int.Parse(inifile.ReadString("main", "colorfrmt", "0"));

            //Load custom pallete
            CustPallete = inifile.ReadString("main", "pallete", AppPath() + "default.pal");
            //Load pallete
            LoadPallete(CustPallete);
            //Set scrollbars
            R = int.Parse(inifile.ReadString("main", "red", "128"));
            G = int.Parse(inifile.ReadString("main", "green", "128"));
            B = int.Parse(inifile.ReadString("main", "blue", "128"));
            //Set scrollbars
            UpdateScrollbars(R, G, B);
        }

        private void SaveConfig()
        {
            inifile.WriteString("main", "picker", (string)PicPallete.Tag);
            inifile.WriteString("main", "colorfrmt", cboColors.SelectedIndex.ToString());
            inifile.WriteString("main", "pallete", CustPallete);
            //Write hbar values.
            inifile.WriteString("main", "red", hsbRed.Value.ToString());
            inifile.WriteString("main", "green", hsbGreen.Value.ToString());
            inifile.WriteString("main", "blue", hsbBlue.Value.ToString());
        }

        private string AppPath()
        {
            FileInfo fi = new FileInfo(Application.ExecutablePath);
            return fixpath(fi.Directory.ToString());
        }

        private string fixpath(string src)
        {
            if (src.EndsWith("\\"))
            {
                return src;
            }
            return src + "\\";
        }

        public f()
        {
            InitializeComponent();
        }

        private void LoadPickerPallete(string Filename)
        {
            if (File.Exists(Filename))
            {
                PicPallete.ImageLocation = Filename;
            }
        }

        private Color StrToColor(string value)
        {
            Color col = Color.White;
            int R = 0;
            int G = 0;
            int B = 0;
            string[] sp = value.Split(',');

            if (sp.Length != 3)
            {
                col = Color.White;
            }
            //Build the color from the rgb string.
            try
            {
                R = int.Parse(sp[0]);
                G = int.Parse(sp[1]);
                B = int.Parse(sp[2]);
                col = Color.FromArgb(R, G, B);
            }
            catch
            {
                col = Color.White;
            }
            //Clear up
            Array.Clear(sp, 0, sp.Length);
            //Return color
            return col;
        }

        private string ColorToStr(Color value)
        {
            return value.R.ToString() + "," +
                value.G.ToString() + "," + value.B.ToString();
        }

        public Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

        private void LoadPallete(string Filename)
        {
            List<string> items = new List<string>();
            string sLine = string.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(File.OpenRead(Filename)))
                {
                    while (!sr.EndOfStream)
                    {
                        sLine = sr.ReadLine().Trim();
                        if (sLine.Length > 0)
                        {
                            items.Add(sLine);
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Load the pallete
            pColor1.BackColor = StrToColor(items[0]);
            pColor2.BackColor = StrToColor(items[1]);
            pColor3.BackColor = StrToColor(items[2]);
            pColor4.BackColor = StrToColor(items[3]);
            pColor5.BackColor = StrToColor(items[4]);
            pColor6.BackColor = StrToColor(items[5]);
            pColor7.BackColor = StrToColor(items[6]);
            pColor8.BackColor = StrToColor(items[7]);
        }

        private void SavePallete(string Filename)
        {
            //Save pallete
            try
            {
                using (StreamWriter sw = new StreamWriter(Filename))
                {
                    //Write colors.
                    sw.WriteLine(ColorToStr(pColor1.BackColor));
                    sw.WriteLine(ColorToStr(pColor2.BackColor));
                    sw.WriteLine(ColorToStr(pColor3.BackColor));
                    sw.WriteLine(ColorToStr(pColor4.BackColor));
                    sw.WriteLine(ColorToStr(pColor5.BackColor));
                    sw.WriteLine(ColorToStr(pColor6.BackColor));
                    sw.WriteLine(ColorToStr(pColor7.BackColor));
                    sw.WriteLine(ColorToStr(pColor8.BackColor));
                    sw.Close();
                }
            }
            catch
            {
                return;
            }
        }

        private void RandomColor()
        {
            Random nRand;
            nRand = new Random();

            int R = nRand.Next(0, 255);
            int B = nRand.Next(0, 255);
            int G = nRand.Next(0, 255);

            UpdateScrollbars(R, G, B);
        }

        private void SetColorBrightness(int R, int G, int B, int value)
        {
            int R1 = 0;
            int G1 = 0;
            int B1 = 0;

            R1 = (R + value);
            G1 = (G + value);
            B1 = (B + value);

            if (R1 <= 0) { R1 = 0; }
            if (R1 >= 255) { R1 = 255; }
            if (B1 <= 0) { B1 = 0; }
            if (B1 >= 255) { B1 = 255; }
            if (G1 <= 0) { G1 = 0; }
            if (G1 >= 255) { G1 = 255; }

            UpdateScrollbars(R1, G1, B1);
        }

        private Color InvertColor(int R, int G, int B)
        {
            Color col = Color.Beige;

            return Color.FromArgb((byte)~R, (byte)~G, (byte)~B);
        }

        private long GetLongColor(int r, int g, int b)
        {
            return (b * 65536 + g * 256 + r);
        }

        private string StrReverse(string src)
        {
            char[] temp = src.ToCharArray();
            Array.Reverse(temp);
            return new string(temp);
        }

        private void SetColorFrmt(int R, int G, int B)
        {
            string sColFrmt = string.Empty;
            double r1 = 0;
            double g1 = 0;
            double b1 = 0;
            string sWeb = R.ToString("x2") +
                        G.ToString("x2") +
                        B.ToString("x2");

            //Show color format
            switch (m_colfrmt)
            {
                case TColorFormat.RGB:
                    sColFrmt = "RGB(" + R.ToString() + "," + G.ToString() + "," + B.ToString() + ")";
                    break;
                case TColorFormat.RGB_F:
                    //Convert to rgb float
                    r1 = Math.Round((R / 255.0) * 100);
                    g1 = Math.Round((G / 255.0) * 100);
                    b1 = Math.Round((B / 255.0) * 100);
                    //Set color
                    sColFrmt = r1.ToString() + "," + g1.ToString() + "," + b1.ToString();
                    break;
                case TColorFormat.HEX:
                    sColFrmt = "HEX(" + R.ToString("x2") + "," + G.ToString("x2") + "," + B.ToString("x2") + ")";
                    break;
                case TColorFormat.WEB:
                    sColFrmt = "#" + sWeb;
                    break;
                case TColorFormat.CSHARP:
                    sColFrmt = "Color.FromArgb(" + R.ToString() + "," + G.ToString() + "," + B.ToString() + ")";
                    break;
                case TColorFormat.VB:
                    sColFrmt = "&h" + StrReverse(sWeb);
                    break;
                case TColorFormat.VBLong:
                    sColFrmt = GetLongColor(R, G, B).ToString();
                    break;
                case TColorFormat.CPLUS:
                    sColFrmt = "0x00" + StrReverse(sWeb);
                    break;

            }
            //Show output color.
            txtColor.Text = sColFrmt;
        }

        private void UpdateScrollbars(int R, int G, int B)
        {
            hsbRed.Value = R;
            hsbGreen.Value = G;
            hsbBlue.Value = B;
        }
        private void UpdateRGBVals()
        {
            lblRed.Text = hsbRed.Value.ToString();
            lblGreen.Text = hsbGreen.Value.ToString();
            lblBlue.Text = hsbBlue.Value.ToString();
        }

        private Color GetDlgColor(Color cDefault)
        {
            ColorDialog cd = new ColorDialog();
            Color col = cDefault;

            cd.AllowFullOpen = true;
            cd.FullOpen = true;
            cd.Color = cDefault;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                col = cd.Color;
            }
            //Clear up
            cd.Dispose();
            //Return color
            return col;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] colors = Enum.GetNames(typeof(KnownColor));
            //Config filename.
            cfg = new FileInfo(AppPath() + @"data\pickercfg.cfg");
            //Config object
            inifile = new inidemo.inifile(cfg.FullName);
            //Custom pallete
            CustPallete = AppPath() + "default.pal";
            CustomIndex = 1;
            //Load default pallete.
            LoadConfig();
            //Load html colors.
            LoadHtmlColors();
        }

        private void PicPallete_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g;

            if (MouseIsDown)
            {
                //Get point x,y
                g = PicPallete.CreateGraphics();
                //Extract color
                Bitmap bmp = new Bitmap(PicPallete.Image);
                if ((e.X < 0) || (e.X >= PicPallete.Width)) { return; }
                if ((e.Y < 0) || (e.Y >= PicPallete.Height)) { return; }
                //Extract the color
                m_color = bmp.GetPixel(e.X, e.Y);
                //Update scrollbars
                UpdateScrollbars(m_color.R, m_color.G, m_color.B);
            }
        }

        private void PicPallete_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseIsDown = true;
                PicPallete_MouseMove(sender, e);
            }
        }

        private void PicPallete_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(PicPallete.Image);
            MouseIsDown = false;
        }

        private void pColor1_DoubleClick(object sender, EventArgs e)
        {
            if (m_but == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                Color c = GetDlgColor(pic.BackColor);
                //Set pal index color.
                pic.BackColor = c;
                //Set main color
                m_color = c;
                //Update color
                UpdateScrollbars(m_color.R, m_color.G, m_color.B);
            }
        }

        private void LstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Set main color
                m_color = htmlcolors[LstColors.SelectedIndex];
                //Display preview color
                UpdateScrollbars(m_color.R, m_color.G, m_color.B);
            }
            catch
            {
                return;
            }
        }

        private void pColor1_MouseDown(object sender, MouseEventArgs e)
        {
            m_but = e.Button;

            if (m_but == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                //Set color
                m_color = pic.BackColor;
                //Set preview color
                UpdateScrollbars(m_color.R, m_color.G, m_color.B);
            }
        }

        private void cboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboColors.SelectedIndex)
            {
                case 0:
                    m_colfrmt = TColorFormat.RGB;
                    break;
                case 1:
                    m_colfrmt = TColorFormat.RGB_F;
                    break;
                case 2:
                    m_colfrmt = TColorFormat.HEX;
                    break;
                case 3:
                    m_colfrmt = TColorFormat.WEB;
                    break;
                case 4:
                    m_colfrmt = TColorFormat.CSHARP;
                    break;
                case 5:
                    m_colfrmt = TColorFormat.VB;
                    break;
                case 6:
                    m_colfrmt = TColorFormat.VBLong;
                    break;
                case 7:
                    m_colfrmt = TColorFormat.CPLUS;
                    break;
            }
            SetColorFrmt(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
        }

        private void hsbBlue_ValueChanged(object sender, EventArgs e)
        {
            UpdateRGBVals();
            //Update pic preview color.
            pColor.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            //Set color.
            SetColorFrmt(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
        }

        private void cmdInvert_Click(object sender, EventArgs e)
        {
            //Invert color.
            Color c = InvertColor(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            //Update scrollbars
            pColor.BackColor = c;
            UpdateScrollbars(c.R, c.G, c.B);
        }

        private void cmdLight1_Click(object sender, EventArgs e)
        {
            //Make color ligher
            SetColorBrightness(hsbRed.Value, hsbGreen.Value, hsbBlue.Value, 4);
        }

        private void cmdLight2_Click(object sender, EventArgs e)
        {
            //Make color darker
            SetColorBrightness(hsbRed.Value, hsbGreen.Value, hsbBlue.Value, -4);
        }

        private void cmdRandom_Click(object sender, EventArgs e)
        {
            //Make random color
            RandomColor();
        }

        private void LstColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Color c1 = htmlcolors[e.Index];
            Color c2 = InvertColor(c1.R, c1.G, c1.B);

            e.DrawFocusRectangle();
            e.Graphics.FillRectangle(new SolidBrush(c1), e.Bounds);
            //Center color name
            float y = ((22 - e.Font.Height) / 2) + e.Bounds.Y;

            g.DrawString(LstColors.Items[e.Index].ToString(),
                e.Font, new SolidBrush(c2), new PointF(2 + e.Bounds.X, y), StringFormat.GenericDefault);
        }

        private void LstColors_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 22;
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();

            od.Title = "Open";
            od.Filter = "Pallete Files(*.pal)|*.pal";
            if (od.ShowDialog() == DialogResult.OK)
            {
                CustPallete = od.FileName;
                //Load pallete.
                LoadPallete(CustPallete);
            }
            //Clear up
            od.Dispose();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();

            sd.Title = "Save As";
            sd.Filter = "Pallete Files(*.pal)|*.pal";
            sd.DefaultExt = "pal";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                //Save pallete.
                CustPallete = sd.FileName;
                SavePallete(CustPallete);
            }
            //Clear up
            sd.Dispose();
        }

        private void cmdPickColor_Click(object sender, EventArgs e)
        {
            //Get color from dialog
            m_color = GetDlgColor(pColor.BackColor);
            //Update scrollbars.
            UpdateScrollbars(m_color.R, m_color.G, m_color.B);
        }

        private void cmdPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIsDown)
            {
                //Get cursor position
                GetCursorPos(ref MousePoint);
                MousePixel = GetColorAt(MousePoint.X, MousePoint.Y);
                //Set picturebox color
                pColor.BackColor = MousePixel;
            }
        }

        private void cmdPicker_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Set cursor pis
                cmdPicker.Cursor = Cursors.SizeAll;
                //Reset
                MouseIsDown = true;
            }
        }

        private void cmdPicker_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
            //Reset mouse cursor
            cmdPicker.Cursor = Cursors.Default;
            //Set scrollbars value for new color.
            UpdateScrollbars(MousePixel.R, MousePixel.G, MousePixel.B);
        }

        private void mnuCube_Click(object sender, EventArgs e)
        {
            PicPallete.Tag = "cube.png";
            LoadPickerPallete(@"data\cube.png");
        }

        private void mnuWin_Click(object sender, EventArgs e)
        {
            PicPallete.Tag = "windows.png";
            LoadPickerPallete(@"data\windows.png");
        }

        private void mnuPencil_Click(object sender, EventArgs e)
        {
            PicPallete.Tag = "pencil.png";
            LoadPickerPallete(@"data\pencil.png");
        }

        private void cmdCopyColVal_Click(object sender, EventArgs e)
        {
            txtColor.SelectAll();
            txtColor.Focus();
            txtColor.Copy();
        }

        private void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save config.
            SaveConfig();
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            frmabout frm = new frmabout();
            frm.ShowDialog();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void r8_Click(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            //Get custom pallete item to
            CustomIndex = int.Parse((string)rd.Tag);
        }

        private void cmdAddCustom_Click(object sender, EventArgs e)
        {
            switch (CustomIndex)
            {
                case 1:
                    pColor1.BackColor = pColor.BackColor;
                    break;
                case 2:
                    pColor2.BackColor = pColor.BackColor;
                    break;
                case 3:
                    pColor3.BackColor = pColor.BackColor;
                    break;
                case 4:
                    pColor4.BackColor = pColor.BackColor;
                    break;
                case 5:
                    pColor5.BackColor = pColor.BackColor;
                    break;
                case 6:
                    pColor6.BackColor = pColor.BackColor;
                    break;
                case 7:
                    pColor7.BackColor = pColor.BackColor;
                    break;
                case 8:
                    pColor8.BackColor = pColor.BackColor;
                    break;
            }
        }
    }
}
