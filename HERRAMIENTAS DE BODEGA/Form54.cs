using System;
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
    
    public partial class Form54 : Form
    {
        private conexiongeneral f = new conexiongeneral();
        public Form54()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string bus2;
            bus2 = "SELECT * FROM herramientas_de_medida";
            f.consultas(dataGridView1, bus2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
