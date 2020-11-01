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
    public partial class Registros_Usuario : Form
    {
    //--------- ATRIBUTOS -------------
		private Usuarios aUsuario;
		// -------- METODOS ---------------
        public Registros_Usuario()
        {
            InitializeComponent();
            aUsuario = new Usuarios();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VentanaMostrar.DataSource = aUsuario.Listado().Tables[0];
        }
        //---------------------------------------------------------------
        public void CargarGrid()
        {
            VentanaMostrar.DataSource = aUsuario.Listado().Tables[0];
        }
        //-------------------------------------------------------------
        public void Eliminar()
        {
            // Eliminar registro
            if (txtUsuario.Text.Trim() != "")
            {   // Eliminar registro
                aUsuario.Eliminar(txtUsuario.Text);
                MessageBox.Show("Registro eliminado exitosamente");
                CargarGrid();
            }
            else
                MessageBox.Show("No se puede eliminar");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Usuarios AnteriorVentana = new Registro_Usuarios();
            AnteriorVentana.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "")
            {
                if (aUsuario.Autentificar(txtUsuario.Text) > 0)
                {
                    MessageBox.Show("El usuario si existe...");
                }
                else
                    MessageBox.Show("El usuario no existe...");

            }
            else
                MessageBox.Show("Ingrese usuario a buscar...");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
