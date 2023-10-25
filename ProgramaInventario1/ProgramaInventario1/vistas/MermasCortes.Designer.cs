namespace ProgramaInventario1.vistas
{
    partial class MermasCortes
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
            dataGridView1 = new DataGridView();
            buttonEliminarProducto = new Button();
            buttonAgregarProducto = new Button();
            label3 = new Label();
            buttonSeleccionarProducto = new Button();
            comboBoxProductos = new ComboBox();
            buttonBuscarProducto = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonVolverMenuMermas = new Button();
            textBoxNombreProducto = new TextBox();
            textBoxCantidad = new TextBox();
            buttonMostrarTodo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(364, 416);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(591, 295);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(837, 230);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(118, 23);
            buttonEliminarProducto.TabIndex = 19;
            buttonEliminarProducto.Text = "Eliminar Producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            buttonEliminarProducto.Click += buttonEliminarProducto_Click;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(837, 185);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(118, 23);
            buttonAgregarProducto.TabIndex = 18;
            buttonAgregarProducto.Text = "Agregar Producto";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 302);
            label3.Name = "label3";
            label3.Size = new Size(255, 15);
            label3.TabIndex = 17;
            label3.Text = "Cantidad a multiplicar por el total del producto";
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.Location = new Point(634, 230);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(75, 23);
            buttonSeleccionarProducto.TabIndex = 16;
            buttonSeleccionarProducto.Text = "Seleccionar";
            buttonSeleccionarProducto.UseVisualStyleBackColor = true;
            buttonSeleccionarProducto.Click += buttonSeleccionarProducto_Click;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(364, 230);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(244, 23);
            comboBoxProductos.TabIndex = 15;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // buttonBuscarProducto
            // 
            buttonBuscarProducto.Location = new Point(634, 186);
            buttonBuscarProducto.Name = "buttonBuscarProducto";
            buttonBuscarProducto.Size = new Size(75, 23);
            buttonBuscarProducto.TabIndex = 14;
            buttonBuscarProducto.Text = "Buscar";
            buttonBuscarProducto.UseVisualStyleBackColor = true;
            buttonBuscarProducto.Click += buttonBuscarProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 186);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 12;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(363, 118);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 11;
            label1.Text = "Mermas de recortes";
            // 
            // buttonVolverMenuMermas
            // 
            buttonVolverMenuMermas.Location = new Point(12, 966);
            buttonVolverMenuMermas.Name = "buttonVolverMenuMermas";
            buttonVolverMenuMermas.Size = new Size(105, 23);
            buttonVolverMenuMermas.TabIndex = 22;
            buttonVolverMenuMermas.Text = "Menú Mermas";
            buttonVolverMenuMermas.UseVisualStyleBackColor = true;
            buttonVolverMenuMermas.Click += buttonVolverMenuMermas_Click;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(508, 185);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(100, 23);
            textBoxNombreProducto.TabIndex = 23;
            textBoxNombreProducto.TextChanged += textBoxNombreProducto_TextChanged;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(634, 299);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 23);
            textBoxCantidad.TabIndex = 24;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // buttonMostrarTodo
            // 
            buttonMostrarTodo.Location = new Point(880, 350);
            buttonMostrarTodo.Name = "buttonMostrarTodo";
            buttonMostrarTodo.Size = new Size(75, 43);
            buttonMostrarTodo.TabIndex = 25;
            buttonMostrarTodo.Text = "Mostrar Todo";
            buttonMostrarTodo.UseVisualStyleBackColor = true;
            buttonMostrarTodo.Click += buttonMostrarTodo_Click;
            // 
            // MermasCortes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonMostrarTodo);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(buttonVolverMenuMermas);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEliminarProducto);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(label3);
            Controls.Add(buttonSeleccionarProducto);
            Controls.Add(comboBoxProductos);
            Controls.Add(buttonBuscarProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MermasCortes";
            Text = "MermasCortes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonEliminarProducto;
        private Button buttonAgregarProducto;
        private Label label3;
        private Button buttonSeleccionarProducto;
        private ComboBox comboBoxProductos;
        private Button buttonBuscarProducto;
        private Label label2;
        private Label label1;
        private Button buttonVolverMenuMermas;
        private TextBox textBoxNombreProducto;
        private TextBox textBoxCantidad;
        private Button buttonMostrarTodo;
    }
}