using ProgramaInventario1.DAO;
using ProgramaInventario1.logicaDeNegocios;

namespace ProgramaInventario1.vistas
{
    public partial class MermasGasto : Form
    {
        public MermasGasto()
        {
            InitializeComponent();
            //CargarProductosComboBox(); // Llenar el ComboBox con los nombres de productos al iniciar la vista
            ActualizarTablaGastos(); // Mostrar todos los gastos en el DataGridView al iniciar la vista
        }

        // Variables para almacenar el producto seleccionado
        private Producto productoSeleccionado;

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            // Lógica para buscar el producto en la base de datos
            string nombreProducto = textBoxProducto.Text;
            List<Producto> productosEncontrados = DAOProducto.ObtenerProductosFiltrados(nombreProducto);

            // Llenar el ComboBox con los productos encontrados
            comboBoxProductos.DataSource = productosEncontrados;
            comboBoxProductos.DisplayMember = "Nombre";
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando se selecciona un producto en el ComboBox
            productoSeleccionado = comboBoxProductos.SelectedItem as Producto;

            // Muestra la información del producto en los TextBox
            textBoxCantidad.Text = string.Empty; // Limpia el campo Cantidad
        }

        private void buttonSeleccionarProducto_Click(object sender, EventArgs e)
        {
            // Muestra la información del producto seleccionado
            if (productoSeleccionado != null)
            {
                // Llena los TextBox con la información del producto
                textBoxCantidad.Text = string.Empty; // Limpia el campo Cantidad
            }
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            // Lógica para agregar el producto con la cantidad
            if (productoSeleccionado != null && double.TryParse(textBoxCantidad.Text, out double cantidad))
            {
                // Llama a un método en DAOGasto para agregar el producto con la cantidad
                DAOGasto.InsertarGasto(productoSeleccionado.Id.ToString(), cantidad);

                // Actualiza la tabla de gastos
                ActualizarTablaGastos();

                // Limpia los campos después de agregar el producto
                textBoxProducto.Text = string.Empty;
                comboBoxProductos.DataSource = null;
                textBoxCantidad.Text = string.Empty;
                productoSeleccionado = null;
            }
        }

        private void ActualizarTablaGastos()
        {
            // Lógica para actualizar la tabla de gastos
            List<Gasto> gastos = DAOGasto.ObtenerGastos();

            // Llena la tabla con la información de los gastos
            dataGridViewTablaGasto.DataSource = gastos;
        }

        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {
            // Lógica para editar el gasto asociado al producto seleccionado
            //if (productoSeleccionado != null && double.TryParse(textBoxCantidad.Text, out double cantidad))
            {
                // Supongamos que el ID del gasto está almacenado en la tabla de productos como "IdGasto"
              //  if (productoSeleccionado.idGasto.HasValue)
               // {
                  //  int idGasto = productoSeleccionado.idGasto.Value;

                    // Llama a un método en DAOGasto para actualizar el gasto
                   // DAOGasto.ActualizarGasto(idGasto, productoSeleccionado.Id, cantidad);

                    // Actualiza la tabla de gastos
                   // ActualizarTablaGastos();

                    // Limpia los campos después de editar el producto
                  //  textBoxProducto.Text = string.Empty;
                  //  comboBoxProductos.DataSource = null;
                  //  textBoxCantidad.Text = string.Empty;
                  //  productoSeleccionado = null;
               // }
                //else
                //{
                  //  MessageBox.Show("El producto seleccionado no tiene un ID de gasto asociado.");
               // }
            }
        }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar el producto seleccionado
            if (productoSeleccionado != null)
            {
                // Llama a un método en DAOGasto para eliminar el producto seleccionado
                DAOGasto.EliminarGasto(productoSeleccionado.Id);

                // Actualiza la tabla de gastos
                ActualizarTablaGastos();

                // Limpia los campos después de eliminar el producto
                textBoxProducto.Text = string.Empty;
                comboBoxProductos.DataSource = null;
                textBoxCantidad.Text = string.Empty;
                productoSeleccionado = null;
            }
        }

        private void buttonMostrarTodo_Click(object sender, EventArgs e)
        {
            // Muestra toda la información de la tabla de gastos
            ActualizarTablaGastos();
        }

        private void textBoxProducto_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewTablaGasto_CellContentClick(object sender, EventArgs e)
        {
        }
        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void buttonGuardarCantidad_Click(object sender, EventArgs e)
        {
        }
        private void buttonVolverMenuMermas_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario del menú anterior
            Mermas mermasForm = new Mermas();

            // Mostrar el formulario del menú anterior
            mermasForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void dataGridViewTablaGasto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
