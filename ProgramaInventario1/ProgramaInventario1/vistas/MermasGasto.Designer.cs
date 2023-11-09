namespace ProgramaInventario1.vistas
{
    partial class MermasGasto
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
            label1 = new Label();
            label2 = new Label();
            buttonBuscarProducto = new Button();
            comboBoxProductos = new ComboBox();
            buttonSeleccionarProducto = new Button();
            label3 = new Label();
            buttonAgregarProducto = new Button();
            buttonEliminarProducto = new Button();
            buttonMostrarTodo = new Button();
            dataGridViewTablaGasto = new DataGridView();
            buttonVolverMenuMermas = new Button();
            textBoxProducto = new TextBox();
            textBoxCantidad = new TextBox();
            buttonGuardarCantidad = new Button();
            buttonEditarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaGasto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 33);
            label1.Name = "label1";
            label1.Size = new Size(79, 35);
            label1.TabIndex = 0;
            label1.Text = "Gasto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 124);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Producto";
            // 
            // buttonBuscarProducto
            // 
            buttonBuscarProducto.Location = new Point(427, 116);
            buttonBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonBuscarProducto.Name = "buttonBuscarProducto";
            buttonBuscarProducto.Size = new Size(86, 31);
            buttonBuscarProducto.TabIndex = 3;
            buttonBuscarProducto.Text = "Buscar";
            buttonBuscarProducto.UseVisualStyleBackColor = true;
            buttonBuscarProducto.Click += buttonBuscarProducto_Click;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(123, 183);
            comboBoxProductos.Margin = new Padding(3, 4, 3, 4);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(278, 28);
            comboBoxProductos.TabIndex = 4;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.Location = new Point(427, 183);
            buttonSeleccionarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(86, 31);
            buttonSeleccionarProducto.TabIndex = 5;
            buttonSeleccionarProducto.Text = "Seleccionar";
            buttonSeleccionarProducto.UseVisualStyleBackColor = true;
            buttonSeleccionarProducto.Click += buttonSeleccionarProducto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 278);
            label3.Name = "label3";
            label3.Size = new Size(324, 20);
            label3.TabIndex = 6;
            label3.Text = "Cantidad a multiplicar por el total del producto";
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(617, 113);
            buttonAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(135, 31);
            buttonAgregarProducto.TabIndex = 7;
            buttonAgregarProducto.Text = "Agregar Producto";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(617, 267);
            buttonEliminarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(135, 31);
            buttonEliminarProducto.TabIndex = 8;
            buttonEliminarProducto.Text = "Eliminar Producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            buttonEliminarProducto.Click += buttonEliminarProducto_Click;
            // 
            // buttonMostrarTodo
            // 
            buttonMostrarTodo.Location = new Point(666, 362);
            buttonMostrarTodo.Margin = new Padding(3, 4, 3, 4);
            buttonMostrarTodo.Name = "buttonMostrarTodo";
            buttonMostrarTodo.Size = new Size(86, 61);
            buttonMostrarTodo.TabIndex = 9;
            buttonMostrarTodo.Text = "Mostrar Todo";
            buttonMostrarTodo.UseVisualStyleBackColor = true;
            buttonMostrarTodo.Click += buttonMostrarTodo_Click;
            // 
            // dataGridViewTablaGasto
            // 
            dataGridViewTablaGasto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTablaGasto.Location = new Point(77, 431);
            dataGridViewTablaGasto.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTablaGasto.Name = "dataGridViewTablaGasto";
            dataGridViewTablaGasto.RowHeadersWidth = 51;
            dataGridViewTablaGasto.RowTemplate.Height = 25;
            dataGridViewTablaGasto.Size = new Size(675, 393);
            dataGridViewTablaGasto.TabIndex = 10;
            dataGridViewTablaGasto.CellContentClick += dataGridViewTablaGasto_CellContentClick;
            // 
            // buttonVolverMenuMermas
            // 
            buttonVolverMenuMermas.Location = new Point(76, 848);
            buttonVolverMenuMermas.Margin = new Padding(3, 4, 3, 4);
            buttonVolverMenuMermas.Name = "buttonVolverMenuMermas";
            buttonVolverMenuMermas.Size = new Size(121, 31);
            buttonVolverMenuMermas.TabIndex = 11;
            buttonVolverMenuMermas.Text = "Menú Mermas";
            buttonVolverMenuMermas.UseVisualStyleBackColor = true;
            buttonVolverMenuMermas.Click += buttonVolverMenuMermas_Click;
            // 
            // textBoxProducto
            // 
            textBoxProducto.Location = new Point(242, 120);
            textBoxProducto.Margin = new Padding(3, 4, 3, 4);
            textBoxProducto.Name = "textBoxProducto";
            textBoxProducto.Size = new Size(159, 27);
            textBoxProducto.TabIndex = 12;
            textBoxProducto.TextChanged += textBoxProducto_TextChanged;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(386, 275);
            textBoxCantidad.Margin = new Padding(3, 4, 3, 4);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(114, 27);
            textBoxCantidad.TabIndex = 13;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // buttonGuardarCantidad
            // 
            buttonGuardarCantidad.Location = new Point(414, 326);
            buttonGuardarCantidad.Margin = new Padding(3, 4, 3, 4);
            buttonGuardarCantidad.Name = "buttonGuardarCantidad";
            buttonGuardarCantidad.Size = new Size(86, 31);
            buttonGuardarCantidad.TabIndex = 14;
            buttonGuardarCantidad.Text = "Guardar";
            buttonGuardarCantidad.UseVisualStyleBackColor = true;
            buttonGuardarCantidad.Click += buttonGuardarCantidad_Click;
            // 
            // buttonEditarProducto
            // 
            buttonEditarProducto.Location = new Point(617, 181);
            buttonEditarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonEditarProducto.Name = "buttonEditarProducto";
            buttonEditarProducto.Size = new Size(135, 31);
            buttonEditarProducto.TabIndex = 32;
            buttonEditarProducto.Text = "Editar Producto";
            buttonEditarProducto.UseVisualStyleBackColor = true;
            buttonEditarProducto.Click += buttonEditarProducto_Click;
            // 
            // MermasGasto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 956);
            Controls.Add(buttonEditarProducto);
            Controls.Add(buttonGuardarCantidad);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxProducto);
            Controls.Add(buttonVolverMenuMermas);
            Controls.Add(dataGridViewTablaGasto);
            Controls.Add(buttonMostrarTodo);
            Controls.Add(buttonEliminarProducto);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(label3);
            Controls.Add(buttonSeleccionarProducto);
            Controls.Add(comboBoxProductos);
            Controls.Add(buttonBuscarProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MermasGasto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MermasGasto";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaGasto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonBuscarProducto;
        private ComboBox comboBoxProductos;
        private Button buttonSeleccionarProducto;
        private Label label3;
        private Button buttonAgregarProducto;
        private Button buttonEliminarProducto;
        private Button buttonMostrarTodo;
        private DataGridView dataGridViewTablaGasto;
        private Button buttonVolverMenuMermas;
        private TextBox textBoxProducto;
        private TextBox textBoxCantidad;
        private Button buttonGuardarCantidad;
        private Button buttonEditarProducto;
    }
}