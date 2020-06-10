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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= |DataDirectory|\\BaseDeDatos-Bodega.mdb");
        OleDbConnection com = new OleDbConnection();
        OleDbDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string telefono = textBox3.Text;
            string correo_electronico = textBox4.Text;
            if (usuario == "" || contraseña == "" || telefono=="" || correo_electronico=="")
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM usuarios WHERE nombre ='" + textBox1.Text + "'and contraseña='" + textBox2.Text + "'and correo_electronico='" + textBox3.Text + "'and telefono='" + textBox4.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int contador = dt.Rows.Count;
            if (contador > 0)
            {
                string tipo = dt.Rows[0]["tipo_usuario"].ToString();
                if (tipo == "1")
                {
                    MessageBox.Show("BIENVENIDO ADMINISTRADOR");
                    this.Hide();
                    admin frm = new admin();
                    frm.Show();
                }
                else if (tipo == "2")
                {
                    MessageBox.Show("BIENVENIDO USUARIO");
                    this.Hide();
                    usuario frm = new usuario();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            con.Close();


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            registrarse frm2 = new registrarse();
            frm2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
