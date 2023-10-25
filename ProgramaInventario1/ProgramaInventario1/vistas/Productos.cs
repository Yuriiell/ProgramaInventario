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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Aquí el usuario debe ingresar el nombre del producto que desee hacerle crud

        private void textBoxNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton busca el producto en la base de datos

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        //Debe tener todos los productos precargados.
        //Y aqui es donde se debe mostar las opciones que se parezcan al producto buscado o que contengan la palabra que se busca, porque
        //pueden haber varios tipos de arroz y el cliente solo pidio buscar arroz, deben salir todas las opciones que coincida, 
        //y que no tome en cuenta mayusculas o minusculas. El usuario debe escoger una opcion de producto para que se muestre toda la infromación 
        //en el elmento de abajo. 


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //boton para seleccionar el producto que se ecogió en el combobox de arriba
        private void buttonSeleccionarProducto_Click(object sender, EventArgs e)
        {

        }

        //Aquí ya se debe mostar en el formato de tabla toda la información guardada del producto. Siempre se debe mostrar lo busacado
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //este boton elimina el producto que habia escogido

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {

        }


        //aqui se ingresa la infromación a editar o para crear producto



        private void textBoxNombreProducto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUnidadMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTipoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton edita la infromacion que se haya ingresado en los text box y se edita del producto previamente escogido.
        //en los textbox, se puede ingresa cierta información, no necesariamente todo y solo cambia lo que se ingrese lo demás que no se haya puesto se queda igual.

        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {

        }

        //este es el boton para agregar un producto con la infromación ingresada arriba

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {

        }



        //Con este boton se muestra toda la infromacion de toda la tabla sigueinte

        private void buttonBuscarTodo_Click(object sender, EventArgs e)
        {

        }


        //Aqui se muestra todo el cuadro cuando se presiona el boton de mostrar toda la infromación
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
