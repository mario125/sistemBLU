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
using Npgsql;
using capaNegocio;

namespace INTERFAS.PANEL
{
    public partial class PANEL : MaterialForm
    {
        private CN_Marca m = new CN_Marca();
        private string id;
        private string nombre;
        private NpgsqlDataReader listar;
        public PANEL()
        {
            InitializeComponent();
        }

        private void PANEL_Load(object sender, EventArgs e)
        {

            l_proceso.Text = "REGISTRAR";
            listar_marca();
            

        }
        public void listar_marca()
        {
            
            listar = m.select();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (listar.HasRows)
            {
                while (listar.Read())
                {
                    dataGridView1.Rows.Insert(0, (int)listar["_numero"], (String)listar["_n_marca"]);

                }
                listar.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            if (t_m_nombre.Text=="")
            {
                MessageBox.Show("faltan datos...!!");
            }
            else
            {
                m.d_nombre = t_m_nombre.Text;
                listar = m.create();
                while (listar.Read())
                {
                    MessageBox.Show("Marca " + listar[0] + " registrado.");
                    listar_marca();
                    t_m_nombre.Text = "";
                    listar.Close();
                }
            }            
            
            

          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (!(e.RowIndex > -1))
            {
                return;
            }
           

        }
        public void GetValorCelda(DataGridView dgv)
        {      

            id = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString();
            nombre = dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString();


        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
               
            }
            //string n = dataGridView1.GetFocusedRowCellValue("Id").ToString();
            //obtienes la fila seleccionada


            //int i = dataGridView1.CurrentRow.Index;
            // string Text = dataGridView1.Item(0, i).Value

            //foreach (DataGridViewRow fila in dataGridView1.Rows)
            //{
            //    if (Convert.ToBoolean(fila.Cells["ID"].Value) ==i)
            //    {
            //        //textBox1.Text = fila.Cells["Rut"].Value.ToString();
            //        MessageBox.Show(fila.Cells["NOMBRE"].Value.ToString());
            //    }
            //}
            //string text = string.Empty;
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{

            //        text += $@"{row.Cells["ID"].Value} - {row.Cells["NOMBRE"].Value} {Environment.NewLine}";

            //}
            //MessageBox.Show(text);

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void my_menu_Itemclicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GetValorCelda(dataGridView1);
            //t_m_nombre.Text = nombre;
            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EDIT");
        }

        private void materialRaisedButton2_Click_1(object sender, EventArgs e)
        {
            if (t_m_nombre.Text == "")
            {
                MessageBox.Show("faltan datos...!!");
            }
            else
            {
                m.d_id = id;
                m.d_nombre = t_m_nombre.Text;
                listar = m.update();
                while (listar.Read())
                {
                    MessageBox.Show("Marca " + listar[0] );
                    listar_marca();
                    t_m_nombre.Text = "";
                    b_actualizar.Enabled = false;
                    b_regis.Enabled = true;
                    listar.Close();
                    l_proceso.Text = "ACTUALIZADO";
                }
            }
        }

        private void eDITARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GetValorCelda(dataGridView1);
            t_m_nombre.Text = nombre;
            b_actualizar.Enabled = true;
            b_regis.Enabled = false;
            l_proceso.Text = "EDITANDO";
        }
    }
}
