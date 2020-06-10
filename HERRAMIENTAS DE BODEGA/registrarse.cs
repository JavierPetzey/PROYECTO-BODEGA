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
    public partial class registrarse : Form
    {
        private conexiongeneral f = new conexiongeneral();
        public registrarse()

        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= |DataDirectory|\\BaseDeDatos-Bodega.mdb");
        OleDbConnection com = new OleDbConnection();
        OleDbDataReader dr;
        private void registrarse_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string sql;
           
            con.Open();
            sql = "INSERT INTO usuarios(nombre, contraseña, telefono, dirección, correo_electronico,tipo_usuario) VALUES(@nombre, @contraseña, @telefono, @dirección, @correo_electronico, @tipo_usuario)";
            f.cmd = new OleDbCommand(sql, con);

            f.cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
            f.cmd.Parameters.AddWithValue("@contraseña", textBox2.Text);
            f.cmd.Parameters.AddWithValue("@telefono", textBox3.Text);
            f.cmd.Parameters.AddWithValue("@dirreción", textBox4.Text);
            f.cmd.Parameters.AddWithValue("@correo_electronico", textBox5.Text);
            f.cmd.Parameters.AddWithValue("@tipo_usuario", textBox6.Text);

            f.cmd.ExecuteNonQuery();
            con.Close();
            f.consultas(dataGridView1, "SELECT * FROM usuarios WHERE nombre='" + textBox1.Text + "'");
            MessageBox.Show("REGISTRO COMPLETO");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
