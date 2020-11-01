using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Biblioteca
{
    public partial class Login : Form
    {
        //--------- ATRIBUTOS -------------
		private Usuarios aUsuario;
		// -------- METODOS ---------------
        public Login()
        {
            InitializeComponent();
            aUsuario = new Usuarios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(aUsuario.Autentificar(txtUsuario.Text,txtContraseña.Text)>0)
            {
                frmPrincipal V =new frmPrincipal();
                this.Hide();
                V.ShowDialog();
                
            }
            else
                MessageBox.Show("Usuario no existe");
            }

        private void Login_Load(object sender, EventArgs e)
        {
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

