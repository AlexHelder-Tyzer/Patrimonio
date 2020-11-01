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
    public partial class Registro_Usuarios : Form
    {
        //--------- ATRIBUTOS -------------
		private Usuarios aUsuario;
		// -------- METODOS ---------------
        public Registro_Usuarios()
        {
            InitializeComponent();
            aUsuario = new Usuarios();
        }
        //---------------------------------------------------------------
        public void Insertar()
        { // validar que los datos obligatorios esten completos
            if (Usuario.Text.Trim() != "" && Contraseña.Text.Trim() != "")
            { // Insertar registro
                aUsuario.Insertar(Usuario.Text, Contraseña.Text);
                Usuario.Enabled = false ;
                Contraseña.Enabled = false;
                Confirmar.Enabled = false;
                MessageBox.Show("Usuario registrado exitosamente");
            }
            else
                MessageBox.Show("Ingrese los datos completos");
        }
        //---------------------------------------------------------------
        private void Registro_Usuarios_Load(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (Contraseña.Text==Confirmar.Text)
            {
                Insertar();
            }
            else
            {
                MessageBox.Show("Usuario no existente o contraseña incorrecta ...");
            }
        }
        //---------------------------------------------------------------
        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal re = new frmPrincipal();
            re.Show();
        }
        //---------------------------------------------------------------
        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registros_Usuario VentanaNueva = new Registros_Usuario();
            VentanaNueva.Show();
            this.Close();
        }
        //---------------------------------------------------------------
        public void LimpiarFormulario()
        {
            Usuario.Clear();
            Contraseña.Clear();
            Confirmar.Clear();
            Usuario.Enabled = true;
            Contraseña.Enabled = true;
            Confirmar.Enabled = true;
            aUsuario.Nuevo = true;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
