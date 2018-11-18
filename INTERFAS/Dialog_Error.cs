using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using capaNegocio;
namespace INTERFAS
{
    public partial class Dialog_Error : Form 
    {
        CN_Empresa empresa = new CN_Empresa();
        public Dialog_Error()
        {
            InitializeComponent();         
            
        }

        private void Dialog_Error_Load(object sender, EventArgs e)
        {

        }

        private void elementClose1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("holas");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // objLog = new ClassNLogin();
            NpgsqlDataReader loguear;
            empresa.d_ruc = "primera";
            empresa.d_empresa = "primera";
            empresa.d_direccion = "primera";
            string dat = "10/10/2018";
            
            DateTime d2 = Convert.ToDateTime(dat);
            DateTime value = d2;
            empresa.d_fecha = value;           
            empresa.d_nombre_comercial = "primera";
            empresa.d_tipo_contribuyente = "primera";
            empresa.d_ubigeo = 101;
            empresa.d_departamento = "primera";
            empresa.d_provincia = "primera";
            empresa.d_distrito = "primera";
            empresa.d_tipo_documento = 1;
            loguear = empresa.insert();
            string dato = "";
            while (loguear.Read())
            {
                dato = "" + loguear[0];
            }

            if (dato != "")
            {


                MessageBox.Show("todo correcto:"+dato);
            }
            else
                MessageBox.Show("error...!!");
        }
    }
}
