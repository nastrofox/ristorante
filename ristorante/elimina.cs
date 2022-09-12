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
    public partial class elimina : Form
    {
        public elimina()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show("Eliminazione logica eseguita con successo");
            }

        }
        public void Ricerca(string filename, ref int pollo)
        {
            StreamReader sr = new StreamReader(filename);
            StreamWriter sw = new StreamWriter(@".\data\piatti\temp.txt");
            string drone = sr.ReadLine();
            while (drone != null)
            {
                if (godo.Text == drone.Split(';')[0])
                {
                    sw.WriteLine(drone.Split(';')[0] + ";" + drone.Split(';')[1] + ";" + drone.Split(';')[2] + ";" + drone.Split(';')[3] + ";" + drone.Split(';')[4] + ";" + drone.Split(';')[5] + ";False");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filename = new string[] { @".\data\piatti\Primo.txt", @".\data\piatti\Secondo.txt", @".\data\piatti\Contorno.txt", @".\data\piatti\Dolce.txt" };
            for (int i = 0; i < filename.Length; i++)
            {
                StreamReader sr = new StreamReader(filename[i]);
                StreamWriter sw = new StreamWriter(@".\data\piatti\temp.txt");
                string drone = sr.ReadLine();
                while (drone != null)
                {
                    if (drone.Split(';')[6]!="False")
                    {
                        sw.WriteLine(drone);
                    }
                    drone = sr.ReadLine();
                }
                sr.Close();
                sw.Close();
                System.IO.File.Delete(filename[i]);
                System.IO.File.Move(@".\data\piatti\temp.txt", filename[i]);
            }
        }
    }
}
