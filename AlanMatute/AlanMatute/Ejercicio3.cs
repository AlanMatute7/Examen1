using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanMatute
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        Random random = new Random();

        public void NumeroAleatorio()
        {
            int[] Arreglo1 = new int[100];
            for (int i = 1; i < Arreglo1.Length; i++)
            {

                //Genera un numero entre 1 y 100 (101 no se incluye)
                Arreglo1[i] = random.Next(1, 100);

                if (Arreglo1[i] % 3 == 0 && Arreglo1[i] % 5 != 0)
                {
                    Arreglo1[i] = random.Next(1, 100);
                    AleatorioListBox.Items.Add("[*" + Arreglo1[i] + " ALAN*]");
                }

                if (Arreglo1[i] % 5 == 0 && Arreglo1[i] % 3 != 0)
                {
                    Arreglo1[i] = random.Next(1, 100);
                    AleatorioListBox.Items.Add("[*" + Arreglo1[i] + " MATUTE*]");
                }

                if (Arreglo1[i] % 5 == 0 && Arreglo1[i] % 3 == 0)
                {
                    Arreglo1[i] = random.Next(1, 100);
                    AleatorioListBox.Items.Add("[*" + Arreglo1[i] + " ALAN MATUTE*]");
                }
            }

        }

        

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumeroAleatorio();
        }
    }
}
