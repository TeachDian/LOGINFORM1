using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace LOGINFORM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            username_txt.MaxLength = 20;
            password_txt.MaxLength = 24;
        }

        private void Facebooklink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.facebook.com/johnphilip.sabinet");
            //Process.Start("http://www.facebook.com/johnphilip.sabinet");
        }

        private void Emaillink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("explorer.exe", "https://mail.google.com/mail/u/1/#inbox?compose=GTvVlcSDbFffDXNkGwQZtlbPKlzrvxcfMPzdVMTtlTzwZBzgdQSMDFqlMSCxsrvvdrVdbflGtzxfg");
            //Process.Start("https://mail.google.com/mail/u/1/#inbox?compose=GTvVlcSDbFffDXNkGwQZtlbPKlzrvxcfMPzdVMTtlTzwZBzgdQSMDFqlMSCxsrvvdrVdbflGtzxfg");
        }

        private void Githublink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/TeachDian");
            //Process.Start("https://github.com/TeachDian");
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (username_txt.Text == "user" && password_txt.Text == "123"
                || username_txt.Text == "admin" && password_txt.Text == "admin"
                || username_txt.Text == "philip" && password_txt.Text == "111111111111111111111111")
            {
                MessageBox.Show ( "~You are now logged in");
                //this.Hide();
                //hyperlink
                Form1 home = new Form1();
                home.Show();
                this.Hide();

            }
            else
            {

                AstroDialog.Text = "~Ooopps!!!!";
                //AstroDialog.Text = "~HAHAHA!!!";
            }
        }

        private void Form2link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();




        }
    }
}
