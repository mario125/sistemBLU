using System;
using System.Data;
using Npgsql;

namespace capaData
{
    class clasConexion
    {
        //private NpgsqlConnection Conexion = new NpgsqlConnection("Driver={PostgreSQL Unicode};Server=localhost;Port=5432;Database=BLU_SISTEM;UID=postgres;PWD=root;");
        NpgsqlConnection Conexion = new NpgsqlConnection("Username=postgres; host=localhost; Port=5432; Database=blu; Password=root;");

        public NpgsqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public NpgsqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
