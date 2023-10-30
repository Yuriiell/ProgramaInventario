namespace ProgramaInventario1.vistas
{
    partial class Mermas
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
            buttonMermasGastos = new Button();
            buttonMermasCortes = new Button();
            buttonMermasMalEstado = new Button();
            buttonPlatosDevueltos = new Button();
            buttonComidaPersonal = new Button();
            buttonMermasFiestaChicas = new Button();
            buttonVolverMenuPrincipal = new Button();
            textBoxReporteMermas = new TextBox();
            buttonGuardarReporteMermas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(553, 45);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 6;
            label1.Text = "Reporte de mermas:";
            label1.Click += label1_Click;
            // 
            // buttonMermasGastos
            // 
            buttonMermasGastos.Location = new Point(636, 140);
            buttonMermasGastos.Name = "buttonMermasGastos";
            buttonMermasGastos.Size = new Size(75, 23);
            buttonMermasGastos.TabIndex = 8;
            buttonMermasGastos.Text = "Gastos";
            buttonMermasGastos.UseVisualStyleBackColor = true;
            buttonMermasGastos.Click += buttonMermasGastos_Click;
            // 
            // buttonMermasCortes
            // 
            buttonMermasCortes.Location = new Point(603, 227);
            buttonMermasCortes.Name = "buttonMermasCortes";
            buttonMermasCortes.Size = new Size(129, 23);
            buttonMermasCortes.TabIndex = 9;
            buttonMermasCortes.Text = "Mermas de recortes";
            buttonMermasCortes.UseVisualStyleBackColor = true;
            buttonMermasCortes.Click += buttonMermasCortes_Click;
            // 
            // buttonMermasMalEstado
            // 
            buttonMermasMalEstado.Location = new Point(593, 328);
            buttonMermasMalEstado.Name = "buttonMermasMalEstado";
            buttonMermasMalEstado.Size = new Size(148, 23);
            buttonMermasMalEstado.TabIndex = 10;
            buttonMermasMalEstado.Text = "Productos en mal estado";
            buttonMermasMalEstado.UseVisualStyleBackColor = true;
            buttonMermasMalEstado.Click += buttonMermasMalEstado_Click;
            // 
            // buttonPlatosDevueltos
            // 
            buttonPlatosDevueltos.Location = new Point(614, 438);
            buttonPlatosDevueltos.Name = "buttonPlatosDevueltos";
            buttonPlatosDevueltos.Size = new Size(118, 23);
            buttonPlatosDevueltos.TabIndex = 11;
            buttonPlatosDevueltos.Text = "Platos devueltos";
            buttonPlatosDevueltos.UseVisualStyleBackColor = true;
            buttonPlatosDevueltos.Click += buttonPlatosDevueltos_Click;
            // 
            // buttonComidaPersonal
            // 
            buttonComidaPersonal.Location = new Point(608, 555);
            buttonComidaPersonal.Name = "buttonComidaPersonal";
            buttonComidaPersonal.Size = new Size(133, 23);
            buttonComidaPersonal.TabIndex = 12;
            buttonComidaPersonal.Text = "Comida del personal";
            buttonComidaPersonal.UseVisualStyleBackColor = true;
            buttonComidaPersonal.Click += buttonComidaPersonal_Click;
            // 
            // buttonMermasFiestaChicas
            // 
            buttonMermasFiestaChicas.Location = new Point(627, 658);
            buttonMermasFiestaChicas.Name = "buttonMermasFiestaChicas";
            buttonMermasFiestaChicas.Size = new Size(105, 23);
            buttonMermasFiestaChicas.TabIndex = 13;
            buttonMermasFiestaChicas.Text = "Fiesta Chicas";
            buttonMermasFiestaChicas.UseVisualStyleBackColor = true;
            buttonMermasFiestaChicas.Click += buttonMermasFiestaChicas_Click;
            // 
            // buttonVolverMenuPrincipal
            // 
            buttonVolverMenuPrincipal.Location = new Point(12, 966);
            buttonVolverMenuPrincipal.Name = "buttonVolverMenuPrincipal";
            buttonVolverMenuPrincipal.Size = new Size(119, 23);
            buttonVolverMenuPrincipal.TabIndex = 14;
            buttonVolverMenuPrincipal.Text = "Menú Principal";
            buttonVolverMenuPrincipal.UseVisualStyleBackColor = true;
            buttonVolverMenuPrincipal.Click += buttonVolverMenuPrincipal_Click;
            // 
            // textBoxReporteMermas
            // 
            textBoxReporteMermas.Location = new Point(701, 45);
            textBoxReporteMermas.Name = "textBoxReporteMermas";
            textBoxReporteMermas.Size = new Size(100, 23);
            textBoxReporteMermas.TabIndex = 15;
            textBoxReporteMermas.TextChanged += textBoxReporteMermas_TextChanged;
            // 
            // buttonGuardarReporteMermas
            // 
            buttonGuardarReporteMermas.Location = new Point(807, 45);
            buttonGuardarReporteMermas.Name = "buttonGuardarReporteMermas";
            buttonGuardarReporteMermas.Size = new Size(75, 23);
            buttonGuardarReporteMermas.TabIndex = 16;
            buttonGuardarReporteMermas.Text = "Guardar";
            buttonGuardarReporteMermas.UseVisualStyleBackColor = true;
            buttonGuardarReporteMermas.Click += buttonGuardarReporteMermas_Click;
            // 
            // Mermas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonGuardarReporteMermas);
            Controls.Add(textBoxReporteMermas);
            Controls.Add(buttonVolverMenuPrincipal);
            Controls.Add(buttonMermasFiestaChicas);
            Controls.Add(buttonComidaPersonal);
            Controls.Add(buttonPlatosDevueltos);
            Controls.Add(buttonMermasMalEstado);
            Controls.Add(buttonMermasCortes);
            Controls.Add(buttonMermasGastos);
            Controls.Add(label1);
            Name = "Mermas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mermas";
            WindowState = FormWindowState.Maximized;
            Load += Mermas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonMermasGastos;
        private Button buttonMermasCortes;
        private Button buttonMermasMalEstado;
        private Button buttonPlatosDevueltos;
        private Button buttonComidaPersonal;
        private Button buttonMermasFiestaChicas;
        private Button buttonVolverMenuPrincipal;
        private TextBox textBoxReporteMermas;
        private Button buttonGuardarReporteMermas;
    }
}