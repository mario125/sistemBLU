using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Empresa
    {
        private CD_Empresa objetoCD = new CD_Empresa();

        public DataTable MostrarProd() {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarEmpresa ( string empresa,string nom_comercial,string direccion,string fecha, string tip_contri , string ubigeo , string departamento, string provincia ,string distrito, string tip_doc)
        {

            objetoCD.Insertar(empresa, nom_comercial, direccion, fecha,  tip_contri, ubigeo,  departamento, provincia,  distrito,  tip_doc);
        }

        public void EditarEmpresa(string nombre, string desc, string marca, string precio, string stock,string id)
        {
            objetoCD.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock),Convert.ToInt32(id));
        }

        public void EliminarEmpresa(string id) {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
