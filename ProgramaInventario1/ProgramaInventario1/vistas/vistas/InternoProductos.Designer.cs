namespace ProgramaInventario1.vistas
{
    partial class InternoProductos
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
            textBoxNombrePlatoBuscar = new TextBox();
            buttonBuscarPlato = new Button();
            comboBoxPlatos = new ComboBox();
            buttonSeleccionarPlato = new Button();
            dataGridViewPlatos = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxNombrePlato = new TextBox();
            textBoxCantidadPlato = new TextBox();
            textBoxGramajePlato = new TextBox();
            buttonEditarPlato = new Button();
            buttonAgregarPlato = new Button();
            buttonBuscarTodoPlato = new Button();
            buttonVolverMenuInterno = new Button();
            button1 = new Button();
            buttonAgregarbebida = new Button();
            buttonEditarBebida = new Button();
            textBoxGramajeBebida = new TextBox();
            textBoxCantidadBebida = new TextBox();
            textBoxNombreBebida = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dataGridViewBebidas = new DataGridView();
            buttonSeleccionarBebida = new Button();
            comboBoxBebidas = new ComboBox();
            buttonBuscarBebida = new Button();
            textBoxNombreBebidaBuscar = new TextBox();
            label12 = new Label();
            buttonEliminarPlato = new Button();
            buttonEliminarBebida = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBebidas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el plato";
            // 
            // textBoxNombrePlatoBuscar
            // 
            textBoxNombrePlatoBuscar.Location = new Point(23, 64);
            textBoxNombrePlatoBuscar.Name = "textBoxNombrePlatoBuscar";
            textBoxNombrePlatoBuscar.Size = new Size(100, 23);
            textBoxNombrePlatoBuscar.TabIndex = 1;
            textBoxNombrePlatoBuscar.TextChanged += textBoxNombrePlatoBuscar_TextChanged;
            // 
            // buttonBuscarPlato
            // 
            buttonBuscarPlato.Location = new Point(156, 64);
            buttonBuscarPlato.Name = "buttonBuscarPlato";
            buttonBuscarPlato.Size = new Size(75, 23);
            buttonBuscarPlato.TabIndex = 2;
            buttonBuscarPlato.Text = "Buscar";
            buttonBuscarPlato.UseVisualStyleBackColor = true;
            buttonBuscarPlato.Click += buttonBuscarPlato_Click;
            // 
            // comboBoxPlatos
            // 
            comboBoxPlatos.FormattingEnabled = true;
            comboBoxPlatos.Location = new Point(23, 127);
            comboBoxPlatos.Name = "comboBoxPlatos";
            comboBoxPlatos.Size = new Size(284, 23);
            comboBoxPlatos.TabIndex = 3;
            comboBoxPlatos.SelectedIndexChanged += comboBoxPlatos_SelectedIndexChanged;
            // 
            // buttonSeleccionarPlato
            // 
            buttonSeleccionarPlato.Location = new Point(345, 127);
            buttonSeleccionarPlato.Name = "buttonSeleccionarPlato";
            buttonSeleccionarPlato.Size = new Size(82, 23);
            buttonSeleccionarPlato.TabIndex = 4;
            buttonSeleccionarPlato.Text = "Seleccionar";
            buttonSeleccionarPlato.UseVisualStyleBackColor = true;
            buttonSeleccionarPlato.Click += buttonSeleccionarPlato_Click;
            // 
            // dataGridViewPlatos
            // 
            dataGridViewPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlatos.Location = new Point(23, 197);
            dataGridViewPlatos.Name = "dataGridViewPlatos";
            dataGridViewPlatos.RowTemplate.Height = 25;
            dataGridViewPlatos.Size = new Size(919, 215);
            dataGridViewPlatos.TabIndex = 5;
            dataGridViewPlatos.CellContentClick += dataGridViewPlatos_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 460);
            label2.Name = "label2";
            label2.Size = new Size(500, 15);
            label2.TabIndex = 6;
            label2.Text = "Si desea editar el plato, ingrese la información que desea cambiar y presione el botón \"Editar\".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 510);
            label3.Name = "label3";
            label3.Size = new Size(566, 15);
            label3.TabIndex = 7;
            label3.Text = "Si desea agregar un nuevo plato, ingrese toda la información y seguidamente presione el botón \"Agregar\".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 580);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 632);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 9;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 685);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 10;
            label6.Text = "Gramaje";
            // 
            // textBoxNombrePlato
            // 
            textBoxNombrePlato.Location = new Point(123, 571);
            textBoxNombrePlato.Name = "textBoxNombrePlato";
            textBoxNombrePlato.Size = new Size(100, 23);
            textBoxNombrePlato.TabIndex = 11;
            textBoxNombrePlato.TextChanged += textBoxNombrePlato_TextChanged;
            // 
            // textBoxCantidadPlato
            // 
            textBoxCantidadPlato.Location = new Point(123, 629);
            textBoxCantidadPlato.Name = "textBoxCantidadPlato";
            textBoxCantidadPlato.Size = new Size(100, 23);
            textBoxCantidadPlato.TabIndex = 12;
            textBoxCantidadPlato.TextChanged += textBoxCantidadPlato_TextChanged;
            // 
            // textBoxGramajePlato
            // 
            textBoxGramajePlato.Location = new Point(123, 682);
            textBoxGramajePlato.Name = "textBoxGramajePlato";
            textBoxGramajePlato.Size = new Size(100, 23);
            textBoxGramajePlato.TabIndex = 13;
            textBoxGramajePlato.TextChanged += textBoxGramajePlato_TextChanged;
            // 
            // buttonEditarPlato
            // 
            buttonEditarPlato.Location = new Point(302, 597);
            buttonEditarPlato.Name = "buttonEditarPlato";
            buttonEditarPlato.Size = new Size(100, 23);
            buttonEditarPlato.TabIndex = 14;
            buttonEditarPlato.Text = "Editar Plato";
            buttonEditarPlato.UseVisualStyleBackColor = true;
            buttonEditarPlato.Click += buttonEditarPlato_Click;
            // 
            // buttonAgregarPlato
            // 
            buttonAgregarPlato.Location = new Point(302, 656);
            buttonAgregarPlato.Name = "buttonAgregarPlato";
            buttonAgregarPlato.Size = new Size(100, 23);
            buttonAgregarPlato.TabIndex = 15;
            buttonAgregarPlato.Text = "Agregar Plato";
            buttonAgregarPlato.UseVisualStyleBackColor = true;
            buttonAgregarPlato.Click += buttonAgregarPlato_Click;
            // 
            // buttonBuscarTodoPlato
            // 
            buttonBuscarTodoPlato.Location = new Point(867, 430);
            buttonBuscarTodoPlato.Name = "buttonBuscarTodoPlato";
            buttonBuscarTodoPlato.Size = new Size(75, 45);
            buttonBuscarTodoPlato.TabIndex = 16;
            buttonBuscarTodoPlato.Text = "Buscar Todo";
            buttonBuscarTodoPlato.UseVisualStyleBackColor = true;
            buttonBuscarTodoPlato.Click += buttonBuscarTodoPlato_Click;
            // 
            // buttonVolverMenuInterno
            // 
            buttonVolverMenuInterno.Location = new Point(12, 966);
            buttonVolverMenuInterno.Name = "buttonVolverMenuInterno";
            buttonVolverMenuInterno.Size = new Size(111, 23);
            buttonVolverMenuInterno.TabIndex = 17;
            buttonVolverMenuInterno.Text = "Menú Interno";
            buttonVolverMenuInterno.UseVisualStyleBackColor = true;
            buttonVolverMenuInterno.Click += buttonVolverMenuInterno_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1837, 430);
            button1.Name = "button1";
            button1.Size = new Size(75, 45);
            button1.TabIndex = 34;
            button1.Text = "Buscar Todo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAgregarbebida
            // 
            buttonAgregarbebida.Location = new Point(1272, 656);
            buttonAgregarbebida.Name = "buttonAgregarbebida";
            buttonAgregarbebida.Size = new Size(101, 23);
            buttonAgregarbebida.TabIndex = 33;
            buttonAgregarbebida.Text = "Agregar Bebida";
            buttonAgregarbebida.UseVisualStyleBackColor = true;
            buttonAgregarbebida.Click += buttonAgregarbebida_Click;
            // 
            // buttonEditarBebida
            // 
            buttonEditarBebida.Location = new Point(1272, 597);
            buttonEditarBebida.Name = "buttonEditarBebida";
            buttonEditarBebida.Size = new Size(101, 23);
            buttonEditarBebida.TabIndex = 32;
            buttonEditarBebida.Text = "Editar Bebida";
            buttonEditarBebida.UseVisualStyleBackColor = true;
            buttonEditarBebida.Click += buttonEditarBebida_Click;
            // 
            // textBoxGramajeBebida
            // 
            textBoxGramajeBebida.Location = new Point(1093, 682);
            textBoxGramajeBebida.Name = "textBoxGramajeBebida";
            textBoxGramajeBebida.Size = new Size(100, 23);
            textBoxGramajeBebida.TabIndex = 31;
            textBoxGramajeBebida.TextChanged += textBoxGramajeBebida_TextChanged;
            // 
            // textBoxCantidadBebida
            // 
            textBoxCantidadBebida.Location = new Point(1093, 629);
            textBoxCantidadBebida.Name = "textBoxCantidadBebida";
            textBoxCantidadBebida.Size = new Size(100, 23);
            textBoxCantidadBebida.TabIndex = 30;
            textBoxCantidadBebida.TextChanged += textBoxCantidadBebida_TextChanged;
            // 
            // textBoxNombreBebida
            // 
            textBoxNombreBebida.Location = new Point(1093, 571);
            textBoxNombreBebida.Name = "textBoxNombreBebida";
            textBoxNombreBebida.Size = new Size(100, 23);
            textBoxNombreBebida.TabIndex = 29;
            textBoxNombreBebida.TextChanged += textBoxNombreBebida_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(993, 685);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 28;
            label7.Text = "Gramaje";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(993, 632);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 27;
            label8.Text = "Cantidad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(993, 580);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 26;
            label9.Text = "Nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(993, 510);
            label10.Name = "label10";
            label10.Size = new Size(580, 15);
            label10.TabIndex = 25;
            label10.Text = "Si desea agregar una nueva bebida, ingrese toda la información y seguidamente presione el botón \"Agregar\".";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(993, 460);
            label11.Name = "label11";
            label11.Size = new Size(509, 15);
            label11.TabIndex = 24;
            label11.Text = "Si desea editar la bebida, ingrese la información que desea cambiar y presione el botón \"Editar\".";
            // 
            // dataGridViewBebidas
            // 
            dataGridViewBebidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBebidas.Location = new Point(993, 197);
            dataGridViewBebidas.Name = "dataGridViewBebidas";
            dataGridViewBebidas.RowTemplate.Height = 25;
            dataGridViewBebidas.Size = new Size(919, 215);
            dataGridViewBebidas.TabIndex = 23;
            dataGridViewBebidas.CellContentClick += dataGridViewBebidas_CellContentClick;
            // 
            // buttonSeleccionarBebida
            // 
            buttonSeleccionarBebida.Location = new Point(1315, 127);
            buttonSeleccionarBebida.Name = "buttonSeleccionarBebida";
            buttonSeleccionarBebida.Size = new Size(82, 23);
            buttonSeleccionarBebida.TabIndex = 22;
            buttonSeleccionarBebida.Text = "Seleccionar";
            buttonSeleccionarBebida.UseVisualStyleBackColor = true;
            buttonSeleccionarBebida.Click += buttonSeleccionarBebida_Click;
            // 
            // comboBoxBebidas
            // 
            comboBoxBebidas.FormattingEnabled = true;
            comboBoxBebidas.Location = new Point(993, 127);
            comboBoxBebidas.Name = "comboBoxBebidas";
            comboBoxBebidas.Size = new Size(284, 23);
            comboBoxBebidas.TabIndex = 21;
            comboBoxBebidas.SelectedIndexChanged += comboBoxBebidas_SelectedIndexChanged;
            // 
            // buttonBuscarBebida
            // 
            buttonBuscarBebida.Location = new Point(1126, 64);
            buttonBuscarBebida.Name = "buttonBuscarBebida";
            buttonBuscarBebida.Size = new Size(75, 23);
            buttonBuscarBebida.TabIndex = 20;
            buttonBuscarBebida.Text = "Buscar";
            buttonBuscarBebida.UseVisualStyleBackColor = true;
            buttonBuscarBebida.Click += buttonBuscarBebida_Click;
            // 
            // textBoxNombreBebidaBuscar
            // 
            textBoxNombreBebidaBuscar.Location = new Point(993, 64);
            textBoxNombreBebidaBuscar.Name = "textBoxNombreBebidaBuscar";
            textBoxNombreBebidaBuscar.Size = new Size(100, 23);
            textBoxNombreBebidaBuscar.TabIndex = 19;
            textBoxNombreBebidaBuscar.TextChanged += textBoxNombreBebidaBuscar_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(993, 20);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 18;
            label12.Text = "Ingrese el plato";
            // 
            // buttonEliminarPlato
            // 
            buttonEliminarPlato.Location = new Point(833, 156);
            buttonEliminarPlato.Name = "buttonEliminarPlato";
            buttonEliminarPlato.Size = new Size(109, 23);
            buttonEliminarPlato.TabIndex = 35;
            buttonEliminarPlato.Text = "Eliminar Plato";
            buttonEliminarPlato.UseVisualStyleBackColor = true;
            buttonEliminarPlato.Click += buttonEliminarPlato_Click;
            // 
            // buttonEliminarBebida
            // 
            buttonEliminarBebida.Location = new Point(1806, 156);
            buttonEliminarBebida.Name = "buttonEliminarBebida";
            buttonEliminarBebida.Size = new Size(106, 23);
            buttonEliminarBebida.TabIndex = 36;
            buttonEliminarBebida.Text = "Eliminar Bebida";
            buttonEliminarBebida.UseVisualStyleBackColor = true;
            buttonEliminarBebida.Click += buttonEliminarBebida_Click;
            // 
            // InternoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonEliminarBebida);
            Controls.Add(buttonEliminarPlato);
            Controls.Add(button1);
            Controls.Add(buttonAgregarbebida);
            Controls.Add(buttonEditarBebida);
            Controls.Add(textBoxGramajeBebida);
            Controls.Add(textBoxCantidadBebida);
            Controls.Add(textBoxNombreBebida);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(dataGridViewBebidas);
            Controls.Add(buttonSeleccionarBebida);
            Controls.Add(comboBoxBebidas);
            Controls.Add(buttonBuscarBebida);
            Controls.Add(textBoxNombreBebidaBuscar);
            Controls.Add(label12);
            Controls.Add(buttonVolverMenuInterno);
            Controls.Add(buttonBuscarTodoPlato);
            Controls.Add(buttonAgregarPlato);
            Controls.Add(buttonEditarPlato);
            Controls.Add(textBoxGramajePlato);
            Controls.Add(textBoxCantidadPlato);
            Controls.Add(textBoxNombrePlato);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewPlatos);
            Controls.Add(buttonSeleccionarPlato);
            Controls.Add(comboBoxPlatos);
            Controls.Add(buttonBuscarPlato);
            Controls.Add(textBoxNombrePlatoBuscar);
            Controls.Add(label1);
            Name = "InternoProductos";
            Text = "InternoProductos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBebidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombrePlatoBuscar;
        private Button buttonBuscarPlato;
        private ComboBox comboBoxPlatos;
        private Button buttonSeleccionarPlato;
        private DataGridView dataGridViewPlatos;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxNombrePlato;
        private TextBox textBoxCantidadPlato;
        private TextBox textBoxGramajePlato;
        private Button buttonEditarPlato;
        private Button buttonAgregarPlato;
        private Button buttonBuscarTodoPlato;
        private Button buttonVolverMenuInterno;
        private Button button1;
        private Button buttonAgregarbebida;
        private Button buttonEditarBebida;
        private TextBox textBoxGramajeBebida;
        private TextBox textBoxCantidadBebida;
        private TextBox textBoxNombreBebida;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DataGridView dataGridViewBebidas;
        private Button buttonSeleccionarBebida;
        private ComboBox comboBoxBebidas;
        private Button buttonBuscarBebida;
        private TextBox textBoxNombreBebidaBuscar;
        private Label label12;
        private Button buttonEliminarPlato;
        private Button buttonEliminarBebida;
    }
}