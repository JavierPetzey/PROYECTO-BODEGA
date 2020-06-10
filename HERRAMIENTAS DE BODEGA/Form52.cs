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
    public partial class Form52 : Form
    {
        private conexiongeneral f = new conexiongeneral();
        public Form52()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= |DataDirectory|\\BaseDeDatos-Bodega.mdb");
        OleDbConnection com = new OleDbConnection();
        OleDbDataReader dr;
        private void Form52_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string sql;

            con.Open();
            sql = "INSERT INTO usuarios(nombre, contraseña, telefono, dirección, correo_electronico,tipo_usuario) VALUES(@nombre, @contraseña, @telefono, @dirección, @correo_electronico, @tipo_usuario)";
            f.cmd = new OleDbCommand(sql, con);

            f.cmd.Parameters.AddWithValue("@nombre", textBox2.Text);
            f.cmd.Parameters.AddWithValue("@contraseña", textBox3.Text);
            f.cmd.Parameters.AddWithValue("@telefono", textBox4.Text);
            f.cmd.Parameters.AddWithValue("@dirreción", textBox5.Text);
            f.cmd.Parameters.AddWithValue("@correo_electronico", textBox6.Text);
            f.cmd.Parameters.AddWithValue("@tipo_usuario", comboBox1.Text);

            f.cmd.ExecuteNonQuery();
            con.Close();
            f.consultas(dataGridView1, "SELECT * FROM usuarios WHERE nombre='" + textBox2.Text + "'");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string del;
            del = "DELETE FROM usuarios WHERE nombre='" + textBox2.Text + "'";
            f.operaciones(dataGridView1, del);
            f.consultas(dataGridView1, "SELECT * FROM usuarios WHERE tipo_usuario='" + comboBox1.Text + "'");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string bus;
            bus = "SELECT * FROM usuarios WHERE nombre='" + textBox2.Text + "'";
            f.consultas(dataGridView1, bus);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            string bus2;
            bus2 = "SELECT * FROM usuarios";
            f.consultas(dataGridView1, bus2);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}
