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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void urlTextbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }     
        private void selectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
       
        private void next_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();              

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }           

       
    }
}
