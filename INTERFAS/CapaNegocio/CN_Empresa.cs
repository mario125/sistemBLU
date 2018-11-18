using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaData;
using System.Data.Odbc;
using System.Data;
using Npgsql;
namespace capaNegocio
{
    public class CN_Empresa
    {
        
        private CD_Empresa objData = new CD_Empresa();
        private string _ruc;
        private string _rmpresa;
        private string _direccion;
        private string _fecha;
        private string _nombre_comercial;
        private string _tipo_contributente;
        private int    _ibigeo;
        private string _;
        private string _;
        private string _;
        private string _;
        private string _;
        private string _;
        
        

        public string Usuario
        {
            set { _usuari = value; }
            get { return _usuario; }
        }
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        // constructor
        public CN_Empresa() { }
        public NpgsqlDataReader insert()
        {
            NpgsqlDataReader loguin;
            loguin = objData.Select(Usuario,Password);
            return loguin;
        }


    }
}
