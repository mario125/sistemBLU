using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using IronPdf;
using System.Data.Odbc;



namespace INTERFAS
{
    public partial class LOGIN : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public LOGIN()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;            
            Color_form(2);

        }
        public void Color_form(int id)
        {
            switch (id)
            {
                case 0:
                    // materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Yellow200, Accent.Yellow700 , TextShade.BLACK);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Amber400 , Accent.Pink200, TextShade.WHITE);
                                        //materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            PANEL.PANEL p = new PANEL.PANEL();
            this.Hide();
            p.ShowDialog();
            //Dialog_Error fm = new Dialog_Error();
            //this.Hide();
            //fm.ShowDialog();
            this.Close();
        }
    }
}
