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

 



namespace INTERFAS
{
    public partial class Dialog_Error : Form 
    {
       
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
    }
}
