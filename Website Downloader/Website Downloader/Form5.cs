using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Website_Downloader
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

       
        private void search_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(url.Text);
        }

        private void forward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void back_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            url.Text = e.Url.ToString();
        }

           }
}
