using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaData
{
    public class CD_Marca
    {
        private clasConexion Conexion = new clasConexion();
        private NpgsqlDataReader leer;

        public NpgsqlDataReader select()
        {
            Conexion.CerrarConexion();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("marca_select", Conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;               
                leer = command.ExecuteReader();
            }
            catch (Exception e)
            {
                string g = e.Message;
            }
            return leer;

        }
        public NpgsqlDataReader create(string _nombre)
        {
            Conexion.CerrarConexion();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("marca_insert", Conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("e_nombre",_nombre);                             
                leer = command.ExecuteReader();
            }
            catch (Exception e)
            {
                string g = e.Message;
            }
            return leer;

        }
        public NpgsqlDataReader update(string _id,string _nombre)
        {
            Conexion.CerrarConexion();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("marca_update", Conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("e_id",Convert.ToInt16( _id));
                command.Parameters.AddWithValue("e_nombre", _nombre);
                leer = command.ExecuteReader();
            }
            catch (Exception e)
            {
                string g = e.Message;
            }
            return leer;

        }
        public NpgsqlDataReader delete(string _id)
        {
            Conexion.CerrarConexion();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("marca_delete", Conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("e_id", Convert.ToInt16( _id));                
                leer = command.ExecuteReader();
            }
            catch (Exception e)
            {
                string g = e.Message;
            }
            return leer;

        }
    }
}
