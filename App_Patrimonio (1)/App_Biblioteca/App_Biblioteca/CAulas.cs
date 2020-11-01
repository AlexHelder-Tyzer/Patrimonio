using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace App_Biblioteca
{
    class CAulas
    {
        // ---- Atributos ----------------
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        private bool aNuevo;
        // ---- Constructores ------------
        public CAulas()
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
        // --- Inserción de nuevos registros en la tabla TAula
        public void Insertar(string pCodAula, string pCodResponsable, string pResponsable, string pDescripcion)
        { // formar la cadena de insercion
            string CadenaInsertar = "insert into TAulas values ('" + pCodAula + "','" + pCodResponsable + "','" + pResponsable + "','" + pDescripcion + "')";
            // insertar el registro
            SqlCommand oComando = new SqlCommand(CadenaInsertar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
            aNuevo = false;
        }
        // ---------------------------------------------------------------------
        public int Autentificar(String pUsuario)
        {
            int resultado = -1;
            aConexion.Open();
            SqlCommand cmd = new SqlCommand("Select CodAula From TAulas Where CodAula=@usuario ", aConexion);
            cmd.Parameters.AddWithValue("usuario", pUsuario);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                resultado = 50;
            }
            aConexion.Close();
            return resultado;
        }
        // ---------------------------------------------------------------------
        public DataSet Listado()
        { // recupera la lista de libros
            string CadenaConsulta = "select * from TAulas";
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        // -------------------------------------------------------------------
        public void Eliminar(string pUsuario)
        { // formar la cadena de insercion
            string CadenaEliminar = "delete from TAulas where CodAula = '" + pUsuario + "'";
            // eliminar el registro
            SqlCommand oComando = new SqlCommand(CadenaEliminar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
    }
}
