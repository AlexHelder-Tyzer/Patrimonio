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
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnLector_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmLectores aLector = new frmLectores();
			aLector.Show();
		}

		private void btnLibros_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmLibro  aLibro = new frmLibro();
			aLibro.Show();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Usuarios re = new Registro_Usuarios();
            re.Show();
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrAulas re = new fmrAulas();
            re.Show();
            this.Close();
        }

        private void btnResponsables_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResponsables re = new frmResponsables();
            re.Show();
            this.Close();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrEquipos re = new fmrEquipos();
            re.Show();
            this.Close();
        }

        private void btnPatrimonios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatrimonioAula re = new frmPatrimonioAula();
            re.Show();
            this.Close();
        }
	}
}
