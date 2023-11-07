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
    public partial class VentasSobrante : Form
    {

        //esta es la tabla sobranteRestaurante
        //se ingresa la fecha de la venta que se desea buscar

        private void textBoxFechaBuscarR_TextChanged(object sender, EventArgs e)
        {

        }

        //Se busca la venta ingresada y se muestra en GridDataView

        private void buttonBuscarFechaR_Click(object sender, EventArgs e)
        {

        }

        //aqui es donde se muestra la venta escogida segun el dia, y siempre se debe mostrar, aquí mismo se muestran todas la ventas al presionar el boton mostrar todo

        private void dataGridViewTablaRestaurante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //espacios y botonoes para ingresar el dato y guardarlo

        private void textBoxDiaR_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonguardarDiaR_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAMR_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarAMR_Click(object sender, EventArgs e)
        {

        }
        private void textBoxPMR_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarPMR_Click(object sender, EventArgs e)
        {

        }

        //agregar, editar o eliminar la venta según los datos que se pongan, iguala como se ha estado haciendo.

        private void buttonAgregarVentaR_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditarVentaR_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarVentaR_Click(object sender, EventArgs e)
        {

        }

        //mostrat todas las ventas

        private void buttonMostrarTodoRestaurante_Click(object sender, EventArgs e)
        {

        }

        //es la tabla sobranteTiki
        //son las mismas intrucciones que las de arriba

        private void textBoxFechaBuscarT_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarFechaT_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroDiaT_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarNumeroDiaT_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAMT_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarAMT_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPMT_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonguardarPMT_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarVentaT_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditarVentaT_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarVentaT_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostarTodoT_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolverMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenuVentas_Click(object sender, EventArgs e)
        {
            Ventas ventasForm = new Ventas();
            ventasForm.Show();
            this.Hide();
        }
    }
}
