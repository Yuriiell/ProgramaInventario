namespace ProgramaInventario1.vistas
{
    partial class Pedidos
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
            label1 = new Label();
            buttonSeleccionarProducto = new Button();
            comboBoxProductos = new ComboBox();
            buttonBuscarProducto = new Button();
            label2 = new Label();
            textBoxNombreProductoBuscar = new TextBox();
            buttonEliminarProducto = new Button();
            buttonAgregarProducto = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxDias = new TextBox();
            textBoxCantidad = new TextBox();
            textBoxInvInicial = new TextBox();
            textBoxInvFinal = new TextBox();
            buttonGuardarDias = new Button();
            buttonGuardarCantidad = new Button();
            buttonGuardarInvInicial = new Button();
            buttonGuardarInvFinal = new Button();
            buttonBuscarTodo = new Button();
            buttonEditarPoducto = new Button();
            buttonVolverMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(191, 479);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1577, 454);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 70);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 1;
            label1.Text = "Pedidos";
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.Location = new Point(524, 236);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(75, 23);
            buttonSeleccionarProducto.TabIndex = 32;
            buttonSeleccionarProducto.Text = "Seleccionar";
            buttonSeleccionarProducto.UseVisualStyleBackColor = true;
            buttonSeleccionarProducto.Click += buttonSeleccionarProducto_Click;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(191, 237);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(304, 23);
            comboBoxProductos.TabIndex = 26;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // buttonBuscarProducto
            // 
            buttonBuscarProducto.Location = new Point(322, 194);
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
            label2.Location = new Point(191, 148);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 29;
            label2.Text = "Ingrese el producto";
            // 
            // textBoxNombreProductoBuscar
            // 
            textBoxNombreProductoBuscar.Location = new Point(191, 195);
            textBoxNombreProductoBuscar.Name = "textBoxNombreProductoBuscar";
            textBoxNombreProductoBuscar.Size = new Size(100, 23);
            textBoxNombreProductoBuscar.TabIndex = 30;
            textBoxNombreProductoBuscar.TextChanged += textBoxNombreProductoBuscar_TextChanged;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(191, 425);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(140, 23);
            buttonEliminarProducto.TabIndex = 31;
            buttonEliminarProducto.Text = "Eliminar producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(960, 425);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(118, 23);
            buttonAgregarProducto.TabIndex = 33;
            buttonAgregarProducto.Text = "Agregar Producto";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(962, 139);
            label3.Name = "label3";
            label3.Size = new Size(374, 15);
            label3.TabIndex = 34;
            label3.Text = "Ingrese los días en el siguiente formato (1-7, 8-14, 15-21, 22-28, 29-31)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(962, 208);
            label4.Name = "label4";
            label4.Size = new Size(172, 15);
            label4.TabIndex = 35;
            label4.Text = "Agregue la cantidad del pedido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(962, 278);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 36;
            label5.Text = "Indique el inventario inicial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(962, 341);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 37;
            label6.Text = "Indique el inventario final";
            // 
            // textBoxDias
            // 
            textBoxDias.Location = new Point(1370, 136);
            textBoxDias.Name = "textBoxDias";
            textBoxDias.Size = new Size(100, 23);
            textBoxDias.TabIndex = 38;
            textBoxDias.TextChanged += textBoxDias_TextChanged;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(1164, 205);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 23);
            textBoxCantidad.TabIndex = 39;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // textBoxInvInicial
            // 
            textBoxInvInicial.Location = new Point(1136, 275);
            textBoxInvInicial.Name = "textBoxInvInicial";
            textBoxInvInicial.Size = new Size(100, 23);
            textBoxInvInicial.TabIndex = 40;
            textBoxInvInicial.TextChanged += textBoxInvInicial_TextChanged;
            // 
            // textBoxInvFinal
            // 
            textBoxInvFinal.Location = new Point(1136, 338);
            textBoxInvFinal.Name = "textBoxInvFinal";
            textBoxInvFinal.Size = new Size(100, 23);
            textBoxInvFinal.TabIndex = 41;
            textBoxInvFinal.TextChanged += textBoxInvFinal_TextChanged;
            // 
            // buttonGuardarDias
            // 
            buttonGuardarDias.Location = new Point(1499, 136);
            buttonGuardarDias.Name = "buttonGuardarDias";
            buttonGuardarDias.Size = new Size(75, 23);
            buttonGuardarDias.TabIndex = 42;
            buttonGuardarDias.Text = "Guardar";
            buttonGuardarDias.UseVisualStyleBackColor = true;
            buttonGuardarDias.Click += buttonGuardarDias_Click;
            // 
            // buttonGuardarCantidad
            // 
            buttonGuardarCantidad.Location = new Point(1291, 205);
            buttonGuardarCantidad.Name = "buttonGuardarCantidad";
            buttonGuardarCantidad.Size = new Size(75, 23);
            buttonGuardarCantidad.TabIndex = 43;
            buttonGuardarCantidad.Text = "Guardar";
            buttonGuardarCantidad.UseVisualStyleBackColor = true;
            buttonGuardarCantidad.Click += buttonGuardarCantidad_Click;
            // 
            // buttonGuardarInvInicial
            // 
            buttonGuardarInvInicial.Location = new Point(1261, 275);
            buttonGuardarInvInicial.Name = "buttonGuardarInvInicial";
            buttonGuardarInvInicial.Size = new Size(75, 23);
            buttonGuardarInvInicial.TabIndex = 44;
            buttonGuardarInvInicial.Text = "Guardar";
            buttonGuardarInvInicial.UseVisualStyleBackColor = true;
            buttonGuardarInvInicial.Click += buttonGuardarInvInicial_Click;
            // 
            // buttonGuardarInvFinal
            // 
            buttonGuardarInvFinal.Location = new Point(1261, 338);
            buttonGuardarInvFinal.Name = "buttonGuardarInvFinal";
            buttonGuardarInvFinal.Size = new Size(75, 23);
            buttonGuardarInvFinal.TabIndex = 45;
            buttonGuardarInvFinal.Text = "Guardar";
            buttonGuardarInvFinal.UseVisualStyleBackColor = true;
            buttonGuardarInvFinal.Click += buttonGuardarInvFinal_Click;
            // 
            // buttonBuscarTodo
            // 
            buttonBuscarTodo.Location = new Point(1693, 412);
            buttonBuscarTodo.Name = "buttonBuscarTodo";
            buttonBuscarTodo.Size = new Size(75, 48);
            buttonBuscarTodo.TabIndex = 46;
            buttonBuscarTodo.Text = "Buscar todo";
            buttonBuscarTodo.UseVisualStyleBackColor = true;
            buttonBuscarTodo.Click += buttonBuscarTodo_Click;
            // 
            // buttonEditarPoducto
            // 
            buttonEditarPoducto.Location = new Point(1120, 425);
            buttonEditarPoducto.Name = "buttonEditarPoducto";
            buttonEditarPoducto.Size = new Size(114, 23);
            buttonEditarPoducto.TabIndex = 48;
            buttonEditarPoducto.Text = "Editar Producto";
            buttonEditarPoducto.UseVisualStyleBackColor = true;
            buttonEditarPoducto.Click += buttonEditarPoducto_Click;
            // 
            // buttonVolverMenuPrincipal
            // 
            buttonVolverMenuPrincipal.Location = new Point(12, 966);
            buttonVolverMenuPrincipal.Name = "buttonVolverMenuPrincipal";
            buttonVolverMenuPrincipal.Size = new Size(109, 23);
            buttonVolverMenuPrincipal.TabIndex = 49;
            buttonVolverMenuPrincipal.Text = "Menú Principal";
            buttonVolverMenuPrincipal.UseVisualStyleBackColor = true;
            buttonVolverMenuPrincipal.Click += buttonVolverMenuPrincipal_Click;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonVolverMenuPrincipal);
            Controls.Add(buttonEditarPoducto);
            Controls.Add(buttonBuscarTodo);
            Controls.Add(buttonGuardarInvFinal);
            Controls.Add(buttonGuardarInvInicial);
            Controls.Add(buttonGuardarCantidad);
            Controls.Add(buttonGuardarDias);
            Controls.Add(textBoxInvFinal);
            Controls.Add(textBoxInvInicial);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxDias);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(buttonSeleccionarProducto);
            Controls.Add(buttonEliminarProducto);
            Controls.Add(textBoxNombreProductoBuscar);
            Controls.Add(label2);
            Controls.Add(buttonBuscarProducto);
            Controls.Add(comboBoxProductos);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Pedidos";
            Text = "Pedidos";
            Load += Pedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button buttonSeleccionarProducto;
        private ComboBox comboBoxProductos;
        private Button buttonBuscarProducto;
        private Label label2;
        private TextBox textBoxNombreProductoBuscar;
        private Button buttonEliminarProducto;
        private Button buttonAgregarProducto;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxDias;
        private TextBox textBoxCantidad;
        private TextBox textBoxInvInicial;
        private TextBox textBoxInvFinal;
        private Button buttonGuardarDias;
        private Button buttonGuardarCantidad;
        private Button buttonGuardarInvInicial;
        private Button buttonGuardarInvFinal;
        private Button buttonBuscarTodo;
        private Button buttonEditarPoducto;
        private Button buttonVolverMenuPrincipal;
    }
}