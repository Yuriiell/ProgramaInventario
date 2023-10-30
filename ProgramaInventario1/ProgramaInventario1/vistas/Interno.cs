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
    public partial class Interno : Form
    {
        public Interno()
        {
            InitializeComponent();
        }

        //este botón e spara volver al menu principal

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }

        // este boton es para ir al forms InternoProductos

        private void buttonPlatosBebidas_Click(object sender, EventArgs e)
        {
            InternoProductos internoProductosForm = new InternoProductos();
            internoProductosForm.Show();
            this.Close();
        }

        //este boton es para ir al forms InternoConsumo

        private void buttonConsumoInterno_Click(object sender, EventArgs e)
        {
            InternoConsumo internoConsumoForm = new InternoConsumo();
            internoConsumoForm.Show();
            this.Close();
        }
    }
}
