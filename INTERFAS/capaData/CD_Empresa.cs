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
        private NpgsqlDataReader leer;

        public NpgsqlDataReader Select(string _ruc,string _empresa,string _direccion,DateTime _fecha,string _nombre_comercial,string _tipo_contribuyente,int _ubigeo,string _departamento,string _provincia,string _distrito,int _tipo_documento)
        {
            Conexion.CerrarConexion();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("emp_insert", Conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("d_ruc", _ruc);
                command.Parameters.AddWithValue("d_empresa", _empresa);
                command.Parameters.AddWithValue("d_direccion", _direccion);
                command.Parameters.AddWithValue("d_fecha", _fecha);
                command.Parameters.AddWithValue("d_nombre_comercial", _nombre_comercial);
                command.Parameters.AddWithValue("d_tipo_contribuyente", _tipo_contribuyente);
                command.Parameters.AddWithValue("d_ubigeo", _ubigeo);
                command.Parameters.AddWithValue("d_departamento", _departamento);
                command.Parameters.AddWithValue("d_provincia", _provincia);
                command.Parameters.AddWithValue("d_distrito", _distrito);
                command.Parameters.AddWithValue("d_tipo_documento", _tipo_documento);
                leer = command.ExecuteReader();
                
            }
            catch(Exception e)
            {
                string g= e.Message;
            }
            return leer;
            
        }
    }
}
