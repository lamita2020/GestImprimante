namespace GestionImprimante
{
    partial class Copie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Copie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateCop = new System.Windows.Forms.DateTimePicker();
            this.TypeCop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MAtemp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.Idimp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.CopDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Iddep = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NBTCop = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NomCop = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDCop = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(948, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DateCop);
            this.panel1.Controls.Add(this.TypeCop);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.MAtemp);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Idimp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CopDGV);
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.Iddep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NBTCop);
            this.panel1.Controls.Add(this.NomCop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IDCop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 307);
            this.panel1.TabIndex = 15;
            // 
            // DateCop
            // 
            this.DateCop.CalendarFont = new System.Drawing.Font("Mongolian Baiti", 11.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCop.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateCop.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateCop.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.DateCop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateCop.Location = new System.Drawing.Point(160, 213);
            this.DateCop.Name = "DateCop";
            this.DateCop.Size = new System.Drawing.Size(112, 26);
            this.DateCop.TabIndex = 18;
            this.DateCop.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TypeCop
            // 
            this.TypeCop.FormattingEnabled = true;
            this.TypeCop.Items.AddRange(new object[] {
            "NEB",
            "CL"});
            this.TypeCop.Location = new System.Drawing.Point(8, 90);
            this.TypeCop.Name = "TypeCop";
            this.TypeCop.Size = new System.Drawing.Size(112, 21);
            this.TypeCop.TabIndex = 18;
            this.TypeCop.SelectedIndexChanged += new System.EventHandler(this.TypeCop_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(163, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Date Copie";
            // 
            // MAtemp
            // 
            this.MAtemp.BackColor = System.Drawing.Color.White;
            this.MAtemp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MAtemp.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAtemp.ForeColor = System.Drawing.Color.DimGray;
            this.MAtemp.HintForeColor = System.Drawing.Color.Empty;
            this.MAtemp.HintText = "";
            this.MAtemp.isPassword = false;
            this.MAtemp.LineFocusedColor = System.Drawing.Color.Blue;
            this.MAtemp.LineIdleColor = System.Drawing.Color.DimGray;
            this.MAtemp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MAtemp.LineThickness = 3;
            this.MAtemp.Location = new System.Drawing.Point(9, 213);
            this.MAtemp.Margin = new System.Windows.Forms.Padding(4);
            this.MAtemp.Name = "MAtemp";
            this.MAtemp.Size = new System.Drawing.Size(114, 24);
            this.MAtemp.TabIndex = 23;
            this.MAtemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(8, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Matricule Employer";
            // 
            // Idimp
            // 
            this.Idimp.BackColor = System.Drawing.Color.White;
            this.Idimp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Idimp.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idimp.ForeColor = System.Drawing.Color.DimGray;
            this.Idimp.HintForeColor = System.Drawing.Color.Empty;
            this.Idimp.HintText = "";
            this.Idimp.isPassword = false;
            this.Idimp.LineFocusedColor = System.Drawing.Color.Blue;
            this.Idimp.LineIdleColor = System.Drawing.Color.DimGray;
            this.Idimp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Idimp.LineThickness = 3;
            this.Idimp.Location = new System.Drawing.Point(159, 155);
            this.Idimp.Margin = new System.Windows.Forms.Padding(4);
            this.Idimp.Name = "Idimp";
            this.Idimp.Size = new System.Drawing.Size(112, 24);
            this.Idimp.TabIndex = 21;
            this.Idimp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(163, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID Imprimante";
            // 
            // CopDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CopDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CopDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CopDGV.BackgroundColor = System.Drawing.Color.White;
            this.CopDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CopDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CopDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CopDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CopDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CopDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.CopDGV.EnableHeadersVisualStyles = false;
            this.CopDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CopDGV.Location = new System.Drawing.Point(335, 3);
            this.CopDGV.Name = "CopDGV";
            this.CopDGV.RowHeadersVisible = false;
            this.CopDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CopDGV.Size = new System.Drawing.Size(636, 304);
            this.CopDGV.TabIndex = 19;
            this.CopDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CopDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CopDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CopDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CopDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CopDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CopDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CopDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CopDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.CopDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CopDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CopDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CopDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.CopDGV.ThemeStyle.ReadOnly = false;
            this.CopDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CopDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CopDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CopDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CopDGV.ThemeStyle.RowsStyle.Height = 22;
            this.CopDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.CopDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CopDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CopDGV_CellContentClick);
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(117, 239);
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
            this.bunifuThinButton23.Location = new System.Drawing.Point(201, 239);
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
            this.bunifuThinButton22.Location = new System.Drawing.Point(117, 269);
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(31, 239);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(63, 35);
            this.bunifuThinButton21.TabIndex = 15;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Iddep
            // 
            this.Iddep.BackColor = System.Drawing.Color.White;
            this.Iddep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Iddep.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iddep.ForeColor = System.Drawing.Color.DimGray;
            this.Iddep.HintForeColor = System.Drawing.Color.Empty;
            this.Iddep.HintText = "";
            this.Iddep.isPassword = false;
            this.Iddep.LineFocusedColor = System.Drawing.Color.Blue;
            this.Iddep.LineIdleColor = System.Drawing.Color.DimGray;
            this.Iddep.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Iddep.LineThickness = 3;
            this.Iddep.Location = new System.Drawing.Point(9, 155);
            this.Iddep.Margin = new System.Windows.Forms.Padding(4);
            this.Iddep.Name = "Iddep";
            this.Iddep.Size = new System.Drawing.Size(114, 24);
            this.Iddep.TabIndex = 14;
            this.Iddep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(8, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID departement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(163, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "NBT Copie";
            // 
            // NBTCop
            // 
            this.NBTCop.BackColor = System.Drawing.Color.White;
            this.NBTCop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NBTCop.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBTCop.ForeColor = System.Drawing.Color.DimGray;
            this.NBTCop.HintForeColor = System.Drawing.Color.Empty;
            this.NBTCop.HintText = "";
            this.NBTCop.isPassword = false;
            this.NBTCop.LineFocusedColor = System.Drawing.Color.Blue;
            this.NBTCop.LineIdleColor = System.Drawing.Color.DimGray;
            this.NBTCop.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NBTCop.LineThickness = 3;
            this.NBTCop.Location = new System.Drawing.Point(159, 91);
            this.NBTCop.Margin = new System.Windows.Forms.Padding(4);
            this.NBTCop.Name = "NBTCop";
            this.NBTCop.Size = new System.Drawing.Size(112, 24);
            this.NBTCop.TabIndex = 11;
            this.NBTCop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NomCop
            // 
            this.NomCop.BackColor = System.Drawing.Color.White;
            this.NomCop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NomCop.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomCop.ForeColor = System.Drawing.Color.DimGray;
            this.NomCop.HintForeColor = System.Drawing.Color.Empty;
            this.NomCop.HintText = "";
            this.NomCop.isPassword = false;
            this.NomCop.LineFocusedColor = System.Drawing.Color.Blue;
            this.NomCop.LineIdleColor = System.Drawing.Color.DimGray;
            this.NomCop.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NomCop.LineThickness = 3;
            this.NomCop.Location = new System.Drawing.Point(161, 33);
            this.NomCop.Margin = new System.Windows.Forms.Padding(4);
            this.NomCop.Name = "NomCop";
            this.NomCop.Size = new System.Drawing.Size(112, 24);
            this.NomCop.TabIndex = 9;
            this.NomCop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(164, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nom Copie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type Copie";
            // 
            // IDCop
            // 
            this.IDCop.BackColor = System.Drawing.Color.White;
            this.IDCop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDCop.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCop.ForeColor = System.Drawing.Color.DimGray;
            this.IDCop.HintForeColor = System.Drawing.Color.Empty;
            this.IDCop.HintText = "";
            this.IDCop.isPassword = false;
            this.IDCop.LineFocusedColor = System.Drawing.Color.Blue;
            this.IDCop.LineIdleColor = System.Drawing.Color.DimGray;
            this.IDCop.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.IDCop.LineThickness = 3;
            this.IDCop.Location = new System.Drawing.Point(11, 33);
            this.IDCop.Margin = new System.Windows.Forms.Padding(4);
            this.IDCop.Name = "IDCop";
            this.IDCop.Size = new System.Drawing.Size(112, 24);
            this.IDCop.TabIndex = 6;
            this.IDCop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Copie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Copie";
            // 
            // Copie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(970, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Copie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copie";
            this.Load += new System.EventHandler(this.Copie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Idimp;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaDataGridView CopDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Iddep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NBTCop;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NomCop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IDCop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MAtemp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DateCop;
        private System.Windows.Forms.ComboBox TypeCop;
    }
}