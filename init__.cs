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

namespace we_browser_
{
    public partial class init__ : Form
    {

        public init__()
        {
            InitializeComponent();

            if (Cef.IsInitialized)
            {

            }
            else { 
            
             CefSettings settings = new CefSettings();
                settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763";
                settings.CachePath = @"C:\Windows\NEAR_OS\Default\Cache";
                settings.CefCommandLineArgs.Add("disable-gpu", "1");
            Cef.Initialize(settings);
            
            
            }

           

            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;


        }


        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }


        private void init___Load(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();

                Near_Browser nb = new Near_Browser();

                nb.Show();



        }
    }
}
