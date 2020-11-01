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
    public partial class frmResponsables : Form
    {
         //--------- ATRIBUTOS -------------
		private CResponsables aUsuario;
		// -------- METODOS ---------------
        public frmResponsables()
        {
            InitializeComponent();
            aUsuario = new CResponsables();
        }
        //---------------------------------------------------------------
        public void Insertar()
        { // validar que los datos obligatorios esten completos
            if (txtCodigo.Text.Trim() != "" && txtNombres.Text.Trim() != "" && txtApellidos.Text.Trim() != "" && txtDNI.Text.Trim() != "" && txtDireccion.Text.Trim() != "")
            { // Insertar registro
                aUsuario.Insertar(txtCodigo.Text, txtNombres.Text, txtApellidos.Text, txtDNI.Text, txtDireccion.Text);
                txtCodigo.Enabled = false ;
                MessageBox.Show("Responsable registrado exitosamente");
            }
            else
                MessageBox.Show("Ingrese los datos completos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal re = new frmPrincipal();
            re.Show();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrRegistro_Responsables VentanaNueva = new fmrRegistro_Responsables();
            VentanaNueva.Show();
            this.Close();
        }
        //---------------------------------------------------------------
        public void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtCodigo.Enabled = true;
        }
        //---------------------------------------------------------------
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
