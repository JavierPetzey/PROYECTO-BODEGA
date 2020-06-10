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
    public partial class Form42 : Form
    {
        private conexiongeneral f = new conexiongeneral();
        public Form42()
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string sql;
            con.Open();
            sql = "INSERT INTO inventario_usuario(herramienta, cantidad, precio, total) VALUES(@herramienta, @cantidad, @precio, @total)";
            f.cmd = new OleDbCommand(sql, con);

            f.cmd.Parameters.AddWithValue("@herramienta", label4.Text);
            f.cmd.Parameters.AddWithValue("@cantidad", textBox1.Text);
            f.cmd.Parameters.AddWithValue("@precio", textBox2.Text);
            f.cmd.Parameters.AddWithValue("@total", textBox3.Text);

            f.cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            sql = "INSERT INTO inventario_administrador(herramienta, cantidad, precio, total) VALUES(@herramienta, @cantidad, @precio, @total)";
            f.cmd = new OleDbCommand(sql, con);

            f.cmd.Parameters.AddWithValue("@herramienta", label4.Text);
            f.cmd.Parameters.AddWithValue("@cantidad", textBox1.Text);
            f.cmd.Parameters.AddWithValue("@precio", textBox2.Text);
            f.cmd.Parameters.AddWithValue("@total", textBox3.Text);

            f.cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
