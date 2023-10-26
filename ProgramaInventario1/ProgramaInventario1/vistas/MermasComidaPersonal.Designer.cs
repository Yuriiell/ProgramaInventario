namespace ProgramaInventario1.vistas
{
    partial class MermasComidaPersonal
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
            dataGridViewTablaMermasPlatosDevueltos = new DataGridView();
            buttonEliminarProducto = new Button();
            buttonAgregarProducto = new Button();
            label3 = new Label();
            buttonSeleccionarProducto = new Button();
            comboBoxProductos = new ComboBox();
            buttonBuscarProducto = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonVolverMenuMermas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaMermasPlatosDevueltos).BeginInit();
            SuspendLayout();
            // 
            // buttonMostrarTodo
            // 
            buttonMostrarTodo.Location = new Point(811, 404);
            buttonMostrarTodo.Name = "buttonMostrarTodo";
            buttonMostrarTodo.Size = new Size(75, 43);
            buttonMostrarTodo.TabIndex = 61;
            buttonMostrarTodo.Text = "Mostrar Todo";
            buttonMostrarTodo.UseVisualStyleBackColor = true;
            buttonMostrarTodo.Click += buttonMostrarTodo_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(458, 353);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 23);
            textBoxCantidad.TabIndex = 60;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(439, 239);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(100, 23);
            textBoxNombreProducto.TabIndex = 59;
            textBoxNombreProducto.TextChanged += textBoxNombreProducto_TextChanged;
            // 
            // dataGridViewTablaMermasPlatosDevueltos
            // 
            dataGridViewTablaMermasPlatosDevueltos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTablaMermasPlatosDevueltos.Location = new Point(295, 470);
            dataGridViewTablaMermasPlatosDevueltos.Name = "dataGridViewTablaMermasPlatosDevueltos";
            dataGridViewTablaMermasPlatosDevueltos.RowTemplate.Height = 25;
            dataGridViewTablaMermasPlatosDevueltos.Size = new Size(591, 295);
            dataGridViewTablaMermasPlatosDevueltos.TabIndex = 58;
            dataGridViewTablaMermasPlatosDevueltos.CellContentClick += dataGridViewTablaMermasPlatosDevueltos_CellContentClick;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(768, 284);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(118, 23);
            buttonEliminarProducto.TabIndex = 57;
            buttonEliminarProducto.Text = "Eliminar Producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            buttonEliminarProducto.Click += buttonEliminarProducto_Click;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(768, 239);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(118, 23);
            buttonAgregarProducto.TabIndex = 56;
            buttonAgregarProducto.Text = "Agregar Producto";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 356);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 55;
            label3.Text = "Kilos por mes de producto";
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.Location = new Point(565, 284);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(75, 23);
            buttonSeleccionarProducto.TabIndex = 54;
            buttonSeleccionarProducto.Text = "Seleccionar";
            buttonSeleccionarProducto.UseVisualStyleBackColor = true;
            buttonSeleccionarProducto.Click += buttonSeleccionarProducto_Click;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(295, 284);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(244, 23);
            comboBoxProductos.TabIndex = 53;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // buttonBuscarProducto
            // 
            buttonBuscarProducto.Location = new Point(565, 240);
            buttonBuscarProducto.Name = "buttonBuscarProducto";
            buttonBuscarProducto.Size = new Size(75, 23);
            buttonBuscarProducto.TabIndex = 52;
            buttonBuscarProducto.Text = "Buscar";
            buttonBuscarProducto.UseVisualStyleBackColor = true;
            buttonBuscarProducto.Click += buttonBuscarProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 240);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 51;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(294, 172);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 50;
            label1.Text = "Comida del personal";
            // 
            // buttonVolverMenuMermas
            // 
            buttonVolverMenuMermas.Location = new Point(12, 966);
            buttonVolverMenuMermas.Name = "buttonVolverMenuMermas";
            buttonVolverMenuMermas.Size = new Size(105, 23);
            buttonVolverMenuMermas.TabIndex = 62;
            buttonVolverMenuMermas.Text = "Menú Mermas";
            buttonVolverMenuMermas.UseVisualStyleBackColor = true;
            buttonVolverMenuMermas.Click += buttonVolverMenuMermas_Click;
            // 
            // MermasComidaPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonVolverMenuMermas);
            Controls.Add(buttonMostrarTodo);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(dataGridViewTablaMermasPlatosDevueltos);
            Controls.Add(buttonEliminarProducto);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(label3);
            Controls.Add(buttonSeleccionarProducto);
            Controls.Add(comboBoxProductos);
            Controls.Add(buttonBuscarProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MermasComidaPersonal";
            Text = "MermasComidaPersonal";
            Load += MermasComidaPersonal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaMermasPlatosDevueltos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMostrarTodo;
        private TextBox textBoxCantidad;
        private TextBox textBoxNombreProducto;
        private DataGridView dataGridViewTablaMermasPlatosDevueltos;
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