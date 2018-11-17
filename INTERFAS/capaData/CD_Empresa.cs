using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace capaData
{
   public class CD_Empresa
    {
        private clasConexion Conexion = new clasConexion();

        public NpgsqlDataReader Select(string user, string pass)
        {

            NpgsqlCommand command = new NpgsqlCommand("f_login", Conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("usuario", user);
            command.Parameters.AddWithValue("contra", pass);
            NpgsqlDataReader leer = command.ExecuteReader();

            return leer;
        }
    }
}
