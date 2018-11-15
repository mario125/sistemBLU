using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Odbc ;

namespace CapaDatos
{
    public class CD_Empresa
    {
        private CD_Conexion conexion = new CD_Conexion();

        OdbcDataReader leer;
        DataTable tabla = new DataTable();
        OdbcCommand comando = new OdbcCommand();

        public DataTable Mostrar() { 
       
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
            
        }

        public void Insertar(string empresa, string nom_comercial, string direccion, string fecha, string tip_contri, string ubigeo, string departamento, string provincia, string distrito, string tip_doc) {
            //PROCEDIMNIENTO
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@descrip",desc);
            comando.Parameters.AddWithValue("@Marca",marca);
            comando.Parameters.AddWithValue("@precio",precio);
            comando.Parameters.AddWithValue("@stock",precio);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        
        }

        public void Editar(string nombre, string desc, string marca, double precio, int stock,int id)
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", precio);
            comando.Parameters.AddWithValue("@id",id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int id) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpro",id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}
