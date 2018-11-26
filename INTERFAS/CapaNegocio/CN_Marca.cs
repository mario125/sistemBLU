using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaData;

namespace capaNegocio
{
    
    public class CN_Marca
    {
        private CD_Marca objData = new CD_Marca();
        private string _nombre;
        private string _id;
        public CN_Marca()
        {

        }
        public NpgsqlDataReader select()
        {
            NpgsqlDataReader insertar;
            insertar = objData.select();
            return insertar;
        }
        public NpgsqlDataReader create()
        {
            NpgsqlDataReader insertar;
            insertar = objData.create(_nombre);
            return insertar;
        }
        public NpgsqlDataReader update()
        {
            NpgsqlDataReader insertar;
            insertar = objData.update(_id,_nombre);
            return insertar;
        }
        public NpgsqlDataReader delete()
        {
            NpgsqlDataReader insertar;
            insertar = objData.delete(_id);
            return insertar;
        }
        public string d_nombre
        {
            set { _nombre = value; }
            get { return _nombre; }

        }

        public string d_id
        {
            set { _id = value; }
            get { return _id; }

        }


    }
}
