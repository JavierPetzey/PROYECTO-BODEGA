﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERRAMIENTAS_DE_BODEGA
{
    public partial class Form58 : Form
    {
        private conexiongeneral f = new conexiongeneral();
        public Form58()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string bus2;
            bus2 = "SELECT * FROM herramientas_de_serrar";
            f.consultas(dataGridView1, bus2);
        }
    }
}
