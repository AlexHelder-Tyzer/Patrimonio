using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace App_Biblioteca
{
    class CEquipos
    {
        // ---- Atributos ----------------
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        private bool aNuevo;
        // ---- Constructores ------------
        public CEquipos()
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
        // --- Inserción de nuevos registros en la tabla TEquipo
        public void Insertar(string pCod, string pDes, string pMar, string pMod, string pCar, string pEst, string pObs, string pFech, string pTipo, string pCAula)
        { // formar la cadena de insercion
            string CadenaInsertar = "insert into TEquipo_Laboratorio values ('" + pCod + "','" + pDes + "','" + pMar + "','" + pMod + "', '" + pCar + "', '" + pEst + "', '" + pObs + "', '" + pFech + "', '" + pTipo + "', '" + pCAula + "')";
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
            SqlCommand cmd = new SqlCommand("Select CodEquipo From TEquipo_Laboratorio Where CodEquipo=@usuario ", aConexion);
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
            string CadenaConsulta = "select * from TEquipo_Laboratorio";
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        // -------------------------------------------------------------------
        public void Eliminar(string pUsuario)
        { // formar la cadena de insercion
            string CadenaEliminar = "delete from TEquipo_Laboratorio where CodEquipo = '" + pUsuario + "'";
            // eliminar el registro
            SqlCommand oComando = new SqlCommand(CadenaEliminar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
    }
}
