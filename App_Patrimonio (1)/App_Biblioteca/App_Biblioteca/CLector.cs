using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace App_Biblioteca
{
	class CLector
	{
		// ---- Atributos ----------------
		private SqlConnection aConexion;
		private SqlDataAdapter aAdaptador;
		private DataSet aDatos;
		private bool aNuevo;
		// ---- Constructores ------------
		public CLector()
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
		public void Insertar(string pCodLector, string pApellidos, string pNombres,
		string pDireccion, string pTelefono, string pDNI, string pFechaInscripcion)
		{ // formar la cadena de insercion
			string CadenaInsertar = "insert into TLector values ('" + pCodLector + "', '" +
			pApellidos + "', '" + pNombres + "', '" + pDireccion + "', '" + pTelefono + "', '" + pDNI + "', '" + pFechaInscripcion + "')";
			// insertar el registro
			SqlCommand oComando = new SqlCommand(CadenaInsertar, aConexion);
			aConexion.Open();
			oComando.ExecuteNonQuery();
			aConexion.Close();
			aNuevo = false;
		}
		// -------------------------------------------------------------------
		public void Actualizar(string pCodLector, string pApellidos, string pNombres,
		string pDireccion, string pTelefono, string pDNI, string pFechaInscripcion)
		{ // formar la cadena de insercion
			string CadenaActualizar = "update TLector set Apellidos = '" + pApellidos + "'," +
			"Nombres = '" + pNombres + "'," +
			"Direccion = '" + pDireccion + "'," +
			"Telefono = '" + pTelefono + "' " +
			"DNI = '" + pDNI + "' " +
			"FechaInscripcion = '" + pFechaInscripcion + "' " +
			"where CodLibro = '" + pCodLector + "'";
			// actualizar el registro
			SqlCommand oComando = new SqlCommand(CadenaActualizar, aConexion);
			aConexion.Open();
			oComando.ExecuteNonQuery();
			aConexion.Close();
		}
		// -------------------------------------------------------------------
		public void Eliminar(string pCodLector)
		{ // formar la cadena de insercion
			string CadenaEliminar = "delete from TLector where CodLector = '" + pCodLector + "'";
			// eliminar el registro
			SqlCommand oComando = new SqlCommand(CadenaEliminar, aConexion);
			aConexion.Open();
			oComando.ExecuteNonQuery();
			aConexion.Close();
		}
		// -------------------------------------------------------------------
		public bool ExisteClave(string pCodLector)
		{ // verifica si un registro especifico existe
			string CadenaConsulta = "select * from TLector where CodLector = '" + pCodLector + "'";
			// ejecutar la consulta y verificar si existen registros en la tabla 0
			aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
			aDatos = new DataSet();
			aAdaptador.Fill(aDatos);
			return (aDatos.Tables[0].Rows.Count > 0);
		}
		// -------------------------------------------------------------------
		public void Registro(string pCodLector)
		{ // recupera la información de un registro
			string CadenaConsulta = "select * from TLector where CodLector = '" + pCodLector + "'";
			// Ejecutar la consulta
			aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
			aDatos = new DataSet();
			aAdaptador.Fill(aDatos);
		}
		// ---------------------------------------------------------------------
		public DataSet Listado()
		{ // recupera la lista de libros
			string CadenaConsulta = "select * from TLector";
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
