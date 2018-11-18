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
        private string _ruc                 ;
        private string _empresa             ;
        private string _direccion           ;
        private DateTime _fecha               ;
        private string _nombre_comercial    ;
        private string _tipo_contribuyente  ;
        private int    _ubigeo              ;
        private string _departamento        ;
        private string _provincia           ;
        private string _distrito            ;
        private int    _tipo_documento      ;
        public string d_ruc
        {
            set { _ruc = value; }
            get { return _ruc; }
        }
        public string d_empresa
        {
            set { _empresa = value; }
            get { return _empresa; }
        }
        public string d_direccion
        {
            set { _direccion = value; }
            get { return _direccion; }
        }
        public DateTime d_fecha
        {
            set { _fecha = value; }
            get { return _fecha; }
        }
        public string d_nombre_comercial
        {
            set { _nombre_comercial = value; }
            get { return _nombre_comercial; }
        }
        public string d_tipo_contribuyente
        {
            set { _tipo_contribuyente = value; }
            get { return _tipo_contribuyente; }
        }
        public int d_ubigeo
        {
            set { _ubigeo = value; }
            get { return _ubigeo; }
        }
        public string d_departamento
        {
            set { _departamento = value; }
            get { return _departamento; }
        }
        public string d_provincia
        {
            set { _provincia = value; }
            get { return _provincia; }
        }
        public string d_distrito
        {
            set { _distrito = value; }
            get { return _distrito; }
        }
        public int d_tipo_documento
        {
            set { _tipo_documento = value; }
            get { return _tipo_documento; }

        }
        

        public CN_Empresa() { }
        public NpgsqlDataReader insert()
        {
            NpgsqlDataReader insertar;
            insertar = objData.Select(_ruc,_empresa,_direccion,_fecha,_nombre_comercial,_tipo_contribuyente,_ubigeo,_departamento,_provincia,_distrito,_tipo_documento);
            return insertar;
        }


    }
}
