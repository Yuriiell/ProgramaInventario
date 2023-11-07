using ProgramaInventario1.DAO;

namespace ProgramaInventario1.vistas
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

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
        }

        private void buttonVolvermenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }
    }
}

