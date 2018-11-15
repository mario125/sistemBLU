using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using IronPdf;
using System.Text;
//using Npgsql;
using System.Data.Odbc;
using System.Data;
using CapaNegocio;



namespace INTERFAS
{
    public partial class PANEL : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        CN_Empresa empresa = new CN_Empresa();
        public PANEL()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            LOGIN l = new LOGIN();
            l.Color_form(2);
            //materialRaisedButton1.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            Dialog_Error E = new Dialog_Error();
            E.ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //tabPage6.ScrollControlIntoView ;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            empresa.InsertarEmpresa();
            
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=oyQcwbvKxdk
        }
    }
}
