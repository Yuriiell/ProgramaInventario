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
            botonVistaProductos = new Button();
            botonVistaMermas = new Button();
            botonVistaVerduras = new Button();
            botonVistaInterno = new Button();
            botonVistaPedidos = new Button();
            botonVistaVEntas = new Button();
            botonVistaLicores = new Button();
            botonVistaResumen = new Button();
            SuspendLayout();
            // 
            // botonVistaProductos
            // 
            botonVistaProductos.Location = new Point(377, 168);
            botonVistaProductos.Name = "botonVistaProductos";
            botonVistaProductos.Size = new Size(75, 23);
            botonVistaProductos.TabIndex = 0;
            botonVistaProductos.Text = "Productos";
            botonVistaProductos.UseVisualStyleBackColor = true;
            botonVistaProductos.Click += botonVistaProductos_Click;
            // 
            // botonVistaMermas
            // 
            botonVistaMermas.Location = new Point(370, 244);
            botonVistaMermas.Name = "botonVistaMermas";
            botonVistaMermas.Size = new Size(75, 23);
            botonVistaMermas.TabIndex = 1;
            botonVistaMermas.Text = "Mermas";
            botonVistaMermas.UseVisualStyleBackColor = true;
            botonVistaMermas.Click += botonVistaMermas_Click;
            // 
            // botonVistaVerduras
            // 
            botonVistaVerduras.Location = new Point(397, 316);
            botonVistaVerduras.Name = "botonVistaVerduras";
            botonVistaVerduras.Size = new Size(75, 23);
            botonVistaVerduras.TabIndex = 2;
            botonVistaVerduras.Text = "Verduras";
            botonVistaVerduras.UseVisualStyleBackColor = true;
            botonVistaVerduras.Click += botonVistaVerduras_Click;
            // 
            // botonVistaInterno
            // 
            botonVistaInterno.Location = new Point(390, 391);
            botonVistaInterno.Name = "botonVistaInterno";
            botonVistaInterno.Size = new Size(75, 23);
            botonVistaInterno.TabIndex = 3;
            botonVistaInterno.Text = "Interno";
            botonVistaInterno.UseVisualStyleBackColor = true;
            botonVistaInterno.Click += botonVistaInterno_Click;
            // 
            // botonVistaPedidos
            // 
            botonVistaPedidos.Location = new Point(404, 469);
            botonVistaPedidos.Name = "botonVistaPedidos";
            botonVistaPedidos.Size = new Size(75, 23);
            botonVistaPedidos.TabIndex = 4;
            botonVistaPedidos.Text = "Pedidos";
            botonVistaPedidos.UseVisualStyleBackColor = true;
            botonVistaPedidos.Click += botonVistaPedidos_Click;
            // 
            // botonVistaVEntas
            // 
            botonVistaVEntas.Location = new Point(404, 558);
            botonVistaVEntas.Name = "botonVistaVEntas";
            botonVistaVEntas.Size = new Size(75, 23);
            botonVistaVEntas.TabIndex = 5;
            botonVistaVEntas.Text = "Ventas";
            botonVistaVEntas.UseVisualStyleBackColor = true;
            botonVistaVEntas.Click += botonVistaVEntas_Click;
            // 
            // botonVistaLicores
            // 
            botonVistaLicores.Location = new Point(410, 621);
            botonVistaLicores.Name = "botonVistaLicores";
            botonVistaLicores.Size = new Size(75, 23);
            botonVistaLicores.TabIndex = 6;
            botonVistaLicores.Text = "Licores";
            botonVistaLicores.UseVisualStyleBackColor = true;
            botonVistaLicores.Click += botonVistaLicores_Click;
            // 
            // botonVistaResumen
            // 
            botonVistaResumen.Location = new Point(434, 696);
            botonVistaResumen.Name = "botonVistaResumen";
            botonVistaResumen.Size = new Size(75, 23);
            botonVistaResumen.TabIndex = 7;
            botonVistaResumen.Text = "Resumen";
            botonVistaResumen.UseVisualStyleBackColor = true;
            botonVistaResumen.Click += botonVistaResumen_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 776);
            Controls.Add(botonVistaResumen);
            Controls.Add(botonVistaLicores);
            Controls.Add(botonVistaVEntas);
            Controls.Add(botonVistaPedidos);
            Controls.Add(botonVistaInterno);
            Controls.Add(botonVistaVerduras);
            Controls.Add(botonVistaMermas);
            Controls.Add(botonVistaProductos);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button botonVistaProductos;
        private Button botonVistaMermas;
        private Button botonVistaVerduras;
        private Button botonVistaInterno;
        private Button botonVistaPedidos;
        private Button botonVistaVEntas;
        private Button botonVistaLicores;
        private Button botonVistaResumen;
    }
}