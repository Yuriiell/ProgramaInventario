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
    public partial class InternoConsumo : Form
    {

        //primero va la seccion de consumo interno y en la base de datos la tabla se llama ConsumoInterno


        public InternoConsumo()
        {
            InitializeComponent();
        }

        //aqui es donde el usuario introduce el nombre del plato que desea buscar

        private void textBoxNombreCI_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton busca el plato o platos en la base de datos

        private void buttonBuscarCI_Click(object sender, EventArgs e)
        {

        }

        //Debe tener todos los platos precargados.
        //Y aqui es donde se debe mostar las opciones que se parezcan al plato buscado o que contengan la palabra que se busca, porque
        //pueden haber varios tipos de arroz y el cliente solo pidio buscar arroz, deben salir todas las opciones que coincida, 
        //y que no tome en cuenta mayusculas o minusculas. El usuario debe escoger una opcion de plato para que se muestre toda la infromación 
        //en el elmento de abajo. 

        private void comboBoxCI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //boton para seleccionar el platos que se ecogió en el combobox de arriba

        private void buttonSeleccionarCI_Click(object sender, EventArgs e)
        {

        }

        //Aquí ya se debe mostar en el formato de tabla toda la información guardada del plato. Siempre se debe mostrar lo busacado. También se muestra toda la infromacion la presionar le boton de Mostrar Todo.

        private void dataGridViewTablaCI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //aqui se ingresa el costo con el que se quiere multiplicar el gramaje, es el campo costo de la tabla

        private void textBoxCostoCI_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar el costo

        private void buttonGuardarCI_Click(object sender, EventArgs e)
        {

        }

        //boton para agregar el plato

        private void buttonAgregarCI_Click(object sender, EventArgs e)
        {

        }

        //este boton edita la infromacion que se haya ingresado en los text box y se edita del plato previamente escogido.
        //en los textbox, se puede ingresa cierta información, no necesariamente todo y solo cambia lo que se ingrese lo demás que no se haya puesto se queda igual.


        private void buttonEditarCI_Click(object sender, EventArgs e)
        {

        }

        //este boton elimina el plato que habia escogido

        private void buttonEliminarCI_Click(object sender, EventArgs e)
        {

        }

        //Con este boton se muestra toda la infromacion de toda la tabla 

        private void buttonMostrarTodoCI_Click(object sender, EventArgs e)
        {

        }

        //ahora la segunda seccion de consumo de licor del restaurante y en la base de datos la tabla se llama ConsumoInternoLicRest

        //aqui es donde el usuario introduce el nombre del licor que desea buscar

        private void textBoxNombreLR_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton busca el licor o licores en la base de datos

        private void buttonBuscarLR_Click(object sender, EventArgs e)
        {

        }

        //Debe tener todos los licor precargados.
        //Y aqui es donde se debe mostar las opciones que se parezcan al licor buscado o que contengan la palabra que se busca, porque
        //pueden haber varios tipos de arroz y el cliente solo pidio buscar arroz, deben salir todas las opciones que coincida, 
        //y que no tome en cuenta mayusculas o minusculas. El usuario debe escoger una opcion de licor para que se muestre toda la infromación 
        //en el elmento de abajo. 

        private void comboBoxLR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //boton para seleccionar el licor que se ecogió en el combobox de arriba

        private void buttonSeleccionarLR_Click(object sender, EventArgs e)
        {

        }

        //Aquí ya se debe mostar en el formato de tabla toda la información guardada del licor. Siempre se debe mostrar lo busacado. También se muestra toda la infromacion la presionar le boton de Mostrar Todo.

        private void dataGridViewLR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //aqui se ingresa la medida, es el campo medidad de la tabla

        private void textBoxMedidaLR_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar la medida

        private void buttonguardarMedidaLR_Click(object sender, EventArgs e)
        {

        }

        //aqui se ingresa la cantidad, es el campo cantidad de la tabla

        private void textBoxCantidadLR_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar la cantidad


        private void buttonGuardarCantidadLR_Click(object sender, EventArgs e)
        {

        }

        //boton para agregar el plato

        private void buttonAgregarLR_Click(object sender, EventArgs e)
        {

        }

        //este boton edita la infromacion que se haya ingresado en los text box y se edita del producto previamente escogido.
        //en los textbox, se puede ingresa cierta información, no necesariamente todo y solo cambia lo que se ingrese lo demás que no se haya puesto se queda igual.

        private void buttonEditarLR_Click(object sender, EventArgs e)
        {

        }

        //este boton elimina el licor que habia escogido


        private void buttonEliminarLR_Click(object sender, EventArgs e)
        {

        }

        //Con este boton se muestra toda la infromacion de toda la tabla 


        private void buttonMostrarTodoLR_Click(object sender, EventArgs e)
        {

        }

        //ahora la tercera seccion de consumo de licor del tiki y en la base de datos la tabla se llama ConsumoInternoLicTiki

        //aqui es donde el usuario introduce el nombre del licor que desea buscar

        private void textBoxNombreLT_TextChanged(object sender, EventArgs e)
        {

        }

        //este boton busca el licor o licores en la base de datos

        private void buttonBuscarLT_Click(object sender, EventArgs e)
        {

        }

        //Debe tener todos los licores precargados.
        //Y aqui es donde se debe mostar las opciones que se parezcan al licor buscado o que contengan la palabra que se busca, porque
        //pueden haber varios tipos de arroz y el cliente solo pidio buscar arroz, deben salir todas las opciones que coincida, 
        //y que no tome en cuenta mayusculas o minusculas. El usuario debe escoger una opcion de licor para que se muestre toda la infromación 
        //en el elmento de abajo. 

        private void comboBoxLT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //boton para seleccionar el licor que se ecogió en el combobox de arriba


        private void buttonSeleccionarLT_Click(object sender, EventArgs e)
        {

        }

        //Aquí ya se debe mostar en el formato de tabla toda la información guardada del licor. Siempre se debe mostrar lo busacado. También se muestra toda la infromacion la presionar le boton de Mostrar Todo.

        private void dataGridViewLT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //aqui se ingresa la medida, es el campo medidad de la tabla

        private void textBoxMedidaLT_TextChanged_1(object sender, EventArgs e)
        {

        }

        //boton para guardar la medida

        private void buttonGuardarMedidaLT_Click_1(object sender, EventArgs e)
        {

        }

        //aqui se ingresa la cantidad, es el campo cantidad de la tabla

        private void textBoxCantidadLT_TextChanged_1(object sender, EventArgs e)
        {

        }

        //boton para guardar la cantidad


        private void buttonGuardarCantidadLT_Click_1(object sender, EventArgs e)
        {

        }

        //boton para agregar el plato

        private void buttonAgregarLT_Click_1(object sender, EventArgs e)
        {

        }

        //este boton edita la infromacion que se haya ingresado en los text box y se edita del producto previamente escogido.
        //en los textbox, se puede ingresa cierta información, no necesariamente todo y solo cambia lo que se ingrese lo demás que no se haya puesto se queda igual.

        private void buttonEditarLT_Click_1(object sender, EventArgs e)
        {

        }

        //este boton elimina el licor que habia escogido


        private void buttonEliminarLT_Click_1(object sender, EventArgs e)
        {

        }

        //Con este boton se muestra toda la infromacion de toda la tabla 


        private void buttonMostarTodoLT_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolverMenuInterno_Click(object sender, EventArgs e)
        {
            Interno internoForm = new Interno();
            internoForm.Show();
            this.Hide();
        }
    }
}
