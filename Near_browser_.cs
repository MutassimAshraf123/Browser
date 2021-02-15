using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Runtime.InteropServices;
using System.IO;
using System.Globalization;
using System.Security.Policy;
using System.Diagnostics;

namespace we_browser_
{
    public partial class Near_Browser : Form
    {

        public Near_Browser()
        {
            InitializeComponent();
            
            SetDoubleBuffering(panel1, true);
            SetDoubleBuffering(panel2, true);
            SetDoubleBuffering(panel3, true);
            SetDoubleBuffering(panel4, true);
            SetDoubleBuffering(panel5, true);
            SetDoubleBuffering(panel6, true);
            SetDoubleBuffering(panel7, true);
            SetDoubleBuffering(gunaShadowPanel6, true);
            SetDoubleBuffering(panel9, true);
            SetDoubleBuffering(panel10, true);

            



        }

        ChromiumWebBrowser chrom;
       public TextBox t = new TextBox();
        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", (System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance));
            controlProperty.SetValue(control, value, null);
        }

        [DllImport("shell32.dll", EntryPoint = "#261", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern void GetUserpicPath(string username, UInt32 hex, StringBuilder picture_path, int maxLength);


        int tn = 0;

        private void facebook_web_form_Load(object sender, EventArgs e)
        { 

            this.TopMost = true;

            this.KeyPreview = true;

            this.CenterToScreen();
            this.SendToBack();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            // circular_PictureBox1.ImageLocation = @"C:\ProgramData\Microsoft\User Account Pictures\user.png";

           


            string[] args_ = Environment.GetCommandLineArgs();
                foreach (string a in args_)
                {

                       textBox2.Text = a;

                if ((textBox2.Text == @"C:\Users\" + SystemInformation.UserName + @"\Desktop\NEAR_VOS_TOOLS\we_browser_\bin\x64\Release\we_browser_.exe") || (textBox2.Text== "we_browser_.exe"))
                {

                    textBox2.Text = "Search Near or type a Url";

                }


                if (textBox2.Text != "Search Near or type a Url")
                    {

                   

                    textBox2.Focus();


                    SendKeys.SendWait("{ENTER}");
                    SendKeys.SendWait("{ENTER}");

                }

                

            }
            


            timer3.Start();
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            try
            {
         chrom.Reload();
            }
            catch (Exception)
            {

        
            }



            Cef.ExecuteProcess();
            Cef.Shutdown();

            Process currentProcess = Process.GetCurrentProcess();
            string pid = (currentProcess.Id).ToString();

          

            System.Diagnostics.Process f_r4 = new System.Diagnostics.Process();
            f_r4.StartInfo.FileName = "cmd.exe";
            f_r4.StartInfo.RedirectStandardInput = true;
            f_r4.StartInfo.RedirectStandardOutput = true;
            f_r4.StartInfo.CreateNoWindow = true;
            f_r4.StartInfo.UseShellExecute = false;
            f_r4.Start();


            f_r4.StandardInput.WriteLine("cd/ & cd windows & cd system32 & TASKKILL.exe /F /pid "+pid);
            f_r4.StandardInput.Flush();
            f_r4.StandardInput.Close();
            //this.Close();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {

                this.WindowState = FormWindowState.Maximized;
                bunifuImageButton2.Image = Properties.Resources.icons8_restore_down_32px;

            }
            else
            {

                this.WindowState = FormWindowState.Normal;
                bunifuImageButton2.Image = Properties.Resources.icons8_maximize_button_32px_1;

            }
        }


        public static string turl;

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {


            //try
            //{

            //turl = textBox1.Text;

            //}
            //catch (Exception)
            //{
            //}

            //if (textBox1.Text.Contains("https://www.youtube.com/watch?v="))
            //{


            //    SendKeys.SendWait("k");

            //    bool y_v = false;

            //    for (int i = 0; i < Application.OpenForms.Count; i++)
            //    {

            //        Form n = Application.OpenForms[i];
            //        if ((n.Name == "youtube_v"))
            //        {
            //            n.Close();
            //            youtube_v yv = new youtube_v();
            //            yv.Show();
            //            y_v = true;

            //        }

            //        System.Threading.Thread.Sleep(1);
            //    }
            //    if (!y_v)
            //    {

            //        youtube_v yv = new youtube_v();
            //        yv.Show();


            //    }

            //    min.Start();


            //}
            //else
            //{

                this.WindowState = FormWindowState.Minimized;

            //}

        }

     

        private void min_Tick(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        int n = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {

            n += 1;

            if (n == 4)
            {

                url_n.Start();
                timer1.Start();

                circular_PictureBox1.ImageLocation = @"C:\ProgramData\Microsoft\User Account Pictures\user.png";

                gunaLinePanel1.Visible = true;
                gunaResizeControl1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                panel9.Visible = true;
                panel12.Visible = true;


   

            }
            if (n == 5)
            {

                timer3.Stop();

            }

        }

        private void facebook_web_form_Move(object sender, EventArgs e)
        {

            bunifuImageButton2.Image = Properties.Resources.icons8_maximize_button_32px_1;

        }


        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            try
            {
                   chrom.Back();
            }
            catch (Exception)
            {

                
            }

          
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

            try
            {
                chrom.Forward();
            }
            catch (Exception)
            {

            }

           
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

            try
            {
               chrom.Reload();
            }
            catch (Exception)
            { 
            }

          
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {

                timer4.Stop();

            }

            if (this.Opacity < 1)
            {

                this.Opacity += .1;
            }
            else
            {

                

                Application.OpenForms[this.Name].Focus();

                this.TopMost = false;


                timer4.Stop();


            }
        }

        private void a_h_Tick(object sender, EventArgs e)
        {
            this.Opacity -= .1;

            if (this.Opacity < .90)
            {

                a_h.Stop();

            }
        }

        private void gunaLinePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            a_h.Start();
        }

        private void gunaLinePanel1_MouseUp(object sender, MouseEventArgs e)
        {

            timer4.Start();

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

            url_n.Stop();


            if (textBox1.Text == "Search Near or type a Url")
            {

                textBox1.Text = string.Empty;
                textBox1.ForeColor = Color.White;

            }
          


        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {

                textBox1.Text = "Search Near or type a Url";
                textBox1.ForeColor = Color.DimGray;

            }

            url_n.Start();

        }

        private void bunifuImageButton5_Click_1(object sender, EventArgs e)
        {



            pictureBox1.Image = Properties.Resources.icons8_home_32px;
            this.BackColor = Color.FromArgb(21, 21, 21);
            panel1.Visible = false;
            label1.Text = "Home";
            textBox1.Text = "Search Near or type a Url";

        }

        private void gunaShadowPanel4_MouseEnter(object sender, EventArgs e)
        {
            l_f.ForeColor = Color.White;
        }

        private void gunaShadowPanel4_MouseLeave(object sender, EventArgs e)
        {
            l_f.ForeColor = Color.DimGray;
        }

        private void gunaShadowPanel1_MouseEnter(object sender, EventArgs e)
        {
            l_m.ForeColor = Color.White;
        }

        private void gunaShadowPanel1_MouseLeave(object sender, EventArgs e)
        {
            l_m.ForeColor = Color.DimGray;
        }

        private void gunaShadowPanel3_MouseEnter(object sender, EventArgs e)
        {
            l_w.ForeColor = Color.White;
        }

        private void gunaShadowPanel3_MouseLeave(object sender, EventArgs e)
        {
            l_w.ForeColor = Color.DimGray;
        }

        private void gunaShadowPanel5_MouseEnter(object sender, EventArgs e)
        {
            l_y.ForeColor = Color.White;
        }

        private void gunaShadowPanel5_MouseLeave(object sender, EventArgs e)
        {
            l_y.ForeColor = Color.DimGray;
        }

        private void gunaShadowPanel4_Click(object sender, EventArgs e)
        {

            if (Cef.IsInitialized == true)
            {

                t.Text = "https://www.facebook.com/";
                //  label1.Text = "facebook";
                // pictureBox1.Image = Properties.Resources.icons8_facebook_old_20px;

                try
                {
                   chrom.Reload();
                    chrom.TitleChanged += titel_;
                }
                catch (Exception)
                {
                }

              
               

                chrom = new ChromiumWebBrowser(t.Text);
                panel1.BackColor = Color.FromArgb(21, 21, 21);
                panel1.Visible = true;
                panel1.Controls.Clear();
                panel1.Controls.Add(chrom);
                chrom.Dock = DockStyle.Fill;

                // textBox1.Text = t.Text;

            }

        }

        private void gunaShadowPanel1_Click(object sender, EventArgs e)
        {

            if (Cef.IsInitialized == true)
            {


                t.Text = "https://www.messenger.com/";
                //  label1.Text = "messenger";
                //  pictureBox1.Image = Properties.Resources.icons8_facebook_messenger_20px;

                try
                {
                 chrom.Reload();
                    chrom.TitleChanged += titel_;

                }
                catch (Exception)
                {
                }

         
               

                chrom = new ChromiumWebBrowser(t.Text);
                panel1.BackColor = Color.FromArgb(21, 21, 21);
                panel1.Visible = true;
                panel1.Controls.Clear();
                panel1.Controls.Add(chrom);
                chrom.Dock = DockStyle.Fill;

                //   textBox1.Text = t.Text;

            }

        }

        private void gunaShadowPanel3_Click(object sender, EventArgs e)
        {
            if (Cef.IsInitialized == true)
            {


                t.Text = "https://web.whatsapp.com/";
                //   label1.Text = "whatsapp";
                // pictureBox1.Image = Properties.Resources.icons8_whatsapp_20px;


                try
                {
                  chrom.Reload();
                    chrom.TitleChanged += titel_;
                }
                catch (Exception)
                {
                }

                
                

                chrom = new ChromiumWebBrowser(t.Text);
                panel1.BackColor = Color.FromArgb(21, 21, 21);
                panel1.Visible = true;
                panel1.Controls.Clear();
                panel1.Controls.Add(chrom);
                chrom.Dock = DockStyle.Fill;

                //  textBox1.Text = t.Text;

            }
        }

        private void gunaShadowPanel5_Click(object sender, EventArgs e)
        {
            if (Cef.IsInitialized == true)
            {

                t.Text = "https://www.youtube.com/";
                //  label1.Text = "youtube";
                //  pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                try
                {
                   chrom.Reload();
                   chrom.TitleChanged += titel_;
                }
                catch (Exception)
                {
                }

               
              


                chrom = new ChromiumWebBrowser(t.Text);
                panel1.BackColor = Color.FromArgb(21, 21, 21);
                panel1.Visible = true;
                panel1.Controls.Clear();
                panel1.Controls.Add(chrom);
                chrom.Dock = DockStyle.Fill;

                //    textBox1.Text = t.Text;

            }
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Search Near or type a Url")
            {

                textBox2.Text = string.Empty;
                textBox2.ForeColor = Color.Black;

            }

        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {

            if (textBox2.Text == string.Empty)
            {

                textBox2.Text = "Search Near or type a Url";
                textBox2.ForeColor = Color.DimGray;

            }

            //if (textBox2.Text == string.Empty)
            //{

            //    textBox2.ForeColor = Color.FromArgb(117, 117, 117);
            //    textBox2.Text = "Search Near or type a Url";

            //}
            //else
            //{

            //    textBox2.ForeColor = Color.FromArgb(117, 117, 117);

            //}
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DimGray;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DimGray;
        }


       
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;

                if (Cef.IsInitialized == true)
                {
                   

                    if (textBox2.Text.Contains("https://soundcloud.com/"))
                    {


                        t.Text = "https://soundcloud.com/search?q=" + textBox2.Text.Replace("https://soundcloud.com/", "");

                        //  label1.Text = textBox2.Text;                    
                        // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                        try
                        {
                            chrom.Reload();
                            chrom.TitleChanged += titel_;
                        }
                        catch (Exception)
                        {
                        }



                        chrom = new ChromiumWebBrowser(t.Text);
                        panel1.BackColor = Color.FromArgb(21, 21, 21);
                        panel1.Visible = true;
                        panel1.Controls.Clear();
                        panel1.Controls.Add(chrom);
                        chrom.Dock = DockStyle.Fill;

                    }
                    else if (!textBox2.Text.Contains("https://www."))
                    {


                        if (textBox2.Text.Contains("https://web."))
                        {


                            t.Text = textBox2.Text;
                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }


                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }
                        else if (textBox2.Text.Contains("https://www.google.com/gmail/"))
                        {

                            t.Text = textBox2.Text;

                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }



                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }
                        else if (textBox2.Text.Contains("https://calendar.google.com"))
                        {

                            t.Text = textBox2.Text;

                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }



                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }
                        else if (textBox2.Text.Contains("https://drive.google.com"))
                        {

                            t.Text = textBox2.Text;

                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }



                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }
                        else if (textBox2.Text.Contains("https://www.google.com/earth/"))
                        {

                            t.Text = textBox2.Text;

                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }



                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }
                        else if (textBox2.Text.Contains("https://www.google.com/maps"))
                        {

                            t.Text = textBox2.Text;

                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }



                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }
                        else if (textBox2.Text.Contains("https://photos.google.com"))
                        {

                            t.Text = textBox2.Text;

                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }



                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }
                        else if (textBox2.Text.Contains("https://play.google.com"))
                        {

                            t.Text = textBox2.Text;

                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }



                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }
                        else if (textBox2.Text.Contains("https://translate.google.com.eg"))
                        {

                            t.Text = textBox2.Text;

                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }



                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }
                        else
                        {


                            t.Text = "https://www.google.com/search?q=" + textBox2.Text;
                            //  label1.Text = textBox2.Text;                    
                            // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                            try
                            {
                                chrom.Reload();
                                chrom.TitleChanged += titel_;
                            }
                            catch (Exception)
                            {
                            }



                            chrom = new ChromiumWebBrowser(t.Text);
                            panel1.BackColor = Color.FromArgb(21, 21, 21);
                            panel1.Visible = true;
                            panel1.Controls.Clear();
                            panel1.Controls.Add(chrom);
                            chrom.Dock = DockStyle.Fill;

                        }

                    }
                    else {

                       


                            t.Text = textBox2.Text;
                        //  label1.Text = textBox2.Text;                    
                        // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                        try
                        {
                            chrom.Reload();
                            chrom.TitleChanged += titel_;
                         
                        }
                        catch (Exception)
                        {
                        }


                        chrom = new ChromiumWebBrowser(t.Text);
                        panel1.BackColor = Color.FromArgb(21, 21, 21);
                        panel1.Visible = true;
                        panel1.Controls.Clear();
                        panel1.Controls.Add(chrom);
                        chrom.Dock = DockStyle.Fill;


                    }
                    // textBox1.Text = t.Text;

                }

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;

                if (Cef.IsInitialized == true)
                {


                    t.Text = "https://www.google.com/search?q=" + textBox1.Text;
                    //  label1.Text = textBox1.Text;
                    // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                    try
                    {
                        chrom.Reload();
                        chrom.TitleChanged += titel_;
                    }
                    catch (Exception)
                    {
                    }
                   


                    chrom = new ChromiumWebBrowser(t.Text);
                    panel1.BackColor = Color.FromArgb(21, 21, 21);
                    panel1.Visible = true;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(chrom);
                    chrom.Dock = DockStyle.Fill;

                    //  textBox1.Text = chrom.Address;

                }

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

            if (Cef.IsInitialized == true)
            {


                t.Text = "https://accounts.google.com/";
                //  label1.Text = "youtube";
                // pictureBox1.Image = Properties.Resources.icons8_play_button_20px;

                try
                {
                    chrom.Reload();
                    chrom.TitleChanged += titel_;
                }
                catch (Exception)
                {
                }
               


                chrom = new ChromiumWebBrowser(t.Text);
                panel1.BackColor = Color.FromArgb(21, 21, 21);
                panel1.Visible = true;
                panel1.Controls.Clear();
                panel1.Controls.Add(chrom);
                chrom.Dock = DockStyle.Fill;

                //    textBox1.Text = t.Text;

            }

        }

        private void url_n_Tick(object sender, EventArgs e)
        {

            try
            {
              //  textBox1.Text = chrom.Address;


                //var webGet = new HtmlWeb();
                //var document = webGet.Load(textBox1.Text);
                //var title = document.DocumentNode.SelectSingleNode("html/head/title").InnerText;

                //label1.Text = title;

                if (panel1.Visible == false)
                {

                    pictureBox1.Image = Properties.Resources.icons8_home_32px;

                }
                else
                {

                    pictureBox1.ImageLocation = "http://" + new Uri(chrom.Address.ToString()).Host + "/favicon.ico";
                    pictureBox1.ErrorImage = Properties.Resources.icons8_globe_20px_1;
                    pictureBox1.InitialImage = Properties.Resources.icons8_globe_20px_1;



                }


                chrom.FrameLoadStart += OnFrameLoadStart;
                chrom.FrameLoadEnd += endFrameLoadStart;
                chrom.LoadError += error_load;
                chrom.TitleChanged += titel_;

                System.Threading.Thread.Sleep(1);

            }
            catch (Exception)
            {

            }


        }

        public static string t_;
        public string newname;
        private void titel_(object sender, TitleChangedEventArgs e)
        {

            textBox1.Text = chrom.Address;

            t_ = e.Title;

            if (panel1.Visible == false)
            {

                label1.Text = "Home";
                this.Name = "Home";
                this.Text = "Home";


            }
            else
            {

                if (t_.Length >= 30)
                    newname = t_.Substring(0, 30) + "...";
                else
                    newname = t_;

                label1.Text = newname;
                this.Name = t_;
                this.Text = t_;

            }


        }

        string s;

        private void endFrameLoadStart(object sender, FrameLoadEndEventArgs e)
        {

            s = "Done";

        }

        private void OnFrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {

            s = "loading...";


        }
        private void error_load(object sender, LoadErrorEventArgs e)
        {
            s = "Error load";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = s;



            System.Threading.Thread.Sleep(1);
        }
        private void p_key_MouseEnter(object sender, EventArgs e)
        {
            p_key.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void p_key_MouseLeave(object sender, EventArgs e)
        {
            p_key.BaseColor = Color.Transparent;
        }

        private void gunaElipsePanel4_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel4.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void gunaElipsePanel4_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel4.BaseColor = Color.Transparent;
        }

        private void gunaElipsePanel5_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel5.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void gunaElipsePanel5_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel5.BaseColor = Color.Transparent;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\" + SystemInformation.UserName + @"\Desktop\NEAR_VOS_TOOLS\keyboard_\bin\x64\Release\keyboard_.exe");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.StandardInput.WriteLine("cd/.. & cd Users & cd " + SystemInformation.UserName + " & cd Desktop & cd NEAR_VOS_TOOLS & cd we_browser_ & cd bin & cd x64 & cd Release & start we_browser_.exe");
            p.StandardInput.Flush();
            p.StandardInput.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.StandardInput.WriteLine("cd/.. & cd Users & cd " + SystemInformation.UserName + " & cd Desktop & cd NEAR_VOS_TOOLS & cd we_browser_ & cd bin & cd x64 & cd Release & start we_browser_.exe");
            p.StandardInput.Flush();
            p.StandardInput.Close();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel3.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel3.BaseColor = Color.Transparent;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel6.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel6.BaseColor = Color.Transparent;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "Search Near or type a Url")
            {

                var processes = System.Diagnostics.Process.GetProcessesByName("Chrome");
                var path = processes.FirstOrDefault()?.MainModule?.FileName;
                System.Diagnostics.Process.Start(path, textBox1.Text);

            }

        }

        int min_ = 0;

        private void min_Tick_1(object sender, EventArgs e)
        {
            min_ += 1;

            if (min_ == 2)
            {

                this.WindowState = FormWindowState.Minimized;

            }
            if (min_ == 3)
            {

                min_ = 0;
                min.Stop();

            }
        }

        private void Near_Browser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.M)
            {
                e.SuppressKeyPress = true;

                this.WindowState = FormWindowState.Minimized;

            }
        }

        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {

                textBox1.ForeColor = Color.DarkGray;
                textBox1.Text = "Search Near or type a Url";

            }
            else
            {

                textBox1.ForeColor = Color.DarkGray;

            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {

                textBox2.ForeColor = Color.FromArgb(117, 117, 117);
                textBox2.Text = "Search Near or type a Url";

            }
            else
            {

                textBox2.ForeColor = Color.FromArgb(117, 117, 117);

            }
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            try
            {

                turl = textBox1.Text;

            }
            catch (Exception)
            {
            }

            if (textBox1.Text.Contains("https://www.youtube.com/watch?v="))
            {


                SendKeys.SendWait("k");

                bool y_v = false;

                for (int i = 0; i < Application.OpenForms.Count; i++)
                {

                    Form n = Application.OpenForms[i];
                    if ((n.Name == "youtube_v"))
                    {
                        n.Close();
                        youtube_v yv = new youtube_v();
                        yv.Show();
                        y_v = true;

                    }

                    System.Threading.Thread.Sleep(1);
                }
                if (!y_v)
                {

                    youtube_v yv = new youtube_v();
                    yv.Show();


                }

                min.Start();


            }
            else
            {

                this.WindowState = FormWindowState.Minimized;

            }
        }
    }
}
