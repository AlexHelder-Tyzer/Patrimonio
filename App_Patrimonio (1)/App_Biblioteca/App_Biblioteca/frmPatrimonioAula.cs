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
    public partial class frmPatrimonioAula : Form
    {
        //--------- ATRIBUTOS -------------
		private CPatrimonio aUsuario;
		// -------- METODOS ---------------
        public frmPatrimonioAula()
        {
            InitializeComponent();
            aUsuario = new CPatrimonio();
        }
        //---------------------------------------------------------------
        public void Insertar()
        { // validar que los datos obligatorios esten completos
            if (txtCodigo.Text.Trim() != "" && txtDescripcion.Text.Trim() != "" && txtEstado.Text.Trim() != "" && txtObservacion.Text.Trim() != "" && txtFecha.Text.Trim() != "" && txtTipo.Text.Trim() != "" && txtCodAula.Text.Trim() != "")
            { // Insertar registro
                aUsuario.Insertar(txtCodigo.Text, txtDescripcion.Text, txtEstado.Text, txtObservacion.Text, txtFecha.Text, txtTipo.Text, txtCodAula.Text);
                txtCodigo.Enabled = false;
                MessageBox.Show("Patrimonio registrado exitosamente");
            }
            else
                MessageBox.Show("Ingrese los datos completos");
        }
        //---------------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insertar();
        }
        public void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtEstado.Clear();
            txtObservacion.Clear();
            txtFecha.Clear();
            txtTipo.Clear();
            txtCodAula.Clear();
            txtCodigo.Enabled = true;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrRegistro_Patrimonio VentanaNueva = new fmrRegistro_Patrimonio();
            VentanaNueva.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal re = new frmPrincipal();
            re.Show();
        }
    }
}
