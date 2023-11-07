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
    public partial class Resumen : Form
    {
        public Resumen()
        {
            InitializeComponent();
        }

        private void Resumen_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }
    }
}
