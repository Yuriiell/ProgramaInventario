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
    public partial class Mermas : Form
    {
        public Mermas()
        {
            InitializeComponent();
        }

        //aqui el usuario ingresa manualmente el reporte.

        private void textBoxReporteMermas_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton guarda el monto ingresado por el usuario en el elemento de arriba

        private void buttonGuardarReporteMermas_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mermas_Load(object sender, EventArgs e)
        {

        }

        //botones para ir a los forms de cada tabla

        private void buttonVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }

        private void buttonMermasGastos_Click(object sender, EventArgs e)
        {
            MermasGasto mermasGastoForm = new MermasGasto();
            mermasGastoForm.Show();
            this.Hide();
        }

        private void buttonMermasCortes_Click(object sender, EventArgs e)
        {
            MermasCortes mermasCortesForm = new MermasCortes();
            mermasCortesForm.Show();
            this.Hide();
        }

        private void buttonMermasMalEstado_Click(object sender, EventArgs e)
        {
            MermasMalEstado mermasMalEstadoForm = new MermasMalEstado();
            mermasMalEstadoForm.Show();
            this.Hide();
        }

        private void buttonPlatosDevueltos_Click(object sender, EventArgs e)
        {
            MermasPlatosDevueltos mermasPlatosDevueltosForm = new MermasPlatosDevueltos();
            mermasPlatosDevueltosForm.Show();
            this.Hide();
        }

        private void buttonComidaPersonal_Click(object sender, EventArgs e)
        {
            MermasComidaPersonal mermasComidaPersonalForm = new MermasComidaPersonal();
            mermasComidaPersonalForm.Show();
            this.Hide();
        }

        private void buttonMermasFiestaChicas_Click(object sender, EventArgs e)
        {
            MermasFiestaChicas mermasFiestaChicasForm = new MermasFiestaChicas();
            mermasFiestaChicasForm.Show();
            this.Hide();
        }
    }
}
