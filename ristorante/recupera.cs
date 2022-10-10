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
    public partial class recupera : Form
    {
        public recupera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pollo = 0;
            Ricerca(@".\data\piatti\Primo.txt", ref pollo);
            Ricerca(@".\data\piatti\Secondo.txt", ref pollo);
            Ricerca(@".\data\piatti\Contorno.txt", ref pollo);
            Ricerca(@".\data\piatti\Dolce.txt", ref pollo);
            if (pollo == 0)
            {
                MessageBox.Show("Piatto non trovato");
            }
            else
            {
                MessageBox.Show("Recupero effettuato");
                this.Hide();
                mam ag = new mam();
                ag.ShowDialog();
                this.Close();
            }

        }
        public void Ricerca(string filename, ref int pollo)
        {
            StreamReader sr = new StreamReader(filename);
            StreamWriter sw = new StreamWriter(@".\data\piatti\temp.txt");
            string drone = sr.ReadLine();
            while (drone != null)
            {
                if (textBox1.Text == drone.Split(';')[0])
                {
                    sw.WriteLine(drone.Split(';')[0] + ";" + drone.Split(';')[1] + ";" + drone.Split(';')[2] + ";" + drone.Split(';')[3] + ";" + drone.Split(';')[4] + ";" + drone.Split(';')[5] + ";True");
                    pollo++;
                }
                else
                {
                    sw.WriteLine(drone);
                }
                drone = sr.ReadLine();

            }
            sr.Close();
            sw.Close();
            System.IO.File.Delete(filename);
            System.IO.File.Move(@".\data\piatti\temp.txt", filename);
            
        }
    }
}
