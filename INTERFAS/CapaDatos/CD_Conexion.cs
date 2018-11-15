using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private OdbcConnection Conexion = new OdbcConnection("Driver={PostgreSQL UNICODE};Server=localhost;Port=5434;Database=mario125; Uid=postgres;Pwd=Scimic?Developer?479;");

        public OdbcConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public OdbcConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
