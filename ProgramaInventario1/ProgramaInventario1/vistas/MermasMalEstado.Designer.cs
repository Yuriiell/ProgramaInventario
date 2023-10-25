namespace ProgramaInventario1.vistas
{
    partial class MermasMalEstado
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
            dataGridViewTablaMermasMalEstado = new DataGridView();
            buttonEliminarProducto = new Button();
            buttonAgregarProducto = new Button();
            label3 = new Label();
            buttonSeleccionarProducto = new Button();
            comboBoxProductos = new ComboBox();
            buttonBuscarProducto = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonVolverMenuMermas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaMermasMalEstado).BeginInit();
            SuspendLayout();
            // 
            // buttonMostrarTodo
            // 
            buttonMostrarTodo.Location = new Point(947, 474);
            buttonMostrarTodo.Name = "buttonMostrarTodo";
            buttonMostrarTodo.Size = new Size(75, 43);
            buttonMostrarTodo.TabIndex = 37;
            buttonMostrarTodo.Text = "Mostrar Todo";
            buttonMostrarTodo.UseVisualStyleBackColor = true;
            buttonMostrarTodo.Click += buttonMostrarTodo_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(701, 423);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 23);
            textBoxCantidad.TabIndex = 36;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(575, 309);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(100, 23);
            textBoxNombreProducto.TabIndex = 35;
            textBoxNombreProducto.TextChanged += textBoxNombreProducto_TextChanged;
            // 
            // dataGridViewTablaMermasMalEstado
            // 
            dataGridViewTablaMermasMalEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTablaMermasMalEstado.Location = new Point(431, 540);
            dataGridViewTablaMermasMalEstado.Name = "dataGridViewTablaMermasMalEstado";
            dataGridViewTablaMermasMalEstado.RowTemplate.Height = 25;
            dataGridViewTablaMermasMalEstado.Size = new Size(591, 295);
            dataGridViewTablaMermasMalEstado.TabIndex = 34;
            dataGridViewTablaMermasMalEstado.CellContentClick += dataGridViewTablaMermasMalEstado_CellContentClick;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(904, 354);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(118, 23);
            buttonEliminarProducto.TabIndex = 33;
            buttonEliminarProducto.Text = "Eliminar Producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            buttonEliminarProducto.Click += buttonEliminarProducto_Click;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(904, 309);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(118, 23);
            buttonAgregarProducto.TabIndex = 32;
            buttonAgregarProducto.Text = "Agregar Producto";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 426);
            label3.Name = "label3";
            label3.Size = new Size(255, 15);
            label3.TabIndex = 31;
            label3.Text = "Cantidad a multiplicar por el total del producto";
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.Location = new Point(701, 354);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(75, 23);
            buttonSeleccionarProducto.TabIndex = 30;
            buttonSeleccionarProducto.Text = "Seleccionar";
            buttonSeleccionarProducto.UseVisualStyleBackColor = true;
            buttonSeleccionarProducto.Click += buttonSeleccionarProducto_Click;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(431, 354);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(244, 23);
            comboBoxProductos.TabIndex = 29;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // buttonBuscarProducto
            // 
            buttonBuscarProducto.Location = new Point(701, 310);
            buttonBuscarProducto.Name = "buttonBuscarProducto";
            buttonBuscarProducto.Size = new Size(75, 23);
            buttonBuscarProducto.TabIndex = 28;
            buttonBuscarProducto.Text = "Buscar";
            buttonBuscarProducto.UseVisualStyleBackColor = true;
            buttonBuscarProducto.Click += buttonBuscarProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 310);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 27;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(430, 242);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 26;
            label1.Text = "Mermas en mal estado";
            // 
            // buttonVolverMenuMermas
            // 
            buttonVolverMenuMermas.Location = new Point(12, 966);
            buttonVolverMenuMermas.Name = "buttonVolverMenuMermas";
            buttonVolverMenuMermas.Size = new Size(105, 23);
            buttonVolverMenuMermas.TabIndex = 38;
            buttonVolverMenuMermas.Text = "Menú Mermas";
            buttonVolverMenuMermas.UseVisualStyleBackColor = true;
            buttonVolverMenuMermas.Click += buttonVolverMenuMermas_Click;
            // 
            // MermasMalEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonVolverMenuMermas);
            Controls.Add(buttonMostrarTodo);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(dataGridViewTablaMermasMalEstado);
            Controls.Add(buttonEliminarProducto);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(label3);
            Controls.Add(buttonSeleccionarProducto);
            Controls.Add(comboBoxProductos);
            Controls.Add(buttonBuscarProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MermasMalEstado";
            Text = "MermasMalEstado";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaMermasMalEstado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMostrarTodo;
        private TextBox textBoxCantidad;
        private TextBox textBoxNombreProducto;
        private DataGridView dataGridViewTablaMermasMalEstado;
        private Button buttonEliminarProducto;
        private Button buttonAgregarProducto;
        private Label label3;
        private Button buttonSeleccionarProducto;
        private ComboBox comboBoxProductos;
        private Button buttonBuscarProducto;
        private Label label2;
        private Label label1;
        private Button buttonVolverMenuMermas;
    }
}