using ImageMagick;

namespace GifToTextureGUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.KeyPreview = true;
        }

    private const int
    HTLEFT = 10,
    HTRIGHT = 11,
    HTTOP = 12,
    HTTOPLEFT = 13,
    HTTOPRIGHT = 14,
    HTBOTTOM = 15,
    HTBOTTOMLEFT = 16,
    HTBOTTOMRIGHT = 17;

        const int _ = 10; // you can rename this variable if you like

        new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        new Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }



        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void import_Click(object sender, EventArgs e)
        {
            string resulto = Path.GetTempPath();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "GIF(*.gif)|" + "*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string img_path = ofd.FileName;
                pictureBoxNearest.Image = new Bitmap(img_path);
                File.Delete(resulto + "GIFtoTextureGIFSAVE.gif");
                File.Copy(img_path, resulto + "GIFtoTextureGIFSAVE.gif" );
            }
            }

        public void SAVE_Click(object sender, EventArgs e)
        {
            string resulto = Path.GetTempPath();
            string ticks = numericUpDown1.Text;
            if (ticks.Equals("0"))
            {
                MessageBox.Show("You need to input a number for ticks");
            } else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image(*.png)|" + "*.png";
                DialogResult dr = sfd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string sf = sfd.FileName;
                    //string fp = sfd.SelectedPath;

                    using (var collection = new MagickImageCollection(resulto + "GIFtoTextureGIFSAVE.gif"))

                    {
                        collection.Coalesce();
                        //collection.Write(fileName: @"Output\TEXTURE.png");
                        using (var result = collection.AppendVertically())
                        {
                            result.Write(fileName: sf);

                        }
                    }

                    using (FileStream fs = File.Create(sf + ".mcmeta"))
                    {
                        fs.Close();
                        System.IO.File.WriteAllText(sf + ".mcmeta", "{\n \"animation\": { \n       \"frametime\": " + ticks + "\n    }\n}");
                        fs.Close();
                    }
                    MessageBox.Show("Your textures and json are now saved to " + sf + " put both in their respective folders ");
                }
            }
        }
        bool mousedown;
        private Point offset;

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_event(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                this.Size = new Size(399, 558);
            }
            else WindowState = FormWindowState.Maximized;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void importBtnLeave(object sender, EventArgs e)
        {
            IMPORT.BackColor = Color.Black;
            IMPORT.ForeColor = Color.White;
        }

        private void importBtnEnter(object sender, EventArgs e)
        {
            IMPORT.BackColor = Color.White;
            IMPORT.ForeColor = Color.Black;
        }

        private void saveBtnEnter(object sender, EventArgs e)
        {
            SAVE.BackColor = Color.White;
            SAVE.ForeColor = Color.Black;
        }

        private void saveBtnLeave(object sender, EventArgs e)
        {
            SAVE.BackColor = Color.Black;
            SAVE.ForeColor = Color.White;
        }

        private void fullscreenBtn_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                    this.Size = new Size(399, 558);
                    this.TopMost = false;
                    WindowBar.Visible = true;
                    maximizeButton.Visible = true;
                    minimizeButton.Visible = true;
                    closeButton.Visible = true;
                } else
                {
                    this.TopMost = true;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                    WindowBar.Visible = false;
                    maximizeButton.Visible = false;
                    minimizeButton.Visible = false;
                    closeButton.Visible = false;

                }


                e.SuppressKeyPress = true;
            }
        }



        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
    }

}
    
