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
	public partial class frmLibro : Form
	{
		//--------- ATRIBUTOS -------------
		private CLibro aLibro;
		// -------- METODOS ---------------
		public frmLibro()
		{
			InitializeComponent();
			aLibro = new CLibro();
			CargarGrid();
		}
		//--------------------------------------------------------------------------
		public void LimpiarFormulario()
		{
			txtCodLibro.Clear();
			txtTitulo.Clear();
			txtAutor.Clear();
			txtEditorial.Clear();
			txtAgno.Clear();
			txtCodLibro.Enabled = true;
			aLibro.Nuevo = true;
		}
		//---------------------------------------------------------------
		public void CargarGrid()
		{
			dgvLibros.DataSource = aLibro.Listado().Tables[0];
		}
		//---------------------------------------------------------------
		public void Insertar()
		{ // validar que los datos obligatorios esten completos
			if (txtCodLibro.Text.Trim() != "" && txtTitulo.Text.Trim() != "" && txtAutor.Text != "")
			{ // Insertar registro
				aLibro.Insertar(txtCodLibro.Text, txtTitulo.Text, txtAutor.Text,
				txtEditorial.Text, txtAgno.Text);
				txtCodLibro.Enabled = false;
				MessageBox.Show("Registro guardado exitosamente");
				CargarGrid();
			}
			else
				MessageBox.Show("Ingrese los datos completos");
		} 
		//-----------------------------------------------------------------------------
		public void Actualizar()
		{ // validar que los datos obligatorios esten completos
			if (txtCodLibro.Text.Trim() != "" && txtTitulo.Text.Trim() != "" && txtAutor.Text != "")
			{ // actualizar registro
				aLibro.Actualizar(txtCodLibro.Text, txtTitulo.Text, txtAutor.Text,
				txtEditorial.Text, txtAgno.Text);
				MessageBox.Show("Los datos se actualizaron exitosamente");
				CargarGrid();
			}
			else
				MessageBox.Show("Ingrese los datos completos");
		}
		//------------------------------------------------------------
		public void CargarRegistro()
		{ // llena la infomacion de un registro específico en el formulario
			if (txtCodLibro.Text.Trim() != "" && txtTitulo.Text.Trim() != "" && txtAutor.Text != "")
			{
				aLibro.Registro(txtCodLibro.Text.Trim());
				txtTitulo.Text = aLibro.ValorAtributo("Titulo").ToString();
				txtAutor.Text = aLibro.ValorAtributo("Autor").ToString();
				txtEditorial.Text = aLibro.ValorAtributo("Editorial").ToString();
				txtAgno.Text = aLibro.ValorAtributo("Agno").ToString();
				txtCodLibro.Enabled = false;
				aLibro.Nuevo = false;
			}
		}
		//-------------------------------------------------------------
		public void Eliminar()
		{
			// Eliminar registro
			if (txtCodEliminar.Text.Trim()!="")
			{   // Eliminar registro
				aLibro.Eliminar(txtCodEliminar.Text);
				MessageBox.Show("Registro eliminado exitosamente");
				CargarGrid();
			}
			else
				MessageBox.Show("No se puede eliminar","ERROR");
		}
		//--------------------------------------------------------------
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (aLibro.Nuevo)
				Insertar();
			else
				Actualizar();
		}
		//---------------------------------------------------------------
		private void txtCodLibro_Leave(object sender, EventArgs e)
		{
			if (aLibro.ExisteClave(txtCodLibro.Text.Trim()))
				CargarRegistro();
		}
		//----------------------------------------------
		private void btnNuevo_Click_1(object sender, EventArgs e)
		{
			LimpiarFormulario();
		}
		//--------------------------------------------------
		private void btnGuardar_Click_1(object sender, EventArgs e)
		{
			if (aLibro.Nuevo)
				Insertar();
			else
				Actualizar();
		}
		//-------------------------------------------------
		private void txtCodLibro_TextChanged(object sender, EventArgs e)
		{

		}
		//------------------------------------------------------------
		private void txtCodLibro_Leave_1(object sender, EventArgs e)
		{
			if (aLibro.ExisteClave(txtCodLibro.Text.Trim()))
				CargarRegistro();
		}
		//---------------------------------------------------------------------------
		private void bntEliminar_Click(object sender, EventArgs e)
		{
			Eliminar();
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmPrincipal AnteriorVentana = new frmPrincipal();
			AnteriorVentana.Show();
			this.Close();
		}

		private void txtCodEliminar_Leave(object sender, EventArgs e)
		{
			if (aLibro.ExisteClave(txtCodEliminar.Text.Trim()))
				CargarRegistro();
		}

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
	}
}
