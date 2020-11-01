using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace App_Biblioteca
{
	class CLibro
	{   // ---- Atributos ----------------
		private SqlConnection aConexion;
		private SqlDataAdapter aAdaptador;
		private DataSet aDatos;
		private bool aNuevo;
		// ---- Constructores ------------
		public CLibro()
		{ // inicializar los atributos
			aNuevo = true;
			aDatos = new DataSet();
			aAdaptador = new SqlDataAdapter();
			// realizar la conexion
            string CadenaConexion = "Data Source=LAPTOP-7LQFUUK8\\SQLEXPRESS; Initial Catalog=bdPatrimonio; Integrated Security=True";
		aConexion = new SqlConnection(CadenaConexion);
		}
		// ---------- propiedades --------------------------
		public bool Nuevo
		{
			get { return aNuevo; }
			set { aNuevo = value; }
		}
		// -------------------------------------------------------------------
		// --- Métodos para el mantenimiento de la tabla
		// -------------------------------------------------------------------
		// --- Inserción de nuevos registros en la tabla TLibro
		public void Insertar(string pCodLibro, string pTitulo, string pAutor,
		string pEditorial, string pAgno)
		{ // formar la cadena de insercion
			string CadenaInsertar = "insert into TLibro values ('" + pCodLibro + "', '" +
			pTitulo + "', '" + pAutor + "', '" + pEditorial + "', '" +
			pAgno + "')";
			// insertar el registro
			SqlCommand oComando = new SqlCommand(CadenaInsertar, aConexion);
			aConexion.Open();
			oComando.ExecuteNonQuery();
			aConexion.Close();
			aNuevo = false;
		}
		// -------------------------------------------------------------------
		public void Actualizar(string pCodLibro, string pTitulo, string pAutor, string pEditorial,
		string pAgno)
		{ // formar la cadena de insercion
			string CadenaActualizar = "update TLibro set Titulo = '" + pTitulo + "'," +
			"Autor = '" + pAutor + "'," +
			"Editorial = '" + pEditorial + "'," +
			"Agno = '" + pAgno + "' " +
			"where CodLibro = '" + pCodLibro + "'";
			// actualizar el registro
			SqlCommand oComando = new SqlCommand(CadenaActualizar, aConexion);
			aConexion.Open();
			oComando.ExecuteNonQuery();
			aConexion.Close();
		}
		// -------------------------------------------------------------------
		public void Eliminar(string pCodLibro)
		{ // formar la cadena de insercion
			string CadenaEliminar = "delete from TLibro where CodLibro = '" + pCodLibro + "'";
			// eliminar el registro
			SqlCommand oComando = new SqlCommand(CadenaEliminar, aConexion);
			aConexion.Open();
			oComando.ExecuteNonQuery();
			aConexion.Close();
		}
		// -------------------------------------------------------------------
		public bool ExisteClave(string pCodLibro)
		{ // verifica si un registro especifico existe
			string CadenaConsulta = "select * from TLibro where CodLibro = '" + pCodLibro + "'";
			// ejecutar la consulta y verificar si existen registros en la tabla 0
			aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
			aDatos = new DataSet();
			aAdaptador.Fill(aDatos);
			return (aDatos.Tables[0].Rows.Count > 0);
		}
		// -------------------------------------------------------------------
		public void Registro(string pCodLibro)
		{ // recupera la información de un registro
			string CadenaConsulta = "select * from TLibro where CodLibro = '" + pCodLibro + "'";
			// Ejecutar la consulta
			aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
			aDatos = new DataSet();
			aAdaptador.Fill(aDatos);
		}
		// ---------------------------------------------------------------------
		public DataSet Listado()
		{ // recupera la lista de libros
			string CadenaConsulta = "select * from TLibro";
			// Ejecutar la consulta
			aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
			aDatos = new DataSet();
			aAdaptador.Fill(aDatos);
			return aDatos;
		}
		// ---------------------------------------------------------------------
		public Object ValorAtributo(string pNombreCampo)
		{ // Recupera el valor de un atributo del dataset
			return aDatos.Tables[0].Rows[0][pNombreCampo];
		}
	}
}
