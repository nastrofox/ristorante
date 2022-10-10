using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ristorante
{
    public partial class registrazione : Form
    {
        public string username;
        public string email;
        public string password;
        public registrazione()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ag = new Form1();
            ag.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = uno.Text;
            password =  tre.Text;
            if (uno.Text== null)
                MessageBox.Show("invalid username,please try again ");
            if (password == null)
                MessageBox.Show("invalid password,please try again ");
            else {
                StreamWriter sw = new StreamWriter($@".\data\staff\{username}.txt");
                sw.WriteLine(password);
                sw.Close();
            }
            uno.Clear();
            tre.Clear();


            this.Hide();
            mam ag = new mam();
            ag.ShowDialog();
            this.Close();

        }
    }
}
