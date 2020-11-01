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
    public partial class fmrAulas : Form
    {
        //--------- ATRIBUTOS -------------
		private CAulas aUsuario;
		// -------- METODOS ---------------
        public fmrAulas()
        {
            InitializeComponent();
            aUsuario = new CAulas();
        }
        
        private void fmrAulas_Load(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------
        public void Insertar()
        { // validar que los datos obligatorios esten completos
            if (txtCodigo.Text.Trim() != "" && txtCodResponsable.Text.Trim() != "" && txtResponsable.Text.Trim() != "" && txtDescripcion.Text.Trim() != "" )
            { // Insertar registro
                aUsuario.Insertar(txtCodigo.Text, txtCodResponsable.Text, txtResponsable.Text, txtDescripcion.Text);
                txtCodigo.Enabled = false;
                MessageBox.Show("Aula registrada exitosamente");
            }
            else
                MessageBox.Show("Ingrese los datos completos");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        //---------------------------------------------------------------
        public void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtCodResponsable.Clear();
            txtResponsable.Clear();
            txtDescripcion.Clear();
            txtCodigo.Enabled = true;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrRegistro_Aulas VentanaNueva = new fmrRegistro_Aulas();
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
