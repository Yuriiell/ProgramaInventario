namespace ProgramaInventario1.vistas
{
    partial class Ventas
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
            buttonVentasSobrante = new Button();
            buttonVolverMenuPrinciapl = new Button();
            buttonVentasVentaDiaria = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(620, 213);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 0;
            label1.Text = "Menú Ventas";
            // 
            // buttonVentasSobrante
            // 
            buttonVentasSobrante.Location = new Point(630, 452);
            buttonVentasSobrante.Name = "buttonVentasSobrante";
            buttonVentasSobrante.Size = new Size(100, 23);
            buttonVentasSobrante.TabIndex = 3;
            buttonVentasSobrante.Text = "Sobrante";
            buttonVentasSobrante.UseVisualStyleBackColor = true;
            buttonVentasSobrante.Click += buttonVentasSobrante_Click;
            // 
            // buttonVolverMenuPrinciapl
            // 
            buttonVolverMenuPrinciapl.Location = new Point(12, 966);
            buttonVolverMenuPrinciapl.Name = "buttonVolverMenuPrinciapl";
            buttonVolverMenuPrinciapl.Size = new Size(105, 23);
            buttonVolverMenuPrinciapl.TabIndex = 4;
            buttonVolverMenuPrinciapl.Text = "Menú Principal";
            buttonVolverMenuPrinciapl.UseVisualStyleBackColor = true;
            buttonVolverMenuPrinciapl.Click += buttonVolverMenuPrinciapl_Click;
            // 
            // buttonVentasVentaDiaria
            // 
            buttonVentasVentaDiaria.Location = new Point(630, 390);
            buttonVentasVentaDiaria.Name = "buttonVentasVentaDiaria";
            buttonVentasVentaDiaria.Size = new Size(100, 23);
            buttonVentasVentaDiaria.TabIndex = 5;
            buttonVentasVentaDiaria.Text = "Venta Diaria";
            buttonVentasVentaDiaria.UseVisualStyleBackColor = true;
            buttonVentasVentaDiaria.Click += buttonVentasVentaDiaria_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonVentasVentaDiaria);
            Controls.Add(buttonVolverMenuPrinciapl);
            Controls.Add(buttonVentasSobrante);
            Controls.Add(label1);
            Name = "Ventas";
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonVentasSobrante;
        private Button buttonVolverMenuPrinciapl;
        private Button buttonVentasVentaDiaria;
    }
}