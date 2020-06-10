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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        
        private void admin_Load(object sender, EventArgs e)
        {

        }
        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new Form52());
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form53());
        }
        private void AbrirForm(object Form52)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = Form52 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form54());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form55());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form56());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form57());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form58());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form59());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form60());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form61());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form62());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form63());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form64());
        }
    }
}
