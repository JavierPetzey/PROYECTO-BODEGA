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
    public partial class Form17 : Form
    {
        private conexiongeneral f = new conexiongeneral();
        public Form17()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= |DataDirectory|\\BaseDeDatos-Bodega.mdb");
        OleDbConnection com = new OleDbConnection();
        OleDbDataReader dr;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int cantidad, precio, total;

            cantidad = Convert.ToInt32(textBox1.Text);
            precio = Convert.ToInt32(textBox2.Text);
            total = cantidad * precio;
            textBox3.Text = Convert.ToString(total);
        }
    }
}
