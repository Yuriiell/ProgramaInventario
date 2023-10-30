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
    public partial class Ventas : Form
    {

        public Ventas()
        {
            InitializeComponent();
        }

        //va al forms de VentasVentaDiaria

        private void buttonVentasVentaDiaria_Click(object sender, EventArgs e)
        {

        }

        //va al forms de VentasSobrante

        private void buttonVentasSobrante_Click(object sender, EventArgs e)
        {

        }

        //va al menu principal

        private void buttonVolverMenuPrinciapl_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }
    }
}
