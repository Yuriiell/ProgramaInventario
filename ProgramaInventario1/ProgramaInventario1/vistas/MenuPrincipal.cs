using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaInventario1.vistas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void botonVistaProductos_Click(object sender, EventArgs e)
        {
            Productos productosForm = new Productos();
            productosForm.Show();
            this.Close();
        }

        private void botonVistaMermas_Click(object sender, EventArgs e)
        {
            Mermas mermasForm = new Mermas();
            mermasForm.Show();
            this.Close();
        }

        private void botonVistaVerduras_Click(object sender, EventArgs e)
        {
            Verduras verdurasForm = new Verduras();
            verdurasForm.Show();
            this.Close();
        }

        private void botonVistaInterno_Click(object sender, EventArgs e)
        {
            Interno internoForm = new Interno();
            internoForm.Show();
            this.Close();
        }

        private void botonVistaPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidosForm = new Pedidos();
            pedidosForm.Show();
            this.Close();
        }

        private void botonVistaVEntas_Click(object sender, EventArgs e)
        {
            Ventas ventasForm = new Ventas();
            ventasForm.Show();
            this.Close();
        }

        private void botonVistaLicores_Click(object sender, EventArgs e)
        {
            Licores licoresForm = new Licores();
            licoresForm.Show();
            this.Close();
=======
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

>>>>>>> prueba
        }

        private void botonVistaResumen_Click(object sender, EventArgs e)
        {
            Resumen resumenForm = new Resumen();
            resumenForm.Show();
<<<<<<< HEAD
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

=======
            this.Hide();
>>>>>>> prueba
        }

        private void buttonSalirPrograma_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }
    }
}
=======
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int indice = cmb.SelectedIndex;
            if (indice == 0)
            {
                Productos productosForm = new Productos();
                productosForm.Show();
                this.Hide();
            }
            else if (indice == 1)
            {
                Mermas mermasForm = new Mermas();
                mermasForm.Show();
                this.Hide();
            }
            else if (indice == 2)
            {
                Verduras verdurasForm = new Verduras();
                verdurasForm.Show();
                this.Hide();
            }
            else if (indice == 3)
            {
                Interno internoForm = new Interno();
                internoForm.Show();
                this.Hide();
            }
            else if (indice == 4)
            {
                Pedidos pedidosForm = new Pedidos();
                pedidosForm.Show();
                this.Hide();
            }
            else if (indice == 5)
            {
                Ventas ventasForm = new Ventas();
                ventasForm.Show();
                this.Hide();
            }
            else
            {
                Licores licoresForm = new Licores();
                licoresForm.Show();
                this.Hide();
            }
        }
    }
}

>>>>>>> prueba
