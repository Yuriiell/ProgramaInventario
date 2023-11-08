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
            comboBox1 = new ComboBox();
            buttonBuscarProducto = new Button();
            label1 = new Label();
            textBoxNombreProductoBuscar = new TextBox();
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
            buttonSeleccionarProducto = new Button();
            dataGridView1 = new DataGridView();
            buttonVolvermenuPrincipal = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(51, 179);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(347, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonBuscarProducto
            // 
            buttonBuscarProducto.Location = new Point(190, 127);
            buttonBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonBuscarProducto.Name = "buttonBuscarProducto";
            buttonBuscarProducto.Size = new Size(86, 31);
            buttonBuscarProducto.TabIndex = 4;
            buttonBuscarProducto.Text = "Buscar";
            buttonBuscarProducto.UseVisualStyleBackColor = true;
            buttonBuscarProducto.Click += buttonBuscarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 79);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 6;
            label1.Text = "Ingrese el producto";
            label1.Click += label1_Click;
            // 
            // textBoxNombreProductoBuscar
            // 
            textBoxNombreProductoBuscar.Location = new Point(51, 127);
            textBoxNombreProductoBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxNombreProductoBuscar.Name = "textBoxNombreProductoBuscar";
            textBoxNombreProductoBuscar.Size = new Size(114, 27);
            textBoxNombreProductoBuscar.TabIndex = 7;
            textBoxNombreProductoBuscar.TextChanged += textBoxNombreProducto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 575);
            label2.Name = "label2";
            label2.Size = new Size(663, 20);
            label2.TabIndex = 11;
            label2.Text = "Si desea editar el producto, ingrese la información que desea cambiar y presione el botón \"Editar\".";
            label2.Click += label2_Click;
            // 
            // buttonEditarProducto
            // 
            buttonEditarProducto.Location = new Point(386, 693);
            buttonEditarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonEditarProducto.Name = "buttonEditarProducto";
            buttonEditarProducto.Size = new Size(86, 31);
            buttonEditarProducto.TabIndex = 12;
            buttonEditarProducto.Text = "Editar ";
            buttonEditarProducto.UseVisualStyleBackColor = true;
            buttonEditarProducto.Click += buttonEditarProducto_Click;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(941, 179);
            buttonEliminarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(160, 31);
            buttonEliminarProducto.TabIndex = 13;
            buttonEliminarProducto.Text = "Eliminar producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            buttonEliminarProducto.Click += buttonEliminarProducto_Click;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(491, 693);
            buttonAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(86, 31);
            buttonAgregarProducto.TabIndex = 14;
            buttonAgregarProducto.Text = "Agregar";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(203, 695);
            textBoxNombreProducto.Margin = new Padding(3, 4, 3, 4);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(114, 27);
            textBoxNombreProducto.TabIndex = 15;
            textBoxNombreProducto.TextChanged += textBoxNombreProducto_TextChanged_1;
            // 
            // textBoPrecioProducto
            // 
            textBoPrecioProducto.Location = new Point(203, 738);
            textBoPrecioProducto.Margin = new Padding(3, 4, 3, 4);
            textBoPrecioProducto.Name = "textBoPrecioProducto";
            textBoPrecioProducto.Size = new Size(114, 27);
            textBoPrecioProducto.TabIndex = 16;
            textBoPrecioProducto.TextChanged += textBoPrecioProducto_TextChanged;
            // 
            // textBoxUnidadMedida
            // 
            textBoxUnidadMedida.Location = new Point(203, 777);
            textBoxUnidadMedida.Margin = new Padding(3, 4, 3, 4);
            textBoxUnidadMedida.Name = "textBoxUnidadMedida";
            textBoxUnidadMedida.Size = new Size(114, 27);
            textBoxUnidadMedida.TabIndex = 17;
            textBoxUnidadMedida.TextChanged += textBoxUnidadMedida_TextChanged;
            // 
            // textBoxTipoProducto
            // 
            textBoxTipoProducto.Location = new Point(203, 828);
            textBoxTipoProducto.Margin = new Padding(3, 4, 3, 4);
            textBoxTipoProducto.Name = "textBoxTipoProducto";
            textBoxTipoProducto.Size = new Size(114, 27);
            textBoxTipoProducto.TabIndex = 18;
            textBoxTipoProducto.TextChanged += textBoxTipoProducto_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 698);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 19;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 738);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 20;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 784);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 21;
            label5.Text = "Unidad de Medida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 828);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 22;
            label6.Text = "Tipo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 621);
            label7.Name = "label7";
            label7.Size = new Size(742, 20);
            label7.TabIndex = 23;
            label7.Text = "Si desea agregar un nuevo producto, ingrese toda la información y seguidamente presione el botón \"Agregar\".";
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.Location = new Point(421, 179);
            buttonSeleccionarProducto.Margin = new Padding(3, 4, 3, 4);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(99, 31);
            buttonSeleccionarProducto.TabIndex = 25;
            buttonSeleccionarProducto.Text = "Seleccionar";
            buttonSeleccionarProducto.UseVisualStyleBackColor = true;
            buttonSeleccionarProducto.Click += buttonSeleccionarProducto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 255);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1050, 287);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonVolvermenuPrincipal
            // 
            buttonVolvermenuPrincipal.Location = new Point(958, 866);
            buttonVolvermenuPrincipal.Margin = new Padding(3, 4, 3, 4);
            buttonVolvermenuPrincipal.Name = "buttonVolvermenuPrincipal";
            buttonVolvermenuPrincipal.Size = new Size(143, 31);
            buttonVolvermenuPrincipal.TabIndex = 26;
            buttonVolvermenuPrincipal.Text = "Menu Principal";
            buttonVolvermenuPrincipal.UseVisualStyleBackColor = true;
            buttonVolvermenuPrincipal.Click += buttonVolvermenuPrincipal_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 229);
            label10.Name = "label10";
            label10.Size = new Size(190, 20);
            label10.TabIndex = 29;
            label10.Text = "Vista General de Productos:";
            label10.Click += label10_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2199, 1325);
            Controls.Add(label10);
            Controls.Add(buttonVolvermenuPrincipal);
            Controls.Add(buttonSeleccionarProducto);
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
            Controls.Add(textBoxNombreProductoBuscar);
            Controls.Add(label1);
            Controls.Add(buttonBuscarProducto);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button buttonBuscarProducto;
        private Label label1;
        private TextBox textBoxNombreProductoBuscar;
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
        private Button buttonSeleccionarProducto;
        private DataGridView dataGridView1;
        private Button buttonVolvermenuPrincipal;
        private Label label10;
    }
}