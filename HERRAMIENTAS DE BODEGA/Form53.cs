using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace HERRAMIENTAS_DE_BODEGA
{
    public partial class Form53 : Form
    {
        private conexiongeneral f = new conexiongeneral();
        public Form53()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= |DataDirectory|\\BaseDeDatos-Bodega.mdb");
        OleDbConnection com = new OleDbConnection();
        OleDbDataReader dr;


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string bus2;
            bus2 = "SELECT * FROM inventario_administrador";
            f.consultas(dataGridView1, bus2);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string del;
            del = "DELETE FROM inventario_administrador";
            f.operaciones(dataGridView1, del);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            double tot = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                tot += Convert.ToDouble(row.Cells["total"].Value);
            }
            textBox2.Text = Convert.ToString(tot);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            string bus;
            bus = "SELECT * FROM inventario_administrador WHERE herramienta='" + textBox1.Text + "'";
            f.consultas(dataGridView1, bus);
        }

        
    }
}
