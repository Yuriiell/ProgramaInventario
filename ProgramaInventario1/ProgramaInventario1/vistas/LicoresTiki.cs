﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaInventario1.vistas
{
    public partial class LicoresTiki : Form
    {
        public LicoresTiki()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Licores licoresForm = new Licores();
            licoresForm.Show();
            this.Hide();
        }
    }
}
