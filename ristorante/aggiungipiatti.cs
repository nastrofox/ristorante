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
    public partial class aggiungipiatti : Form
    {
        public aggiungipiatti()
        {
            InitializeComponent();
        }
        public string piatto;
        public string portata;
        public string ingrediente1;
        public string ingrediente2;
        public string ingrediente3;
        public string ingrediente4;
        public string Prezzo; 
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            proprietario ag = new proprietario();
            ag.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            piatto = textBox1.Text;
            portata=textBox2.Text;
            ingrediente1=textBox3.Text;
            ingrediente2=textBox4.Text;
            ingrediente3=textBox5.Text;
            ingrediente4=textBox6.Text;
            Prezzo = textBox7.Text;
            if (portata == "Primo" || portata == "Secondo" || portata == "Contorno" || portata == "Dolce")
            {
                StreamWriter sw = new StreamWriter($@".\data\piatti\{portata}.txt");
                sw.WriteLine(piatto+";"+Prezzo+";" + ingrediente1 + ";" + ingrediente2 + ";" + ingrediente3 + ";" + ingrediente4);
                sw.Close();
                MessageBox.Show("Piatto salvato con successo");
                proprietario form6 = new proprietario(); this.Visible = false; form6.ShowDialog(); this.Visible = true;
            }
            else
                MessageBox.Show("Portata non inserita o portata sbagliata");
            
        }
    }
}
