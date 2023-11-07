namespace ProgramaInventario1.vistas
{
    partial class MenuPrincipal
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
            cmb = new ComboBox();
            button1 = new Button();
            buttonSalirPrograma = new Button();
            botonVistaResumen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 123);
            label1.Name = "label1";
            label1.Size = new Size(435, 106);
            label1.TabIndex = 9;
            label1.Text = "Bienvenido";
            label1.Click += label1_Click;
            // 
            // cmb
            // 
            cmb.FormattingEnabled = true;
            cmb.Items.AddRange(new object[] { "Productos", "Mermas", "Verduras", "Interno", "Pedidos", "Ventas", "Licores" });
            cmb.Location = new Point(216, 290);
            cmb.Name = "cmb";
            cmb.Size = new Size(191, 28);
            cmb.TabIndex = 10;
            cmb.Text = "Seleccionar";
            cmb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(430, 289);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonSalirPrograma
            // 
            buttonSalirPrograma.Location = new Point(216, 419);
            buttonSalirPrograma.Margin = new Padding(3, 4, 3, 4);
            buttonSalirPrograma.Name = "buttonSalirPrograma";
            buttonSalirPrograma.Size = new Size(94, 31);
            buttonSalirPrograma.TabIndex = 8;
            buttonSalirPrograma.Text = "Salir";
            buttonSalirPrograma.UseVisualStyleBackColor = true;
            buttonSalirPrograma.Click += buttonSalirPrograma_Click;
            // 
            // botonVistaResumen
            // 
            botonVistaResumen.Location = new Point(430, 419);
            botonVistaResumen.Margin = new Padding(3, 4, 3, 4);
            botonVistaResumen.Name = "botonVistaResumen";
            botonVistaResumen.Size = new Size(86, 31);
            botonVistaResumen.TabIndex = 7;
            botonVistaResumen.Text = "Resumen";
            botonVistaResumen.UseVisualStyleBackColor = true;
            botonVistaResumen.Click += botonVistaResumen_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2199, 816);
            Controls.Add(button1);
            Controls.Add(cmb);
            Controls.Add(label1);
            Controls.Add(buttonSalirPrograma);
            Controls.Add(botonVistaResumen);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cmb;
        private Button button1;
        private Button buttonSalirPrograma;
        private Button botonVistaResumen;
    }
}