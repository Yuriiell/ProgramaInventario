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
    public partial class Verduras : Form
    {

        //en la base de datos la tabla se llama ReporteGastoVerdura

        public Verduras()
        {
            InitializeComponent();
        }


        //aqui es donde el usuario introduce el nombre del producto que desea buscar

        private void textBoxProducto_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton busca el producto o productos en la base de datos

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        //Debe tener todos los productos precargados.
        //Y aqui es donde se debe mostar las opciones que se parezcan al producto buscado o que contengan la palabra que se busca, porque
        //pueden haber varios tipos de arroz y el cliente solo pidio buscar arroz, deben salir todas las opciones que coincida, 
        //y que no tome en cuenta mayusculas o minusculas. El usuario debe escoger una opcion de producto para que se muestre toda la infromación 
        //en el elmento de abajo. 

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //boton para seleccionar el producto que se ecogió en el combobox de arriba

        private void buttonSeleccionarProducto_Click(object sender, EventArgs e)
        {

        }

        //Aquí ya se debe mostar en el formato de tabla toda la información guardada del producto. Siempre se debe mostrar lo busacado. También se muestra toda la infromacion la presionar le boton de Mostrar Todo.

        private void dataGridViewTablaGasto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //aqui se ingresa el dia en el que quiere realizar el registro, es el campo dia de la tabla

        private void textBoxDia_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar el dia

        private void buttonguardarDia_Click(object sender, EventArgs e)
        {

        }

        //aqui se ingersa la cantidad por dia, es el campo CantidadGastoXDia de la tabla

        private void textBoxCAntidad_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar la cantidad

        private void buttonGuardarCantidad_Click(object sender, EventArgs e)
        {

        }

        //este es el boton para agregar el producto escogido

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        //este boton elimina el producto que habia escogido

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {

        }

        //Con este boton se muestra toda la infromacion de toda la tabla 

        private void buttonMostrarTodo_Click(object sender, EventArgs e)
        {

        }

        //Para regresar al menu de principal

        private void buttonVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }

        //este boton edita la infromacion que se haya ingresado en los text box y se edita del producto previamente escogido.
        //en los textbox, se puede ingresa cierta información, no necesariamente todo y solo cambia lo que se ingrese lo demás que no se haya puesto se queda igual.

        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
