using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

     
        private void toolStripComboBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(url.Text);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnforward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url.Text);
        }

        private void home_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
         
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "MyBrowser : " + webBrowser1.DocumentTitle;

        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {

        }
    }
}
