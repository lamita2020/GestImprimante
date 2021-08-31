namespace GestionImprimante
{
    partial class departement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(departement));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DepDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CoutDep = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NBTCopieDep = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NBTEmpDep = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NomDep = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDDep = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idimp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "departement";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.idimp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.DepDGV);
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.CoutDep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NBTCopieDep);
            this.panel1.Controls.Add(this.NBTEmpDep);
            this.panel1.Controls.Add(this.NomDep);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IDDep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 296);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DepDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DepDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DepDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepDGV.BackgroundColor = System.Drawing.Color.White;
            this.DepDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DepDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DepDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DepDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DepDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DepDGV.EnableHeadersVisualStyles = false;
            this.DepDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DepDGV.Location = new System.Drawing.Point(332, 3);
            this.DepDGV.Name = "DepDGV";
            this.DepDGV.RowHeadersVisible = false;
            this.DepDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepDGV.Size = new System.Drawing.Size(636, 278);
            this.DepDGV.TabIndex = 19;
            this.DepDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DepDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DepDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DepDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DepDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DepDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DepDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DepDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DepDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.DepDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DepDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DepDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DepDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.DepDGV.ThemeStyle.ReadOnly = false;
            this.DepDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DepDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DepDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DepDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DepDGV.ThemeStyle.RowsStyle.Height = 22;
            this.DepDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DepDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DepDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepDGV_CellContentClick_1);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Edit";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Gray;
            this.bunifuThinButton24.Location = new System.Drawing.Point(117, 216);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(58, 35);
            this.bunifuThinButton24.TabIndex = 18;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Delete";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Gray;
            this.bunifuThinButton23.Location = new System.Drawing.Point(201, 216);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(83, 35);
            this.bunifuThinButton23.TabIndex = 17;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Home";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Gray;
            this.bunifuThinButton22.Location = new System.Drawing.Point(117, 246);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(59, 35);
            this.bunifuThinButton22.TabIndex = 16;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Add";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(31, 216);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(63, 35);
            this.bunifuThinButton21.TabIndex = 15;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // CoutDep
            // 
            this.CoutDep.BackColor = System.Drawing.Color.White;
            this.CoutDep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CoutDep.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoutDep.ForeColor = System.Drawing.Color.DimGray;
            this.CoutDep.HintForeColor = System.Drawing.Color.Empty;
            this.CoutDep.HintText = "";
            this.CoutDep.isPassword = false;
            this.CoutDep.LineFocusedColor = System.Drawing.Color.Blue;
            this.CoutDep.LineIdleColor = System.Drawing.Color.DimGray;
            this.CoutDep.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CoutDep.LineThickness = 3;
            this.CoutDep.Location = new System.Drawing.Point(31, 183);
            this.CoutDep.Margin = new System.Windows.Forms.Padding(4);
            this.CoutDep.Name = "CoutDep";
            this.CoutDep.Size = new System.Drawing.Size(112, 24);
            this.CoutDep.TabIndex = 14;
            this.CoutDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CoutDep.OnValueChanged += new System.EventHandler(this.CoutDep_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(28, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cout dep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(187, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "NBT Copie Dep";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NBTCopieDep
            // 
            this.NBTCopieDep.BackColor = System.Drawing.Color.White;
            this.NBTCopieDep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NBTCopieDep.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBTCopieDep.ForeColor = System.Drawing.Color.DimGray;
            this.NBTCopieDep.HintForeColor = System.Drawing.Color.Empty;
            this.NBTCopieDep.HintText = "";
            this.NBTCopieDep.isPassword = false;
            this.NBTCopieDep.LineFocusedColor = System.Drawing.Color.Blue;
            this.NBTCopieDep.LineIdleColor = System.Drawing.Color.DimGray;
            this.NBTCopieDep.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NBTCopieDep.LineThickness = 3;
            this.NBTCopieDep.Location = new System.Drawing.Point(189, 118);
            this.NBTCopieDep.Margin = new System.Windows.Forms.Padding(4);
            this.NBTCopieDep.Name = "NBTCopieDep";
            this.NBTCopieDep.Size = new System.Drawing.Size(112, 24);
            this.NBTCopieDep.TabIndex = 11;
            this.NBTCopieDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NBTCopieDep.OnValueChanged += new System.EventHandler(this.NBTCopieDep_OnValueChanged);
            // 
            // NBTEmpDep
            // 
            this.NBTEmpDep.BackColor = System.Drawing.Color.White;
            this.NBTEmpDep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NBTEmpDep.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBTEmpDep.ForeColor = System.Drawing.Color.DimGray;
            this.NBTEmpDep.HintForeColor = System.Drawing.Color.Empty;
            this.NBTEmpDep.HintText = "";
            this.NBTEmpDep.isPassword = false;
            this.NBTEmpDep.LineFocusedColor = System.Drawing.Color.Blue;
            this.NBTEmpDep.LineIdleColor = System.Drawing.Color.DimGray;
            this.NBTEmpDep.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NBTEmpDep.LineThickness = 3;
            this.NBTEmpDep.Location = new System.Drawing.Point(31, 118);
            this.NBTEmpDep.Margin = new System.Windows.Forms.Padding(4);
            this.NBTEmpDep.Name = "NBTEmpDep";
            this.NBTEmpDep.Size = new System.Drawing.Size(118, 24);
            this.NBTEmpDep.TabIndex = 10;
            this.NBTEmpDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NomDep
            // 
            this.NomDep.BackColor = System.Drawing.Color.White;
            this.NomDep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NomDep.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomDep.ForeColor = System.Drawing.Color.DimGray;
            this.NomDep.HintForeColor = System.Drawing.Color.Empty;
            this.NomDep.HintText = "";
            this.NomDep.isPassword = false;
            this.NomDep.LineFocusedColor = System.Drawing.Color.Blue;
            this.NomDep.LineIdleColor = System.Drawing.Color.DimGray;
            this.NomDep.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NomDep.LineThickness = 3;
            this.NomDep.Location = new System.Drawing.Point(189, 56);
            this.NomDep.Margin = new System.Windows.Forms.Padding(4);
            this.NomDep.Name = "NomDep";
            this.NomDep.Size = new System.Drawing.Size(112, 24);
            this.NomDep.TabIndex = 9;
            this.NomDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(187, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nom departement";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "NBT Emp Dep";
            // 
            // IDDep
            // 
            this.IDDep.BackColor = System.Drawing.Color.White;
            this.IDDep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDDep.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDDep.ForeColor = System.Drawing.Color.DimGray;
            this.IDDep.HintForeColor = System.Drawing.Color.Empty;
            this.IDDep.HintText = "";
            this.IDDep.isPassword = false;
            this.IDDep.LineFocusedColor = System.Drawing.Color.Blue;
            this.IDDep.LineIdleColor = System.Drawing.Color.DimGray;
            this.IDDep.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.IDDep.LineThickness = 3;
            this.IDDep.Location = new System.Drawing.Point(31, 56);
            this.IDDep.Margin = new System.Windows.Forms.Padding(4);
            this.IDDep.Name = "IDDep";
            this.IDDep.Size = new System.Drawing.Size(112, 24);
            this.IDDep.TabIndex = 6;
            this.IDDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID departement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(949, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idimp
            // 
            this.idimp.BackColor = System.Drawing.Color.White;
            this.idimp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idimp.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idimp.ForeColor = System.Drawing.Color.DimGray;
            this.idimp.HintForeColor = System.Drawing.Color.Empty;
            this.idimp.HintText = "";
            this.idimp.isPassword = false;
            this.idimp.LineFocusedColor = System.Drawing.Color.Blue;
            this.idimp.LineIdleColor = System.Drawing.Color.DimGray;
            this.idimp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.idimp.LineThickness = 3;
            this.idimp.Location = new System.Drawing.Point(190, 183);
            this.idimp.Margin = new System.Windows.Forms.Padding(4);
            this.idimp.Name = "idimp";
            this.idimp.Size = new System.Drawing.Size(112, 24);
            this.idimp.TabIndex = 21;
            this.idimp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(187, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID Imprimante";
            // 
            // departement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(970, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "departement";
            this.Text = "departement";
            this.Load += new System.EventHandler(this.departement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IDDep;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NBTCopieDep;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NBTEmpDep;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NomDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CoutDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView DepDGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idimp;
        private System.Windows.Forms.Label label8;
    }
}