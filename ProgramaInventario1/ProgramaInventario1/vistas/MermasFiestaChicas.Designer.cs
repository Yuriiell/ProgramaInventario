namespace ProgramaInventario1.vistas
{
    partial class MermasFiestaChicas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonMostrarTodo = new Button();
            textBoxCantidad = new TextBox();
            textBoxNombreProducto = new TextBox();
            dataGridViewTablaMermasFiestaChicas = new DataGridView();
            buttonEliminarProducto = new Button();
            buttonAgregarProducto = new Button();
            buttonSeleccionarProducto = new Button();
            comboBoxProductos = new ComboBox();
            buttonBuscarProducto = new Button();
            label1 = new Label();
            buttonVolverMenuMermas = new Button();
            label2 = new Label();
            label3 = new Label();
            buttonGuardarCantidad = new Button();
            buttonEditarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaMermasFiestaChicas).BeginInit();
            SuspendLayout();
            // 
            // buttonMostrarTodo
            // 
            buttonMostrarTodo.Location = new Point(751, 415);
            buttonMostrarTodo.Name = "buttonMostrarTodo";
            buttonMostrarTodo.Size = new Size(75, 43);
            buttonMostrarTodo.TabIndex = 73;
            buttonMostrarTodo.Text = "Mostrar Todo";
            buttonMostrarTodo.UseVisualStyleBackColor = true;
            buttonMostrarTodo.Click += buttonMostrarTodo_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(389, 364);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 23);
            textBoxCantidad.TabIndex = 72;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(379, 250);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(100, 23);
            textBoxNombreProducto.TabIndex = 71;
            textBoxNombreProducto.TextChanged += textBoxNombreProducto_TextChanged;
            // 
            // dataGridViewTablaMermasFiestaChicas
            // 
            dataGridViewTablaMermasFiestaChicas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTablaMermasFiestaChicas.Location = new Point(235, 481);
            dataGridViewTablaMermasFiestaChicas.Name = "dataGridViewTablaMermasFiestaChicas";
            dataGridViewTablaMermasFiestaChicas.RowTemplate.Height = 25;
            dataGridViewTablaMermasFiestaChicas.Size = new Size(591, 295);
            dataGridViewTablaMermasFiestaChicas.TabIndex = 70;
            dataGridViewTablaMermasFiestaChicas.CellContentClick += dataGridViewTablaMermasFiestaChicas_CellContentClick;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(708, 372);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(118, 23);
            buttonEliminarProducto.TabIndex = 69;
            buttonEliminarProducto.Text = "Eliminar Producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            buttonEliminarProducto.Click += buttonEliminarProducto_Click;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(708, 250);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(118, 23);
            buttonAgregarProducto.TabIndex = 68;
            buttonAgregarProducto.Text = "Agregar Producto";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.Location = new Point(505, 295);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(75, 23);
            buttonSeleccionarProducto.TabIndex = 66;
            buttonSeleccionarProducto.Text = "Seleccionar";
            buttonSeleccionarProducto.UseVisualStyleBackColor = true;
            buttonSeleccionarProducto.Click += buttonSeleccionarProducto_Click;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(235, 295);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(244, 23);
            comboBoxProductos.TabIndex = 65;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // buttonBuscarProducto
            // 
            buttonBuscarProducto.Location = new Point(505, 251);
            buttonBuscarProducto.Name = "buttonBuscarProducto";
            buttonBuscarProducto.Size = new Size(75, 23);
            buttonBuscarProducto.TabIndex = 64;
            buttonBuscarProducto.Text = "Buscar";
            buttonBuscarProducto.UseVisualStyleBackColor = true;
            buttonBuscarProducto.Click += buttonBuscarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 183);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 62;
            label1.Text = "Fiesta Chicas";
            // 
            // buttonVolverMenuMermas
            // 
            buttonVolverMenuMermas.Location = new Point(12, 966);
            buttonVolverMenuMermas.Name = "buttonVolverMenuMermas";
            buttonVolverMenuMermas.Size = new Size(105, 23);
            buttonVolverMenuMermas.TabIndex = 74;
            buttonVolverMenuMermas.Text = "Menú Mermas";
            buttonVolverMenuMermas.UseVisualStyleBackColor = true;
            buttonVolverMenuMermas.Click += buttonVolverMenuMermas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 251);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 63;
            label2.Text = "Nombre del Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 372);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 75;
            label3.Text = "Cantidad de productos";
            // 
            // buttonGuardarCantidad
            // 
            buttonGuardarCantidad.Location = new Point(505, 364);
            buttonGuardarCantidad.Name = "buttonGuardarCantidad";
            buttonGuardarCantidad.Size = new Size(75, 23);
            buttonGuardarCantidad.TabIndex = 76;
            buttonGuardarCantidad.Text = "Guardar";
            buttonGuardarCantidad.UseVisualStyleBackColor = true;
            buttonGuardarCantidad.Click += buttonGuardarCantidad_Click;
            // 
            // buttonEditarProducto
            // 
            buttonEditarProducto.Location = new Point(708, 311);
            buttonEditarProducto.Name = "buttonEditarProducto";
            buttonEditarProducto.Size = new Size(118, 23);
            buttonEditarProducto.TabIndex = 77;
            buttonEditarProducto.Text = "Editar Producto";
            buttonEditarProducto.UseVisualStyleBackColor = true;
            buttonEditarProducto.Click += buttonEditarProducto_Click;
            // 
            // MermasFiestaChicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonEditarProducto);
            Controls.Add(buttonGuardarCantidad);
            Controls.Add(label3);
            Controls.Add(buttonVolverMenuMermas);
            Controls.Add(buttonMostrarTodo);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(dataGridViewTablaMermasFiestaChicas);
            Controls.Add(buttonEliminarProducto);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(buttonSeleccionarProducto);
            Controls.Add(comboBoxProductos);
            Controls.Add(buttonBuscarProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MermasFiestaChicas";
            Text = "MermasFiestaChicas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaMermasFiestaChicas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMostrarTodo;
        private TextBox textBoxCantidad;
        private TextBox textBoxNombreProducto;
        private DataGridView dataGridViewTablaMermasFiestaChicas;
        private Button buttonEliminarProducto;
        private Button buttonAgregarProducto;
        private Button buttonSeleccionarProducto;
        private ComboBox comboBoxProductos;
        private Button buttonBuscarProducto;
        private Label label1;
        private Button buttonVolverMenuMermas;
        private Label label2;
        private Label label3;
        private Button buttonGuardarCantidad;
        private Button buttonEditarProducto;
    }
}