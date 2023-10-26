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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonVentasRestaurante = new Button();
            buttonVentasTiki = new Button();
            buttonVentasSobrante = new Button();
            buttonVolverMenuPrinciapl = new Button();
            label2 = new Label();
            textBoxTotalVentas = new TextBox();
            buttonGuardarTotalVentas = new Button();
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
            // buttonVentasRestaurante
            // 
            buttonVentasRestaurante.Location = new Point(644, 367);
            buttonVentasRestaurante.Name = "buttonVentasRestaurante";
            buttonVentasRestaurante.Size = new Size(100, 23);
            buttonVentasRestaurante.TabIndex = 1;
            buttonVentasRestaurante.Text = "Restaurante";
            buttonVentasRestaurante.UseVisualStyleBackColor = true;
            // 
            // buttonVentasTiki
            // 
            buttonVentasTiki.Location = new Point(658, 510);
            buttonVentasTiki.Name = "buttonVentasTiki";
            buttonVentasTiki.Size = new Size(86, 23);
            buttonVentasTiki.TabIndex = 2;
            buttonVentasTiki.Text = "Tiki";
            buttonVentasTiki.UseVisualStyleBackColor = true;
            // 
            // buttonVentasSobrante
            // 
            buttonVentasSobrante.Location = new Point(658, 661);
            buttonVentasSobrante.Name = "buttonVentasSobrante";
            buttonVentasSobrante.Size = new Size(86, 23);
            buttonVentasSobrante.TabIndex = 3;
            buttonVentasSobrante.Text = "Sobrante";
            buttonVentasSobrante.UseVisualStyleBackColor = true;
            // 
            // buttonVolverMenuPrinciapl
            // 
            buttonVolverMenuPrinciapl.Location = new Point(12, 966);
            buttonVolverMenuPrinciapl.Name = "buttonVolverMenuPrinciapl";
            buttonVolverMenuPrinciapl.Size = new Size(105, 23);
            buttonVolverMenuPrinciapl.TabIndex = 4;
            buttonVolverMenuPrinciapl.Text = "Menú Principal";
            buttonVolverMenuPrinciapl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(620, 64);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Total Ventas:";
            // 
            // textBoxTotalVentas
            // 
            textBoxTotalVentas.Location = new Point(722, 61);
            textBoxTotalVentas.Name = "textBoxTotalVentas";
            textBoxTotalVentas.Size = new Size(100, 23);
            textBoxTotalVentas.TabIndex = 6;
            textBoxTotalVentas.TextChanged += textBoxTotalVentas_TextChanged;
            // 
            // buttonGuardarTotalVentas
            // 
            buttonGuardarTotalVentas.Location = new Point(828, 64);
            buttonGuardarTotalVentas.Name = "buttonGuardarTotalVentas";
            buttonGuardarTotalVentas.Size = new Size(75, 23);
            buttonGuardarTotalVentas.TabIndex = 7;
            buttonGuardarTotalVentas.Text = "Guardar";
            buttonGuardarTotalVentas.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonGuardarTotalVentas);
            Controls.Add(textBoxTotalVentas);
            Controls.Add(label2);
            Controls.Add(buttonVolverMenuPrinciapl);
            Controls.Add(buttonVentasSobrante);
            Controls.Add(buttonVentasTiki);
            Controls.Add(buttonVentasRestaurante);
            Controls.Add(label1);
            Name = "Ventas";
            Text = "Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonVentasRestaurante;
        private Button buttonVentasTiki;
        private Button buttonVentasSobrante;
        private Button buttonVolverMenuPrinciapl;
        private Label label2;
        private TextBox textBoxTotalVentas;
        private Button buttonGuardarTotalVentas;
    }
}