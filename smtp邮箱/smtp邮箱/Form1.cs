using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smtp邮箱
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public smtp邮箱.Send mailSend = new smtp邮箱 .Send ();

        private void button1_Click(object sender, EventArgs e)
        {
            mailSend.sendEmail = textBox1.Text;
            mailSend.getEmail = textBox2.Text;
            mailSend.emailTitle = textBox3.Text;
            mailSend.emailContent = textBox4.Text;
            mailSend.SendStmpEmail();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
    }
}
