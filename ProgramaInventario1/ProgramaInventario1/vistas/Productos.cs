using ProgramaInventario1.DAO;

namespace ProgramaInventario1.vistas
{
    public partial class Productos : Form
    {
        //en la base de datos la tabla se llama Producto

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

        //este boton busca el producto o productos en la base de datos

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            // Obtén el valor del TextBox
            string idText = textBoxNombreProducto.Text;

            // Convierte el valor a un tipo adecuado para tu búsqueda en la base de datos,
            // por ejemplo, a int si el ID es un número entero.
            if (int.TryParse(idText, out int id))
            {
                // Llama a tu método para buscar el producto en la base de datos
                Producto productoEncontrado = DAOProducto.ObtenerProductoPorId(id);

                if (productoEncontrado != null)
                {
                    // Haz algo con el producto encontrado, por ejemplo, mostrarlo en un MessageBox
                    MessageBox.Show("Producto encontrado: " + productoEncontrado.Nombre);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }
            }
            else
            {
                MessageBox.Show("ID no válido. Debe ser un número."+ idText);
            }
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

        }

        private void buttonVolvermenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }
    }
}
