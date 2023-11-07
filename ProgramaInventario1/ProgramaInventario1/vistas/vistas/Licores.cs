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
    public partial class Licores : Form
    {
        public Licores()
        {
            InitializeComponent();
        }

        private void buttonVolverMenúPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }

        private void buttonLicoresLicor_Click(object sender, EventArgs e)
        {
            LicoresLicor licoresLicorForm = new LicoresLicor();
            licoresLicorForm.Show();
            this.Close();
        }

        private void buttonLicoresRestaurante_Click(object sender, EventArgs e)
        {
            ButtonVovlerMenuLicores licoresRestauranteForm = new ButtonVovlerMenuLicores();
            licoresRestauranteForm.Show();
            this.Close();
        }

        private void buttonLicoresTiki_Click(object sender, EventArgs e)
        {
            LicoresTiki licoresTikiForm = new LicoresTiki();
            licoresTikiForm.Show();
            this.Close();
        }
    }
}
