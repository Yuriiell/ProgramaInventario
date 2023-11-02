namespace ProgramaInventario1.vistas
{
    partial class VentasVentaDiaria
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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "VentasVentaDiaria";
        }

        #endregion
=======
            buttonGuardarAMR = new Button();
            textBoxAMR = new TextBox();
            label9 = new Label();
            buttonEditarVentaR = new Button();
            buttonGuardarPMR = new Button();
            textBoxPMR = new TextBox();
            label4 = new Label();
            buttonguardarDiaR = new Button();
            textBoxDiaR = new TextBox();
            textBoxFechaBuscarR = new TextBox();
            dataGridViewTablaRestaurante = new DataGridView();
            buttonMostrarTodoRestaurante = new Button();
            buttonEliminarVentaR = new Button();
            buttonAgregarVentaR = new Button();
            label3 = new Label();
            buttonBuscarFechaR = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonGuardarAMT = new Button();
            textBoxAMT = new TextBox();
            label5 = new Label();
            buttonEditarVentaT = new Button();
            buttonguardarPMT = new Button();
            textBoxPMT = new TextBox();
            label6 = new Label();
            buttonGuardarNumeroDiaT = new Button();
            textBoxNumeroDiaT = new TextBox();
            textBoxFechaBuscarT = new TextBox();
            dataGridViewT = new DataGridView();
            buttonMostarTodoT = new Button();
            buttonEliminarVentaT = new Button();
            buttonAgregarVentaT = new Button();
            label7 = new Label();
            buttonBuscarFechaT = new Button();
            label10 = new Label();
            label8 = new Label();
            buttonMenuVentas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaRestaurante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewT).BeginInit();
            SuspendLayout();
            // 
            // buttonGuardarAMR
            // 
            buttonGuardarAMR.Location = new Point(355, 249);
            buttonGuardarAMR.Name = "buttonGuardarAMR";
            buttonGuardarAMR.Size = new Size(75, 23);
            buttonGuardarAMR.TabIndex = 87;
            buttonGuardarAMR.Text = "Guardar";
            buttonGuardarAMR.UseVisualStyleBackColor = true;
            buttonGuardarAMR.Click += buttonGuardarAMR_Click;
            // 
            // textBoxAMR
            // 
            textBoxAMR.Location = new Point(233, 249);
            textBoxAMR.Name = "textBoxAMR";
            textBoxAMR.Size = new Size(100, 23);
            textBoxAMR.TabIndex = 86;
            textBoxAMR.TextChanged += textBoxAMR_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(186, 311);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 85;
            label9.Text = "PM";
            // 
            // buttonEditarVentaR
            // 
            buttonEditarVentaR.Location = new Point(659, 199);
            buttonEditarVentaR.Name = "buttonEditarVentaR";
            buttonEditarVentaR.Size = new Size(118, 23);
            buttonEditarVentaR.TabIndex = 84;
            buttonEditarVentaR.Text = "Editar Venta";
            buttonEditarVentaR.UseVisualStyleBackColor = true;
            buttonEditarVentaR.Click += buttonEditarVentaR_Click;
            // 
            // buttonGuardarPMR
            // 
            buttonGuardarPMR.Location = new Point(355, 311);
            buttonGuardarPMR.Name = "buttonGuardarPMR";
            buttonGuardarPMR.Size = new Size(75, 23);
            buttonGuardarPMR.TabIndex = 83;
            buttonGuardarPMR.Text = "Guardar";
            buttonGuardarPMR.UseVisualStyleBackColor = true;
            buttonGuardarPMR.Click += buttonGuardarPMR_Click;
            // 
            // textBoxPMR
            // 
            textBoxPMR.Location = new Point(233, 311);
            textBoxPMR.Name = "textBoxPMR";
            textBoxPMR.Size = new Size(100, 23);
            textBoxPMR.TabIndex = 82;
            textBoxPMR.TextChanged += textBoxPMR_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 250);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 81;
            label4.Text = "AM";
            // 
            // buttonguardarDiaR
            // 
            buttonguardarDiaR.Location = new Point(419, 190);
            buttonguardarDiaR.Name = "buttonguardarDiaR";
            buttonguardarDiaR.Size = new Size(75, 23);
            buttonguardarDiaR.TabIndex = 80;
            buttonguardarDiaR.Text = "Guardar";
            buttonguardarDiaR.UseVisualStyleBackColor = true;
            buttonguardarDiaR.Click += buttonguardarDiaR_Click;
            // 
            // textBoxDiaR
            // 
            textBoxDiaR.Location = new Point(292, 191);
            textBoxDiaR.Name = "textBoxDiaR";
            textBoxDiaR.Size = new Size(100, 23);
            textBoxDiaR.TabIndex = 79;
            textBoxDiaR.TextChanged += textBoxDiaR_TextChanged;
            // 
            // textBoxFechaBuscarR
            // 
            textBoxFechaBuscarR.Location = new Point(242, 132);
            textBoxFechaBuscarR.Name = "textBoxFechaBuscarR";
            textBoxFechaBuscarR.Size = new Size(100, 23);
            textBoxFechaBuscarR.TabIndex = 78;
            textBoxFechaBuscarR.TextChanged += textBoxFechaBuscarR_TextChanged;
            // 
            // dataGridViewTablaRestaurante
            // 
            dataGridViewTablaRestaurante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTablaRestaurante.Location = new Point(186, 372);
            dataGridViewTablaRestaurante.Name = "dataGridViewTablaRestaurante";
            dataGridViewTablaRestaurante.RowTemplate.Height = 25;
            dataGridViewTablaRestaurante.Size = new Size(591, 575);
            dataGridViewTablaRestaurante.TabIndex = 77;
            dataGridViewTablaRestaurante.CellContentClick += dataGridViewTablaRestaurante_CellContentClick;
            // 
            // buttonMostrarTodoRestaurante
            // 
            buttonMostrarTodoRestaurante.Location = new Point(702, 311);
            buttonMostrarTodoRestaurante.Name = "buttonMostrarTodoRestaurante";
            buttonMostrarTodoRestaurante.Size = new Size(75, 46);
            buttonMostrarTodoRestaurante.TabIndex = 76;
            buttonMostrarTodoRestaurante.Text = "Mostrar Todo";
            buttonMostrarTodoRestaurante.UseVisualStyleBackColor = true;
            buttonMostrarTodoRestaurante.Click += buttonMostrarTodoRestaurante_Click;
            // 
            // buttonEliminarVentaR
            // 
            buttonEliminarVentaR.Location = new Point(659, 250);
            buttonEliminarVentaR.Name = "buttonEliminarVentaR";
            buttonEliminarVentaR.Size = new Size(118, 23);
            buttonEliminarVentaR.TabIndex = 75;
            buttonEliminarVentaR.Text = "Eliminar Venta";
            buttonEliminarVentaR.UseVisualStyleBackColor = true;
            buttonEliminarVentaR.Click += buttonEliminarVentaR_Click;
            // 
            // buttonAgregarVentaR
            // 
            buttonAgregarVentaR.Location = new Point(659, 141);
            buttonAgregarVentaR.Name = "buttonAgregarVentaR";
            buttonAgregarVentaR.Size = new Size(118, 23);
            buttonAgregarVentaR.TabIndex = 74;
            buttonAgregarVentaR.Text = "Agregar Venta";
            buttonAgregarVentaR.UseVisualStyleBackColor = true;
            buttonAgregarVentaR.Click += buttonAgregarVentaR_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 194);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 73;
            label3.Text = "Número de día";
            // 
            // buttonBuscarFechaR
            // 
            buttonBuscarFechaR.Location = new Point(355, 134);
            buttonBuscarFechaR.Name = "buttonBuscarFechaR";
            buttonBuscarFechaR.Size = new Size(75, 23);
            buttonBuscarFechaR.TabIndex = 72;
            buttonBuscarFechaR.Text = "Buscar";
            buttonBuscarFechaR.UseVisualStyleBackColor = true;
            buttonBuscarFechaR.Click += buttonBuscarFechaR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 135);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 71;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(185, 74);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 70;
            label1.Text = "Restaurante";
            // 
            // buttonGuardarAMT
            // 
            buttonGuardarAMT.Location = new Point(1332, 249);
            buttonGuardarAMT.Name = "buttonGuardarAMT";
            buttonGuardarAMT.Size = new Size(75, 23);
            buttonGuardarAMT.TabIndex = 105;
            buttonGuardarAMT.Text = "Guardar";
            buttonGuardarAMT.UseVisualStyleBackColor = true;
            buttonGuardarAMT.Click += buttonGuardarAMT_Click;
            // 
            // textBoxAMT
            // 
            textBoxAMT.Location = new Point(1210, 249);
            textBoxAMT.Name = "textBoxAMT";
            textBoxAMT.Size = new Size(100, 23);
            textBoxAMT.TabIndex = 104;
            textBoxAMT.TextChanged += textBoxAMT_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1163, 311);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 103;
            label5.Text = "PM";
            // 
            // buttonEditarVentaT
            // 
            buttonEditarVentaT.Location = new Point(1636, 199);
            buttonEditarVentaT.Name = "buttonEditarVentaT";
            buttonEditarVentaT.Size = new Size(118, 23);
            buttonEditarVentaT.TabIndex = 102;
            buttonEditarVentaT.Text = "Editar Venta";
            buttonEditarVentaT.UseVisualStyleBackColor = true;
            buttonEditarVentaT.Click += buttonEditarVentaT_Click;
            // 
            // buttonguardarPMT
            // 
            buttonguardarPMT.Location = new Point(1332, 311);
            buttonguardarPMT.Name = "buttonguardarPMT";
            buttonguardarPMT.Size = new Size(75, 23);
            buttonguardarPMT.TabIndex = 101;
            buttonguardarPMT.Text = "Guardar";
            buttonguardarPMT.UseVisualStyleBackColor = true;
            buttonguardarPMT.Click += buttonguardarPMT_Click;
            // 
            // textBoxPMT
            // 
            textBoxPMT.Location = new Point(1210, 311);
            textBoxPMT.Name = "textBoxPMT";
            textBoxPMT.Size = new Size(100, 23);
            textBoxPMT.TabIndex = 100;
            textBoxPMT.TextChanged += textBoxPMT_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1163, 250);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 99;
            label6.Text = "AM";
            // 
            // buttonGuardarNumeroDiaT
            // 
            buttonGuardarNumeroDiaT.Location = new Point(1396, 190);
            buttonGuardarNumeroDiaT.Name = "buttonGuardarNumeroDiaT";
            buttonGuardarNumeroDiaT.Size = new Size(75, 23);
            buttonGuardarNumeroDiaT.TabIndex = 98;
            buttonGuardarNumeroDiaT.Text = "Guardar";
            buttonGuardarNumeroDiaT.UseVisualStyleBackColor = true;
            buttonGuardarNumeroDiaT.Click += buttonGuardarNumeroDiaT_Click;
            // 
            // textBoxNumeroDiaT
            // 
            textBoxNumeroDiaT.Location = new Point(1269, 191);
            textBoxNumeroDiaT.Name = "textBoxNumeroDiaT";
            textBoxNumeroDiaT.Size = new Size(100, 23);
            textBoxNumeroDiaT.TabIndex = 97;
            textBoxNumeroDiaT.TextChanged += textBoxNumeroDiaT_TextChanged;
            // 
            // textBoxFechaBuscarT
            // 
            textBoxFechaBuscarT.Location = new Point(1219, 132);
            textBoxFechaBuscarT.Name = "textBoxFechaBuscarT";
            textBoxFechaBuscarT.Size = new Size(100, 23);
            textBoxFechaBuscarT.TabIndex = 96;
            textBoxFechaBuscarT.TextChanged += textBoxFechaBuscarT_TextChanged;
            // 
            // dataGridViewT
            // 
            dataGridViewT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewT.Location = new Point(1163, 372);
            dataGridViewT.Name = "dataGridViewT";
            dataGridViewT.RowTemplate.Height = 25;
            dataGridViewT.Size = new Size(591, 575);
            dataGridViewT.TabIndex = 95;
            dataGridViewT.CellContentClick += dataGridViewT_CellContentClick;
            // 
            // buttonMostarTodoT
            // 
            buttonMostarTodoT.Location = new Point(1679, 311);
            buttonMostarTodoT.Name = "buttonMostarTodoT";
            buttonMostarTodoT.Size = new Size(75, 46);
            buttonMostarTodoT.TabIndex = 94;
            buttonMostarTodoT.Text = "Mostrar Todo";
            buttonMostarTodoT.UseVisualStyleBackColor = true;
            buttonMostarTodoT.Click += buttonMostarTodoT_Click;
            // 
            // buttonEliminarVentaT
            // 
            buttonEliminarVentaT.Location = new Point(1636, 250);
            buttonEliminarVentaT.Name = "buttonEliminarVentaT";
            buttonEliminarVentaT.Size = new Size(118, 23);
            buttonEliminarVentaT.TabIndex = 93;
            buttonEliminarVentaT.Text = "Eliminar Venta";
            buttonEliminarVentaT.UseVisualStyleBackColor = true;
            buttonEliminarVentaT.Click += buttonEliminarVentaT_Click;
            // 
            // buttonAgregarVentaT
            // 
            buttonAgregarVentaT.Location = new Point(1636, 141);
            buttonAgregarVentaT.Name = "buttonAgregarVentaT";
            buttonAgregarVentaT.Size = new Size(118, 23);
            buttonAgregarVentaT.TabIndex = 92;
            buttonAgregarVentaT.Text = "Agregar Venta";
            buttonAgregarVentaT.UseVisualStyleBackColor = true;
            buttonAgregarVentaT.Click += buttonAgregarVentaT_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1163, 194);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 91;
            label7.Text = "Número de día";
            // 
            // buttonBuscarFechaT
            // 
            buttonBuscarFechaT.Location = new Point(1332, 134);
            buttonBuscarFechaT.Name = "buttonBuscarFechaT";
            buttonBuscarFechaT.Size = new Size(75, 23);
            buttonBuscarFechaT.TabIndex = 90;
            buttonBuscarFechaT.Text = "Buscar";
            buttonBuscarFechaT.UseVisualStyleBackColor = true;
            buttonBuscarFechaT.Click += buttonBuscarFechaT_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1162, 135);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 89;
            label10.Text = "Fecha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1163, 74);
            label8.Name = "label8";
            label8.Size = new Size(42, 28);
            label8.TabIndex = 88;
            label8.Text = "Tiki";
            // 
            // buttonMenuVentas
            // 
            buttonMenuVentas.Location = new Point(12, 966);
            buttonMenuVentas.Name = "buttonMenuVentas";
            buttonMenuVentas.Size = new Size(96, 23);
            buttonMenuVentas.TabIndex = 106;
            buttonMenuVentas.Text = "Menú Ventas";
            buttonMenuVentas.UseVisualStyleBackColor = true;
            buttonMenuVentas.Click += buttonMenuVentas_Click;
            // 
            // VentasVentaDiaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonMenuVentas);
            Controls.Add(buttonGuardarAMT);
            Controls.Add(textBoxAMT);
            Controls.Add(label5);
            Controls.Add(buttonEditarVentaT);
            Controls.Add(buttonguardarPMT);
            Controls.Add(textBoxPMT);
            Controls.Add(label6);
            Controls.Add(buttonGuardarNumeroDiaT);
            Controls.Add(textBoxNumeroDiaT);
            Controls.Add(textBoxFechaBuscarT);
            Controls.Add(dataGridViewT);
            Controls.Add(buttonMostarTodoT);
            Controls.Add(buttonEliminarVentaT);
            Controls.Add(buttonAgregarVentaT);
            Controls.Add(label7);
            Controls.Add(buttonBuscarFechaT);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(buttonGuardarAMR);
            Controls.Add(textBoxAMR);
            Controls.Add(label9);
            Controls.Add(buttonEditarVentaR);
            Controls.Add(buttonGuardarPMR);
            Controls.Add(textBoxPMR);
            Controls.Add(label4);
            Controls.Add(buttonguardarDiaR);
            Controls.Add(textBoxDiaR);
            Controls.Add(textBoxFechaBuscarR);
            Controls.Add(dataGridViewTablaRestaurante);
            Controls.Add(buttonMostrarTodoRestaurante);
            Controls.Add(buttonEliminarVentaR);
            Controls.Add(buttonAgregarVentaR);
            Controls.Add(label3);
            Controls.Add(buttonBuscarFechaR);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentasVentaDiaria";
            Text = "VentasVentaDiaria";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaRestaurante).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGuardarAMR;
        private TextBox textBoxAMR;
        private Label label9;
        private Button buttonEditarVentaR;
        private Button buttonGuardarPMR;
        private TextBox textBoxPMR;
        private Label label4;
        private Button buttonguardarDiaR;
        private TextBox textBoxDiaR;
        private TextBox textBoxFechaBuscarR;
        private DataGridView dataGridViewTablaRestaurante;
        private Button buttonMostrarTodoRestaurante;
        private Button buttonEliminarVentaR;
        private Button buttonAgregarVentaR;
        private Label label3;
        private Button buttonBuscarFechaR;
        private Label label2;
        private Label label1;
        private Button buttonGuardarAMT;
        private TextBox textBoxAMT;
        private Label label5;
        private Button buttonEditarVentaT;
        private Button buttonguardarPMT;
        private TextBox textBoxPMT;
        private Label label6;
        private Button buttonGuardarNumeroDiaT;
        private TextBox textBoxNumeroDiaT;
        private TextBox textBoxFechaBuscarT;
        private DataGridView dataGridViewT;
        private Button buttonMostarTodoT;
        private Button buttonEliminarVentaT;
        private Button buttonAgregarVentaT;
        private Label label7;
        private Button buttonBuscarFechaT;
        private Label label10;
        private Label label8;
        private Button buttonMenuVentas;
>>>>>>> Sophia
    }
}