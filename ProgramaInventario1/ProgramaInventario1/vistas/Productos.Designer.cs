namespace ProgramaInventario1.vistas
{
    partial class Productos
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
            comboBox = new ComboBox();
            buttonBuscarProducto = new Button();
            label1 = new Label();
            textBoxNombreProductoBuscar = new TextBox();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            buttonEditarProducto = new Button();
            buttonEliminarProducto = new Button();
            buttonAgregarProducto = new Button();
            textBoxNombreProducto = new TextBox();
            textBoPrecioProducto = new TextBox();
            textBoxUnidadMedida = new TextBox();
            textBoxTipoProducto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonBuscarTodo = new Button();
            buttonSeleccionarProducto = new Button();
            dataGridView1 = new DataGridView();
            buttonVolvermenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(45, 148);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(304, 23);
            comboBox.TabIndex = 0;
            comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonBuscarProducto
            // 
            buttonBuscarProducto.Location = new Point(176, 105);
            buttonBuscarProducto.Name = "buttonBuscarProducto";
            buttonBuscarProducto.Size = new Size(75, 23);
            buttonBuscarProducto.TabIndex = 4;
            buttonBuscarProducto.Text = "Buscar";
            buttonBuscarProducto.UseVisualStyleBackColor = true;
            buttonBuscarProducto.Click += buttonBuscarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 59);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingrese el producto";
            label1.Click += label1_Click;
            // 
            // textBoxNombreProductoBuscar
            // 
            textBoxNombreProductoBuscar.Location = new Point(45, 106);
            textBoxNombreProductoBuscar.Name = "textBoxNombreProductoBuscar";
            textBoxNombreProductoBuscar.Size = new Size(100, 23);
            textBoxNombreProductoBuscar.TabIndex = 7;
            textBoxNombreProductoBuscar.TextChanged += textBoxNombreProducto_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1050, 96);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(845, 872);
            dataGridView2.TabIndex = 10;
            //dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 463);
            label2.Name = "label2";
            label2.Size = new Size(522, 15);
            label2.TabIndex = 11;
            label2.Text = "Si desea editar el producto, ingrese la información que desea cambiar y presione el botón \"Editar\".";
            //label2.Click += label2_Click;
            // 
            // buttonEditarProducto
            // 
            buttonEditarProducto.Location = new Point(315, 583);
            buttonEditarProducto.Name = "buttonEditarProducto";
            buttonEditarProducto.Size = new Size(75, 23);
            buttonEditarProducto.TabIndex = 12;
            buttonEditarProducto.Text = "Editar ";
            buttonEditarProducto.UseVisualStyleBackColor = true;
            buttonEditarProducto.Click += buttonEditarProducto_Click;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(813, 147);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(140, 23);
            buttonEliminarProducto.TabIndex = 13;
            buttonEliminarProducto.Text = "Eliminar producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            buttonEliminarProducto.Click += buttonEliminarProducto_Click;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(315, 637);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(75, 23);
            buttonAgregarProducto.TabIndex = 14;
            buttonAgregarProducto.Text = "Agregar";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(125, 551);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(100, 23);
            textBoxNombreProducto.TabIndex = 15;
            //textBoxNombreProducto.TextChanged += textBoxNombreProducto_TextChanged_1;
            // 
            // textBoPrecioProducto
            // 
            textBoPrecioProducto.Location = new Point(104, 591);
            textBoPrecioProducto.Name = "textBoPrecioProducto";
            textBoPrecioProducto.Size = new Size(100, 23);
            textBoPrecioProducto.TabIndex = 16;
            //textBoPrecioProducto.TextChanged += textBoPrecioProducto_TextChanged;
            // 
            // textBoxUnidadMedida
            // 
            textBoxUnidadMedida.Location = new Point(166, 633);
            textBoxUnidadMedida.Name = "textBoxUnidadMedida";
            textBoxUnidadMedida.Size = new Size(100, 23);
            textBoxUnidadMedida.TabIndex = 17;
            //textBoxUnidadMedida.TextChanged += textBoxUnidadMedida_TextChanged;
            // 
            // textBoxTipoProducto
            // 
            textBoxTipoProducto.Location = new Point(94, 687);
            textBoxTipoProducto.Name = "textBoxTipoProducto";
            textBoxTipoProducto.Size = new Size(100, 23);
            textBoxTipoProducto.TabIndex = 18;
            //textBoxTipoProducto.TextChanged += textBoxTipoProducto_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 554);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 19;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 591);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 20;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 641);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 21;
            label5.Text = "Unidad de Medida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 690);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 22;
            label6.Text = "Tipo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 498);
            label7.Name = "label7";
            label7.Size = new Size(588, 15);
            label7.TabIndex = 23;
            label7.Text = "Si desea agregar un nuevo producto, ingrese toda la información y seguidamente presione el botón \"Agregar\".";
            // 
            // buttonBuscarTodo
            // 
            buttonBuscarTodo.Location = new Point(1050, 51);
            buttonBuscarTodo.Name = "buttonBuscarTodo";
            buttonBuscarTodo.Size = new Size(113, 23);
            buttonBuscarTodo.TabIndex = 24;
            buttonBuscarTodo.Text = "Buscar todo";
            buttonBuscarTodo.UseVisualStyleBackColor = true;
            buttonBuscarTodo.Click += buttonBuscarTodo_Click;
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.Location = new Point(378, 147);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(75, 23);
            buttonSeleccionarProducto.TabIndex = 25;
            buttonSeleccionarProducto.Text = "Seleccionar";
            buttonSeleccionarProducto.UseVisualStyleBackColor = true;
            buttonSeleccionarProducto.Click += buttonSeleccionarProducto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(919, 215);
            dataGridView1.TabIndex = 1;
<<<<<<< HEAD
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
=======
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
>>>>>>> prueba
            // 
            // buttonVolvermenuPrincipal
            // 
            buttonVolvermenuPrincipal.Location = new Point(12, 966);
            buttonVolvermenuPrincipal.Name = "buttonVolvermenuPrincipal";
            buttonVolvermenuPrincipal.Size = new Size(125, 23);
            buttonVolvermenuPrincipal.TabIndex = 26;
            buttonVolvermenuPrincipal.Text = "Menu Principal";
            buttonVolvermenuPrincipal.UseVisualStyleBackColor = true;
            buttonVolvermenuPrincipal.Click += buttonVolvermenuPrincipal_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonVolvermenuPrincipal);
            Controls.Add(buttonSeleccionarProducto);
            Controls.Add(buttonBuscarTodo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxTipoProducto);
            Controls.Add(textBoxUnidadMedida);
            Controls.Add(textBoPrecioProducto);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(buttonEliminarProducto);
            Controls.Add(buttonEditarProducto);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(textBoxNombreProductoBuscar);
            Controls.Add(label1);
            Controls.Add(buttonBuscarProducto);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox;
        private Button buttonBuscarProducto;
        private Label label1;
        private TextBox textBoxNombreProductoBuscar;
        private DataGridView dataGridView2;
        private Label label2;
        private Button buttonEditarProducto;
        private Button buttonEliminarProducto;
        private Button buttonAgregarProducto;
        private TextBox textBoxNombreProducto;
        private TextBox textBoPrecioProducto;
        private TextBox textBoxUnidadMedida;
        private TextBox textBoxTipoProducto;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonBuscarTodo;
        private Button buttonSeleccionarProducto;
        private DataGridView dataGridView1;
        private Button buttonVolvermenuPrincipal;
    }
}