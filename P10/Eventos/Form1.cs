using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        Productos comida;
        ArrayList platillos;

        public Form1()
        {
            InitializeComponent();
            platillos = new ArrayList();
            platillos.Add(new Productos("Chilaquiles","320 g",45));
            foreach (Productos x in platillos)
            {
                cmbPlatillo.Items.Add(x.nombre);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            lbPagado.Text = "¡Has pagado tu orden!";
            lbPagado.Visible = true;
            pictureBox1.Visible = true;
            btnComer.Visible = true;
        }

        private void cmbPlatillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comida = (Productos)platillos[cmbPlatillo.SelectedIndex];
            txtbPrecio.Text = Convert.ToString(comida.precio);
            txtbCantidad.Text = comida.cantidad;
        }

        private void btnComer_Click(object sender, EventArgs e)
        {
            lbPagado.Visible = false;
            lbComido.Text = "Te has comido tu platillo.";
            lbComido.Visible = true;
            pictureBox1.Visible = false;
        }
    }
}
