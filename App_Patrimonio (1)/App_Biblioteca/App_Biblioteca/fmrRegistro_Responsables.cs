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
    public partial class fmrRegistro_Responsables : Form
    {
        //--------- ATRIBUTOS -------------
		private CResponsables aUsuario;
		// -------- METODOS ---------------
        public fmrRegistro_Responsables()
        {
            InitializeComponent();
            aUsuario = new CResponsables();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() != "")
            {
                if (aUsuario.Autentificar(txtCodigo.Text) > 0)
                {
                    MessageBox.Show("El Responsable si existe...");
                }
                else
                    MessageBox.Show("El Responsable no existe...");

            }
            else
                MessageBox.Show("Ingrese codigo a buscar...");
        }
        //---------------------------------------------------------------
        public void CargarGrid()
        {
            Ventana.DataSource = aUsuario.Listado().Tables[0];
        }
        //-------------------------------------------------------------
        public void Eliminar()
        {
            // Eliminar registro
            if (txtCodigo.Text.Trim() != "")
            {   // Eliminar registro
                aUsuario.Eliminar(txtCodigo.Text);
                MessageBox.Show("Registro eliminado exitosamente");
                CargarGrid();
            }
            else
                MessageBox.Show("No se puede eliminar");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventana.DataSource = aUsuario.Listado().Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResponsables AnteriorVentana = new frmResponsables();
            AnteriorVentana.Show();
            this.Close();
        }
    }
}
