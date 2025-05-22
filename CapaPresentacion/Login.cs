using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;  

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btningresar_Click_1(object sender, EventArgs e)
        { 
            List<Usuario> TEST = new CN_Usuario().Listar();
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();
            if (ousuario != null) { 
                Inicio form = new Inicio();
                form.Show();
                this.Hide();    
                form.FormClosing += frm_closing;

            }
            else
            {
                MessageBox.Show("No se encontro el usuario","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtclave.Text = "";
            txtdocumento.Text = "";
            this.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {



        }



        private void textBox2_TextChanged(object sender, EventArgs e)

        {



        }



        private void button1_Click(object sender, EventArgs e)

        {
        }

      
    }
}
