﻿namespace ProgramaInventario1.vistas
{
    partial class MermasPlatosDevueltos
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
            buttonMostrarTodo = new Button();
            textBoxCantidad = new TextBox();
            textBoxNombreProducto = new TextBox();
            dataGridViewTablaMermasMalEstado = new DataGridView();
            buttonEliminarProducto = new Button();
            buttonAgregarProducto = new Button();
            label3 = new Label();
            buttonSeleccionarProducto = new Button();
            comboBoxProductos = new ComboBox();
            buttonBuscarProducto = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaMermasMalEstado).BeginInit();
            SuspendLayout();
            // 
            // buttonMostrarTodo
            // 
            buttonMostrarTodo.Location = new Point(1003, 451);
            buttonMostrarTodo.Name = "buttonMostrarTodo";
            buttonMostrarTodo.Size = new Size(75, 43);
            buttonMostrarTodo.TabIndex = 49;
            buttonMostrarTodo.Text = "Mostrar Todo";
            buttonMostrarTodo.UseVisualStyleBackColor = true;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(757, 400);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 23);
            textBoxCantidad.TabIndex = 48;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(631, 286);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(100, 23);
            textBoxNombreProducto.TabIndex = 47;
            // 
            // dataGridViewTablaMermasMalEstado
            // 
            dataGridViewTablaMermasMalEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTablaMermasMalEstado.Location = new Point(487, 517);
            dataGridViewTablaMermasMalEstado.Name = "dataGridViewTablaMermasMalEstado";
            dataGridViewTablaMermasMalEstado.RowTemplate.Height = 25;
            dataGridViewTablaMermasMalEstado.Size = new Size(591, 295);
            dataGridViewTablaMermasMalEstado.TabIndex = 46;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(960, 331);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(118, 23);
            buttonEliminarProducto.TabIndex = 45;
            buttonEliminarProducto.Text = "Eliminar Producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(960, 286);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(118, 23);
            buttonAgregarProducto.TabIndex = 44;
            buttonAgregarProducto.Text = "Agregar Producto";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 403);
            label3.Name = "label3";
            label3.Size = new Size(255, 15);
            label3.TabIndex = 43;
            label3.Text = "Cantidad a multiplicar por el total del producto";
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.Location = new Point(757, 331);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(75, 23);
            buttonSeleccionarProducto.TabIndex = 42;
            buttonSeleccionarProducto.Text = "Seleccionar";
            buttonSeleccionarProducto.UseVisualStyleBackColor = true;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(487, 331);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(244, 23);
            comboBoxProductos.TabIndex = 41;
            // 
            // buttonBuscarProducto
            // 
            buttonBuscarProducto.Location = new Point(757, 287);
            buttonBuscarProducto.Name = "buttonBuscarProducto";
            buttonBuscarProducto.Size = new Size(75, 23);
            buttonBuscarProducto.TabIndex = 40;
            buttonBuscarProducto.Text = "Buscar";
            buttonBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 287);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 39;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(486, 219);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 38;
            label1.Text = "Platos devueltos";
            // 
            // MermasPlatosDevueltos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1001);
            Controls.Add(buttonMostrarTodo);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(dataGridViewTablaMermasMalEstado);
            Controls.Add(buttonEliminarProducto);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(label3);
            Controls.Add(buttonSeleccionarProducto);
            Controls.Add(comboBoxProductos);
            Controls.Add(buttonBuscarProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MermasPlatosDevueltos";
            Text = "MermasPlatosDevueltos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaMermasMalEstado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMostrarTodo;
        private TextBox textBoxCantidad;
        private TextBox textBoxNombreProducto;
        private DataGridView dataGridViewTablaMermasMalEstado;
        private Button buttonEliminarProducto;
        private Button buttonAgregarProducto;
        private Label label3;
        private Button buttonSeleccionarProducto;
        private ComboBox comboBoxProductos;
        private Button buttonBuscarProducto;
        private Label label2;
        private Label label1;
    }
}