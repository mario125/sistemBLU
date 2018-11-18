
using Npgsql;
using System.Data;

namespace capaData
{
    public class classLogin
    {
        private clasConexion Conexion = new clasConexion();
       
        public NpgsqlDataReader iniciarSesion( string user, string pass)
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
