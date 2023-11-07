<<<<<<< HEAD
﻿using System;
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
    public partial class MermasCortes : Form
    {
<<<<<<<< HEAD:ProgramaInventario1/ProgramaInventario1/vistas/Productos.cs
        //en la base de datos la tabla se llama Producto

        public Productos()
========

        //en la base de datos la tabla se llama MermasCortes

        public MermasCortes()
>>>>>>>> prueba:ProgramaInventario1/ProgramaInventario1/vistas/MermasCortes.cs
=======
﻿using ProgramaInventario1.DAO;

namespace ProgramaInventario1.vistas
{
    public partial class Productos : Form
    {
        public Productos()
>>>>>>> prueba
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        //Para regresar al menu de las mermas

        private void buttonVolverMenuMermas_Click(object sender, EventArgs e)
        {
            Mermas mermasForm = new Mermas();
            mermasForm.Show();
            this.Hide();
        }

        //aqui es donde el usuario introduce el nombre del producto que desea buscar

        private void textBoxNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

<<<<<<<< HEAD:ProgramaInventario1/ProgramaInventario1/vistas/Productos.cs
========

>>>>>>>> prueba:ProgramaInventario1/ProgramaInventario1/vistas/MermasCortes.cs
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

<<<<<<<< HEAD:ProgramaInventario1/ProgramaInventario1/vistas/Productos.cs
        //Aquí ya se debe mostar en el formato de tabla toda la información guardada del producto. Siempre se debe mostrar lo busacado
========

        //Aquí ya se debe mostar en el formato de tabla toda la información guardada del producto. Siempre se debe mostrar lo busacado. También se muestra toda la infromacion la presionar le boton de Mostrar Todo.
>>>>>>>> prueba:ProgramaInventario1/ProgramaInventario1/vistas/MermasCortes.cs

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //aqui se ingersa la cantidad del corte, es el campo Cantidad de la tabla


        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para guardar la cantidad del corte

        private void buttonGuardarCamtidad_Click(object sender, EventArgs e)
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

        //este boton edita la infromacion que se haya ingresado en los text box y se edita del producto previamente escogido.
        //en los textbox, se puede ingresa cierta información, no necesariamente todo y solo cambia lo que se ingrese lo demás que no se haya puesto se queda igual.

        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {

        }
<<<<<<<< HEAD:ProgramaInventario1/ProgramaInventario1/vistas/Productos.cs

        //este es el boton para agregar un producto con la infromación ingresada arriba

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {

        }



        //Con este boton se muestra toda la infromacion de toda la tabla 

        private void buttonBuscarTodo_Click(object sender, EventArgs e)
        {

        }


        //Aqui se muestra todo el cuadro cuando se presiona el boton de mostrar toda la infromación
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

=======
        public void label1_Click(object sender, EventArgs e)
        {

        }
        
        //Aquí el usuario debe ingresar el id del producto que desee hacerle crud
        public void textBoxNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }
        public void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            string idText = textBoxNombreProducto.Text;

            if (!string.IsNullOrWhiteSpace(idText) && int.TryParse(idText, out int id))
            {
                try
                {
                    Producto productoEncontrado = DAOProducto.ObtenerProductoPorId(id);

                    if (productoEncontrado != null)
                    {
                        // Mostrar información del producto encontrado en un DataGridView
                        dataGridView1.DataSource = new List<Producto> { productoEncontrado };
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ID no válido. Debe ser un número.");
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string filtro = comboBox1.Text.ToLower(); // Obtener el filtro (por ejemplo, 'arroz')

            // Realizar la búsqueda en la base de datos y cargar los resultados en un DataGridView
            //List<Producto> productosFiltrados = DAOProducto.ObtenerProductosFiltrados(filtro);
           // dataGridView1.DataSource = productosFiltrados;
        }

        public void buttonSeleccionarProducto_Click(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado en el ComboBox
            //Producto productoSeleccionado = (Producto)comboBox1.SelectedItem;

            // Mostrar información del producto seleccionado en un DataGridView
            //dataGridView1.DataSource = new List<Producto> { productoSeleccionado };
        }

        public void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado en el DataGridView
            Producto productoSeleccionado = (Producto)dataGridView1.SelectedRows[0].DataBoundItem;

            // Eliminar el producto de la base de datos
            DAOProducto.EliminarProducto(productoSeleccionado.Id);

            // Actualizar la vista con los productos restantes
            List<Producto> productosRestantes = DAOProducto.ObtenerProductos();
            dataGridView1.DataSource = productosRestantes;
        }

        public void buttonEditarProducto_Click(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado en el DataGridView
            Producto productoSeleccionado = (Producto)dataGridView1.SelectedRows[0].DataBoundItem;

            // Obtener los valores editados de los TextBox
            string nuevoNombre = textBoxNombreProducto.Text;
            decimal nuevoPrecio = decimal.Parse(textBoPrecioProducto.Text);
            string nuevaUnidadMedida = textBoxUnidadMedida.Text;
            string nuevoTipo = textBoxTipoProducto.Text;

            // Actualizar el producto en la base de datos con la información editada
            //DAOProducto.ActualizarProducto(productoSeleccionado.Id, nuevoNombre, nuevoPrecio, nuevaUnidadMedida, nuevoTipo);

            // Actualizar la vista con los productos
            List<Producto> productosActualizados = DAOProducto.ObtenerProductos();
            dataGridView1.DataSource = productosActualizados;
        }

        public void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los TextBox
            string nombre = textBoxNombreProducto.Text;
            decimal precio = decimal.Parse(textBoPrecioProducto.Text);
            string unidadMedida = textBoxUnidadMedida.Text;
            string tipo = textBoxTipoProducto.Text;

            // Insertar el nuevo producto en la base de datos
            //DAOProducto.InsertarProducto(nombre, precio, unidadMedida, tipo);

            // Actualizar la vista con los productos, incluyendo el nuevo producto
            List<Producto> productosActualizados = DAOProducto.ObtenerProductos();
            dataGridView1.DataSource = productosActualizados;
        }

        public void buttonBuscarTodo_Click(object sender, EventArgs e)
        {
            // Obtener todos los productos de la base de datos
            List<Producto> todosLosProductos = DAOProducto.ObtenerProductos();

            // Mostrar todos los productos en un DataGridView
            dataGridView2.DataSource = todosLosProductos;
>>>>>>> prueba
        }

        private void buttonVolvermenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }
<<<<<<< HEAD
========
>>>>>>>> prueba:ProgramaInventario1/ProgramaInventario1/vistas/MermasCortes.cs
    }
}
=======
    }
}

>>>>>>> prueba
