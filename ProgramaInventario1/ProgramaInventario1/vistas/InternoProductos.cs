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
    public partial class InternoProductos : Form
    {

        //en la base de datos la tabla se llama Plato y LicorConsumoInterno
        public InternoProductos()
        {
            InitializeComponent();
        }

        //Aquí el usuario debe ingresar el nombre del plato que desee hacerle crud


        private void textBoxNombrePlatoBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton busca el plato o platos en la base de datos


        private void buttonBuscarPlato_Click(object sender, EventArgs e)
        {

        }

        //Debe tener todos los platos precargados.
        //Y aqui es donde se debe mostar las opciones que se parezcan al plato buscado o que contengan la palabra que se busca, porque
        //pueden haber varios tipos de arroz y el cliente solo pidio buscar arroz, deben salir todas las opciones que coincida, 
        //y que no tome en cuenta mayusculas o minusculas. El usuario debe escoger una opcion de plato para que se muestre toda la infromación 
        //en el elmento de abajo. 

        private void comboBoxPlatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //boton para seleccionar el plato que se ecogió en el combobox de arriba

        private void buttonSeleccionarPlato_Click(object sender, EventArgs e)
        {

        }

        //Aquí ya se debe mostar en el formato de tabla toda la información guardada del producto. Siempre se debe mostrar lo busacado

        private void dataGridViewPlatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //este boton elimina el plato que habia escogido

        private void buttonEliminarPlato_Click(object sender, EventArgs e)
        {

        }

        //aqui se ingresa la infromación a editar o para crear plato

        private void textBoxNombrePlato_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidadPlato_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGramajePlato_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton edita la infromacion que se haya ingresado en los text box y se edita del plato previamente escogido.
        //en los textbox, se puede ingresa cierta información, no necesariamente todo y solo cambia lo que se ingrese lo demás que no se haya puesto se queda igual.


        private void buttonEditarPlato_Click(object sender, EventArgs e)
        {

        }

        //este es el boton para agregar un plato con la infromación ingresada arriba

        private void buttonAgregarPlato_Click(object sender, EventArgs e)
        {

        }

        //Con este boton se muestra toda la infromacion de toda la tabla 

        private void buttonBuscarTodoPlato_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolverMenuInterno_Click(object sender, EventArgs e)
        {
            Interno internoForm = new Interno();
            internoForm.Show();
            this.Hide();
        }

        //este es del lado de las bebidas

        //Aquí el usuario debe ingresar el nombre de la bebida que desee hacerle crud

        private void textBoxNombreBebidaBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton busca la bebida o bebidas en la base de datos

        private void buttonBuscarBebida_Click(object sender, EventArgs e)
        {

        }

        //Debe tener todos las bebidas precargados.
        //Y aqui es donde se debe mostar las opciones que se parezcan al producto buscado o que contengan la palabra que se busca, porque
        //pueden haber varios tipos de arroz y el cliente solo pidio buscar arroz, deben salir todas las opciones que coincida, 
        //y que no tome en cuenta mayusculas o minusculas. El usuario debe escoger una opcion de bebidas para que se muestre toda la infromación 
        //en el elmento de abajo. 

        private void comboBoxBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //boton para seleccionar ela bebida que se ecogió en el combobox de arriba

        private void buttonSeleccionarBebida_Click(object sender, EventArgs e)
        {

        }

        //Aquí ya se debe mostar en el formato de tabla toda la información guardada de la bebida. Siempre se debe mostrar lo busacado


        private void dataGridViewBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //este boton elimina ela bebida que habia escogido

        private void buttonEliminarBebida_Click(object sender, EventArgs e)
        {

        }

        //aqui se ingresa la infromación a editar o para crear la bebida

        private void textBoxNombreBebida_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidadBebida_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGramajeBebida_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton edita la infromacion que se haya ingresado en los text box y se edita la bebida previamente escogida.
        //en los textbox, se puede ingresa cierta información, no necesariamente todo y solo cambia lo que se ingrese lo demás que no se haya puesto se queda igual.

        private void buttonEditarBebida_Click(object sender, EventArgs e)
        {

        }

        //este es el boton para agregar una bebida con la infromación ingresada arriba

        private void buttonAgregarbebida_Click(object sender, EventArgs e)
        {

        }

        //Con este boton se muestra toda la infromacion de toda la tabla 

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
