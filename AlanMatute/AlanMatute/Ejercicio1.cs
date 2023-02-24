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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }


        private void Periodo()
        {

            DepositoTextbox.Focus();
            string[] Arreglo1 = new string[] {"1 de Enero 2023", "1 de Febrero 2023", "1 de Marzo 2023",
                                              "1 de Abril 2023", "1 de Mayo 2023", "1 de Junio 2023",
                                              "1 de Julio 2023", "1 de Agosto 2023", "1 de Septiembre 2023",
                                              "1 de Octubre 2023", "1 de Noviembre 2023", "1 de Diciembre 2023"};
            for (int i = 0; i < Arreglo1.Length; i++)
            {
                double deposito = Convert.ToDouble(DepositoTextbox.Text);
                double interes = deposito * 1.5 / 100 * i;
                double total = interes + deposito;
                listBox1.Items.Add(Arreglo1[i] + "                    " + interes + "                   Ahorro Total:      " + total + "\n");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Periodo();

        }


        private void BorrarButton_Click(object sender, EventArgs e)
        {
            DepositoTextbox.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
