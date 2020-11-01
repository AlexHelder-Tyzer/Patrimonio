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
	public partial class frmLectores : Form
	{
		//--------- ATRIBUTOS -------------
		private CLector aLector;
		// -------- METODOS ---------------
		public frmLectores()
		{
			InitializeComponent();
			aLector = new CLector();
			CargarGrid();
		}
		//---------------------------------------------------------------
		public void LimpiarFormulario()
		{
			txtCodigo.Clear();
			txtApellidos.Clear();
			txtNombres.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			txtDNI.Clear();
			//dtpFecha.Clear();
			txtCodigo.Enabled = true;
			aLector.Nuevo = true;
		}
		//---------------------------------------------------------------
		public void CargarGrid()
		{
			dgvLectores.DataSource = aLector.Listado().Tables[0];
		}
		//---------------------------------------------------------------
		public void Insertar()
		{ // validar que los datos obligatorios esten completos
			if (txtCodigo.Text.Trim() != "" && txtApellidos.Text.Trim() != "" && txtNombres.Text != "")
			{ // Insertar registro
				aLector.Insertar(txtCodigo.Text, txtApellidos.Text, txtNombres.Text,
				txtDireccion.Text, txtTelefono.Text, txtDNI.Text, dtpFecha.Text);
				txtCodigo.Enabled = false;
				MessageBox.Show("Registro guardado exitosamente");
				CargarGrid();
			}
			else
				MessageBox.Show("Ingrese los datos completos");
		}
		//-----------------------------------------------------------------------------
		public void Actualizar()
		{ // validar que los datos obligatorios esten completos
			if (txtCodigo.Text.Trim() != "" && txtApellidos.Text.Trim() != "" && txtNombres.Text != "")
			{ // actualizar registro
				aLector.Actualizar(txtCodigo.Text, txtApellidos.Text, txtNombres.Text,
				txtDireccion.Text, txtTelefono.Text, txtDNI.Text, dtpFecha.Text);
				MessageBox.Show("Los datos se actualizaron exitosamente");
				CargarGrid();
			}
			else
				MessageBox.Show("Ingrese los datos completos");
		}
		//------------------------------------------------------------
		public void CargarRegistro()
		{ // llena la infomacion de un registro específico en el formulario
			if (txtCodigo.Text.Trim() != "" && txtApellidos.Text.Trim() != "" && txtNombres.Text != "")
			{
				aLector.Registro(txtCodigo.Text.Trim());
				txtApellidos.Text = aLector.ValorAtributo("Apellidos").ToString();
				txtNombres.Text = aLector.ValorAtributo("Nombres").ToString();
				txtDireccion.Text = aLector.ValorAtributo("Direccion").ToString();
				txtTelefono.Text = aLector.ValorAtributo("Telefono").ToString();
				txtDNI.Text = aLector.ValorAtributo("DNI").ToString();
				dtpFecha.Text = aLector.ValorAtributo("Fecha de Inscripcion").ToString();
				txtCodigo.Enabled = false;
				aLector.Nuevo = false;
			}
		}
		//-------------------------------------------------------------
		public void Eliminar()
		{
			// Eliminar registro
			if (txtEliminarLector.Text.Trim() != "")
			{   // Eliminar registro
				aLector.Eliminar(txtEliminarLector.Text);
				MessageBox.Show("Registro eliminado exitosamente");
				CargarGrid();
			}
			else
				MessageBox.Show("No se puede eliminar");
		}
		private void bntNuevo_Click(object sender, EventArgs e)
		{
			LimpiarFormulario();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (aLector.Nuevo)
				Insertar();
			else
				Actualizar();
		}

		private void txtCodigo_Leave(object sender, EventArgs e)
		{
			if (aLector.ExisteClave(txtCodigo.Text.Trim()))
				CargarRegistro();
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmPrincipal AnteriorVentana = new frmPrincipal();
			AnteriorVentana.Show();
			this.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Eliminar();
		}

		private void txtEliminarLector_Leave(object sender, EventArgs e)
		{
			if (aLector.ExisteClave(txtEliminarLector.Text.Trim()))
				CargarRegistro();
		}

        private void dgvLectores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
	}
}
