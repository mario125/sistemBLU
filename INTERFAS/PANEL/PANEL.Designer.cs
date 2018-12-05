namespace INTERFAS.PANEL
{
    partial class PANEL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTalk_TabControl1 = new iTalk_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_proceso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.GroupBox();
            this.b_actualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.b_regis = new MaterialSkin.Controls.MaterialRaisedButton();
            this.t_m_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iTalk_Label1 = new iTalk_Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1.SuspendLayout();
            this.iTalk_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DATA.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.Image = global::INTERFAS.Properties.Resources.edit;
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click_1);
            // 
            // eLIMINARToolStripMenuItem
            // 
            this.eLIMINARToolStripMenuItem.Image = global::INTERFAS.Properties.Resources.delete;
            this.eLIMINARToolStripMenuItem.Name = "eLIMINARToolStripMenuItem";
            this.eLIMINARToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.eLIMINARToolStripMenuItem.Text = "ELIMINAR";
            // 
            // iTalk_TabControl1
            // 
            this.iTalk_TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.iTalk_TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iTalk_TabControl1.Controls.Add(this.tabPage1);
            this.iTalk_TabControl1.Controls.Add(this.tabPage2);
            this.iTalk_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.iTalk_TabControl1.ItemSize = new System.Drawing.Size(44, 135);
            this.iTalk_TabControl1.Location = new System.Drawing.Point(-1, 64);
            this.iTalk_TabControl1.Multiline = true;
            this.iTalk_TabControl1.Name = "iTalk_TabControl1";
            this.iTalk_TabControl1.SelectedIndex = 0;
            this.iTalk_TabControl1.Size = new System.Drawing.Size(919, 388);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PRODUCTO";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 380);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(769, 354);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "PRODUCTO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField2.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "USUARIO";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(30, 86);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(178, 23);
            this.materialSingleLineTextField2.TabIndex = 2;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            this.materialSingleLineTextField2.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(769, 354);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "CATEGORIA";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(769, 354);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "UNIDAD";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(769, 354);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "MARCA";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.l_proceso);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.DATA);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 357);
            this.panel2.TabIndex = 0;
            // 
            // l_proceso
            // 
            this.l_proceso.AutoSize = true;
            this.l_proceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.l_proceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.l_proceso.Location = new System.Drawing.Point(566, 56);
            this.l_proceso.Name = "l_proceso";
            this.l_proceso.Size = new System.Drawing.Size(46, 18);
            this.l_proceso.TabIndex = 12;
            this.l_proceso.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::INTERFAS.Properties.Resources.proces1;
            this.pictureBox1.Image = global::INTERFAS.Properties.Resources.proces1;
            this.pictureBox1.InitialImage = global::INTERFAS.Properties.Resources.proces;
            this.pictureBox1.Location = new System.Drawing.Point(524, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 19;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NRO,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Azure;
            this.dataGridView1.Location = new System.Drawing.Point(38, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(698, 176);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // NRO
            // 
            this.NRO.HeaderText = "ID";
            this.NRO.Name = "NRO";
            this.NRO.Width = 42;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 600F;
            this.Column1.HeaderText = "NOMBRE";
            this.Column1.Name = "Column1";
            this.Column1.Width = 84;
            // 
            // DATA
            // 
            this.DATA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DATA.Controls.Add(this.b_actualizar);
            this.DATA.Controls.Add(this.b_regis);
            this.DATA.Controls.Add(this.t_m_nombre);
            this.DATA.Controls.Add(this.iTalk_Label1);
            this.DATA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DATA.Location = new System.Drawing.Point(38, 22);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(484, 132);
            this.DATA.TabIndex = 6;
            this.DATA.TabStop = false;
            // 
            // b_actualizar
            // 
            this.b_actualizar.AutoSize = true;
            this.b_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_actualizar.Depth = 0;
            this.b_actualizar.Enabled = false;
            this.b_actualizar.Icon = null;
            this.b_actualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b_actualizar.Location = new System.Drawing.Point(213, 90);
            this.b_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.b_actualizar.Name = "b_actualizar";
            this.b_actualizar.Primary = true;
            this.b_actualizar.Size = new System.Drawing.Size(103, 36);
            this.b_actualizar.TabIndex = 7;
            this.b_actualizar.Text = "ACTUALIZAR";
            this.b_actualizar.UseVisualStyleBackColor = true;
            this.b_actualizar.Click += new System.EventHandler(this.materialRaisedButton2_Click_1);
            // 
            // b_regis
            // 
            this.b_regis.AutoSize = true;
            this.b_regis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_regis.Depth = 0;
            this.b_regis.Icon = null;
            this.b_regis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b_regis.Location = new System.Drawing.Point(92, 90);
            this.b_regis.MouseState = MaterialSkin.MouseState.HOVER;
            this.b_regis.Name = "b_regis";
            this.b_regis.Primary = true;
            this.b_regis.Size = new System.Drawing.Size(93, 36);
            this.b_regis.TabIndex = 6;
            this.b_regis.Text = "REGISTRAR";
            this.b_regis.UseVisualStyleBackColor = true;
            this.b_regis.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // t_m_nombre
            // 
            this.t_m_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_m_nombre.BackColor = System.Drawing.Color.White;
            this.t_m_nombre.Depth = 0;
            this.t_m_nombre.Hint = "";
            this.t_m_nombre.Location = new System.Drawing.Point(92, 22);
            this.t_m_nombre.MaxLength = 32767;
            this.t_m_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_m_nombre.Name = "t_m_nombre";
            this.t_m_nombre.PasswordChar = '\0';
            this.t_m_nombre.SelectedText = "";
            this.t_m_nombre.SelectionLength = 0;
            this.t_m_nombre.SelectionStart = 0;
            this.t_m_nombre.Size = new System.Drawing.Size(386, 23);
            this.t_m_nombre.TabIndex = 3;
            this.t_m_nombre.TabStop = false;
            this.t_m_nombre.UseSystemPasswordChar = false;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(14, 27);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(79, 18);
            this.iTalk_Label1.TabIndex = 5;
            this.iTalk_Label1.Text = "NOMBRE:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.tabPage2.Location = new System.Drawing.Point(139, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // PANEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.iTalk_TabControl1);
            this.Name = "PANEL";
            this.Text = "PANEL";
            this.Load += new System.EventHandler(this.PANEL_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.iTalk_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DATA.ResumeLayout(false);
            this.DATA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private iTalk_Label iTalk_Label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_m_nombre;
        private System.Windows.Forms.GroupBox DATA;
        private MaterialSkin.Controls.MaterialRaisedButton b_regis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private MaterialSkin.Controls.MaterialRaisedButton b_actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_proceso;
    }
}