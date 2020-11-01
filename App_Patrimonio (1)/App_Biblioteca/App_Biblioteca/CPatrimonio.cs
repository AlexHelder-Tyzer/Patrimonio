using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace App_Biblioteca
{
    class CPatrimonio
    {
        // ---- Atributos ----------------
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        private bool aNuevo;
        // ---- Constructores ------------
        public CPatrimonio()
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
        public void Insertar(string pCod, string pDes, string pEst, string pObs, string pFech, string pTipo, string pCAula)
        { // formar la cadena de insercion
            string CadenaInsertar = "insert into TPatrimonio_Aula values ('" + pCod + "','" + pDes + "','" + pEst + "', '" + pObs + "', '" + pFech + "', '" + pTipo + "', '" + pCAula + "')";
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
            SqlCommand cmd = new SqlCommand("Select CodPatrimonio From TPatrimonio_Aula Where CodPatrimonio=@usuario ", aConexion);
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
            string CadenaConsulta = "select * from TPatrimonio_Aula";
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        // -------------------------------------------------------------------
        public void Eliminar(string pUsuario)
        { // formar la cadena de insercion
            string CadenaEliminar = "delete from TPatrimonio_Aula where CodPatrimonio = '" + pUsuario + "'";
            // eliminar el registro
            SqlCommand oComando = new SqlCommand(CadenaEliminar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
    }
}
