namespace ProgramaInventario1.vistas
{
    partial class Interno
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
            buttonPlatosBebidas = new Button();
            buttonConsumoInterno = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonPlatosBebidas
            // 
            buttonPlatosBebidas.Location = new Point(576, 427);
            buttonPlatosBebidas.Name = "buttonPlatosBebidas";
            buttonPlatosBebidas.Size = new Size(114, 23);
            buttonPlatosBebidas.TabIndex = 0;
            buttonPlatosBebidas.Text = "Platos y bebidas";
            buttonPlatosBebidas.UseVisualStyleBackColor = true;
            buttonPlatosBebidas.Click += buttonPlatosBebidas_Click;
            // 
            // buttonConsumoInterno
            // 
            buttonConsumoInterno.Location = new Point(576, 519);
            buttonConsumoInterno.Name = "buttonConsumoInterno";
            buttonConsumoInterno.Size = new Size(118, 23);
            buttonConsumoInterno.TabIndex = 1;
            buttonConsumoInterno.Text = "Consumo Interno";
            buttonConsumoInterno.UseVisualStyleBackColor = true;
            buttonConsumoInterno.Click += buttonConsumoInterno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(534, 286);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 2;
            label1.Text = "Escoja la sección donde desea ingresar";
            // 
            // button1
            // 
            button1.Location = new Point(25, 954);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 3;
            button1.Text = "Menu Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Interno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(buttonConsumoInterno);
            Controls.Add(buttonPlatosBebidas);
            Name = "Interno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interno";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPlatosBebidas;
        private Button buttonConsumoInterno;
        private Label label1;
        private Button button1;
    }
}