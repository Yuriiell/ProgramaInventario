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
    public partial class Pedidos : Form
    {

        //en la base de datos la tabla se llama Pedido

        public Pedidos()
        {
            InitializeComponent();
        }

        //aqui es donde el usuario introduce el nombre del producto que desea buscar

        private void textBoxNombreProductoBuscar_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //este boton elimina el producto que habia escogido

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        //aqui se ingresa el dia en el que quiere realizar el registro, es el campo dia de la tabla, con el siguiente formato (1-7, 8-14, 15-21, 22-28, 29-31)

        private void textBoxDias_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar el dia

        private void buttonGuardarDias_Click(object sender, EventArgs e)
        {

        }

        //aqui se ingersa la cantidad del pedido, es el campo CantidadPedido de la tabla

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar la cantidad

        private void buttonGuardarCantidad_Click(object sender, EventArgs e)
        {

        }

        //aqui se agrega el inventario inicial, la columna en la tabla se llama invInicial

        private void textBoxInvInicial_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar el inventario inicial

        private void buttonGuardarInvInicial_Click(object sender, EventArgs e)
        {

        }

        //aqui se agrega el inventario final, la columna en la tabla se llama invFinal

        private void textBoxInvFinal_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar el inventario final

        private void buttonGuardarInvFinal_Click(object sender, EventArgs e)
        {

        }

        //este es el boton para agregar el producto escogido

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        //este boton edita la infromacion que se haya ingresado en los text box y se edita del producto previamente escogido.
        //en los textbox, se puede ingresa cierta información, no necesariamente todo y solo cambia lo que se ingrese lo demás que no se haya puesto se queda igual.

        private void buttonEditarPoducto_Click(object sender, EventArgs e)
        {

        }

        //Con este boton se muestra toda la infromacion de toda la tabla 


        private void buttonBuscarTodo_Click(object sender, EventArgs e)
        {

        }

        //Para regresar al menu de  principal

        private void buttonVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }
    }
}
