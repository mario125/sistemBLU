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
            empresa.Usuario = "mmmm";// textBox1.Text;
            empresa.Password = "mmmm";//textBox2.Text;
            loguear = empresa.insert();
            string dato = "";
            while (loguear.Read())
            {
                dato = "" + loguear[0];
            }

            if (dato == "1")
            {


                MessageBox.Show("todo correcto");
            }
            else
                MessageBox.Show("error...!!");
        }
    }
}
