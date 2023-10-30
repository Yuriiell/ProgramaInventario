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
        }

        private void botonVistaResumen_Click(object sender, EventArgs e)
        {
            Resumen resumenForm = new Resumen();
            resumenForm.Show();
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalirPrograma_Click(object sender, EventArgs e)
        {

        }
    }
}
