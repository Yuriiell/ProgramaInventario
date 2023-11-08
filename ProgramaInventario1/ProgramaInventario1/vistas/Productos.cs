using ProgramaInventario1.DAO;

namespace ProgramaInventario1.vistas
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            CargarProductosComboBox(); // Llenar el ComboBox con los nombres de productos al iniciar la vista
            CargarProductosDataGridView(); // Mostrar todos los productos en el DataGridView al iniciar la vista
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando se hace clic en el Label.
        }


        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            string idText = textBoxNombreProducto.Text;
            if (!string.IsNullOrWhiteSpace(idText) && int.TryParse(idText, out int id))
            {
                try
                {
                    Producto productoEncontrado = DAOProducto.ObtenerProductoPorId(id);

                    if (productoEncontrado != null)
                    {
                        MessageBox.Show("Producto encontrado: " + productoEncontrado.Nombre);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductosDataGridViewFiltrados(comboBox1.Text);
        }

        private void buttonSeleccionarProducto_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Producto productoSeleccionado)
            {
                dataGridView1.DataSource = new BindingSource(new List<Producto> { productoSeleccionado }, null);
            }
        }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Producto productoSeleccionado = (Producto)dataGridView1.SelectedRows[0].DataBoundItem;
                DAOProducto.EliminarProducto(productoSeleccionado.Id);
                CargarProductosDataGridView();
            }
        }

        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Producto productoSeleccionado = (Producto)dataGridView1.SelectedRows[0].DataBoundItem;
                string nuevoNombre = textBoxNombreProducto.Text;
                double nuevoPrecio = (double)decimal.Parse(textBoPrecioProducto.Text);
                string nuevaUnidadMedida = textBoxUnidadMedida.Text;
                string nuevoTipo = textBoxTipoProducto.Text;
                DAOProducto.ActualizarProducto(productoSeleccionado.Id, nuevoNombre, nuevoPrecio, nuevaUnidadMedida, nuevoTipo);
                CargarProductosDataGridView();
            }
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreProducto.Text;
            double precio = (double)decimal.Parse(textBoPrecioProducto.Text);
            string unidadMedida = textBoxUnidadMedida.Text;
            string tipo = textBoxTipoProducto.Text;
            DAOProducto.InsertarProducto(nombre, precio, unidadMedida, tipo);
            CargarProductosDataGridView();
        }

        private void buttonBuscarTodo_Click(object sender, EventArgs e)
        {
            CargarProductosDataGridView();
        }

        private void buttonVolvermenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalForm = new MenuPrincipal();
            menuPrincipalForm.Show();
            this.Hide();
        }

        private void CargarProductosComboBox()
        {
            // Llenar el ComboBox con los nombres de productos desde la base de datos
            var productos = DAOProducto.ObtenerProductos();
            comboBox1.DataSource = productos;
            comboBox1.DisplayMember = "Nombre";
        }

        private void CargarProductosDataGridView()
        {
            // Mostrar todos los productos en el DataGridView
            var productos = DAOProducto.ObtenerProductos();
            dataGridView1.DataSource = new BindingSource(productos, null);
        }

        private void CargarProductosDataGridViewFiltrados(string filtro)
        {
            // Filtrar productos en el DataGridView según el filtro
            var productosFiltrados = DAOProducto.ObtenerProductosFiltrados(filtro);
            dataGridView1.DataSource = new BindingSource(productosFiltrados, null);
        }
        private void textBoxNombreProducto_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando cambia el texto en el TextBox.
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando se hace clic en el DataGridView (celda).
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando se hace clic en el Label (etiqueta).
        }

        private void textBoxNombreProducto_TextChanged_1(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando el contenido del TextBox cambia.
        }

        private void textBoPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando el contenido del TextBox cambia.
        }

        private void textBoxTipoProducto_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando el contenido del TextBox cambia.
        }

        private void textBoxUnidadMedida_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando el contenido del TextBox cambia.
        }
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando el contenido del TextBox cambia.
        }

    }
}

