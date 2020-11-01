﻿using System;
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
    public partial class fmrRegistro_Aulas : Form
    {
         //--------- ATRIBUTOS -------------
		private CAulas aUsuario;
		// -------- METODOS ---------------
        public fmrRegistro_Aulas()
        {
            InitializeComponent();
            aUsuario = new CAulas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() != "")
            {
                if (aUsuario.Autentificar(txtCodigo.Text) > 0)
                {
                    MessageBox.Show("El Aula si existe...");
                }
                else
                    MessageBox.Show("El Aula no existe...");

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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Ventana.DataSource = aUsuario.Listado().Tables[0];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrAulas AnteriorVentana = new fmrAulas();
            AnteriorVentana.Show();
            this.Close();
        }
    }
}