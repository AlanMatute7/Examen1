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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        public async Task<decimal> FacturaAsync(decimal unitario, int cantidad)
        {

            decimal factura = await Task.Run(() =>
            {


                return (unitario * cantidad);

            });
                    
            return factura;

        }


        


        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            decimal Facturacion = await FacturaAsync(Convert.ToDecimal(PrecioTextBox.Text),
                                                Convert.ToInt32(CantidadTextbox.Text));

            decimal descuento = Facturacion * 15 / 100;
            decimal total = Facturacion - descuento;

            label5.Text = ("\n                ***************FACTURA**************              \n                          Pulperia Mapache \nCantidad        Descripción del Producto         Precio \n     -------------------------------------------------------------------------     \n      "
                                                                    + CantidadTextbox.Text + "                  " + ProductoTextBox.Text + "                   " + PrecioTextBox.Text + "     \n     -------------------------------------------------------------------------     \n                   Subtotal              "
                                                                    + Facturacion + " Lps. \n                   Descuento          " + descuento + " Lps. \n                   Total a Pagar      " + total + " Lps. \n                      ******************************     \n                       Gracias Por Su Compra");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoTextBox.Clear();
            PrecioTextBox.Clear();
            CantidadTextbox.Clear();
        }
    }
}
