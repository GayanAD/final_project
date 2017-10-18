namespace final_project
{
    partial class frm_sales_order
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cid = new System.Windows.Forms.TextBox();
            this.cmb_fnme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dte2 = new MetroFramework.Controls.MetroDateTime();
            this.dte1 = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_oid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_dsno = new System.Windows.Forms.TextBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.cmb_color = new System.Windows.Forms.ComboBox();
            this.cmb_material = new System.Windows.Forms.ComboBox();
            this.cmb_cat = new System.Windows.Forms.ComboBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_itemno = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_cid);
            this.groupBox1.Controls.Add(this.cmb_fnme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Olive;
            this.groupBox1.Location = new System.Drawing.Point(23, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Customer ID";
            // 
            // txt_cid
            // 
            this.txt_cid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cid.Location = new System.Drawing.Point(168, 72);
            this.txt_cid.Name = "txt_cid";
            this.txt_cid.Size = new System.Drawing.Size(182, 20);
            this.txt_cid.TabIndex = 16;
            // 
            // cmb_fnme
            // 
            this.cmb_fnme.FormattingEnabled = true;
            this.cmb_fnme.Location = new System.Drawing.Point(168, 30);
            this.cmb_fnme.Name = "cmb_fnme";
            this.cmb_fnme.Size = new System.Drawing.Size(182, 21);
            this.cmb_fnme.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer FName";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.dte2);
            this.groupBox2.Controls.Add(this.dte1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_oid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.Olive;
            this.groupBox2.Location = new System.Drawing.Point(468, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 122);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Details";
            // 
            // dte2
            // 
            this.dte2.Location = new System.Drawing.Point(383, 34);
            this.dte2.MinimumSize = new System.Drawing.Size(0, 29);
            this.dte2.Name = "dte2";
            this.dte2.Size = new System.Drawing.Size(168, 29);
            this.dte2.TabIndex = 22;
            // 
            // dte1
            // 
            this.dte1.Location = new System.Drawing.Point(125, 71);
            this.dte1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dte1.Name = "dte1";
            this.dte1.Size = new System.Drawing.Size(168, 29);
            this.dte1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(309, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Order Supply Date";
            // 
            // txt_oid
            // 
            this.txt_oid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_oid.Location = new System.Drawing.Point(125, 31);
            this.txt_oid.Name = "txt_oid";
            this.txt_oid.Size = new System.Drawing.Size(168, 20);
            this.txt_oid.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Order ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.txt_dsno);
            this.groupBox3.Controls.Add(this.cmb_size);
            this.groupBox3.Controls.Add(this.cmb_color);
            this.groupBox3.Controls.Add(this.cmb_material);
            this.groupBox3.Controls.Add(this.cmb_cat);
            this.groupBox3.Controls.Add(this.metroGrid1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_qty);
            this.groupBox3.Controls.Add(this.txt_itemno);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.Olive;
            this.groupBox3.Location = new System.Drawing.Point(23, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(924, 320);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Manage";
            // 
            // txt_dsno
            // 
            this.txt_dsno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_dsno.Location = new System.Drawing.Point(709, 103);
            this.txt_dsno.Name = "txt_dsno";
            this.txt_dsno.Size = new System.Drawing.Size(171, 20);
            this.txt_dsno.TabIndex = 28;
            // 
            // cmb_size
            // 
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(709, 45);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(171, 21);
            this.cmb_size.TabIndex = 27;
            // 
            // cmb_color
            // 
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Location = new System.Drawing.Point(418, 93);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(171, 21);
            this.cmb_color.TabIndex = 26;
            // 
            // cmb_material
            // 
            this.cmb_material.FormattingEnabled = true;
            this.cmb_material.Location = new System.Drawing.Point(140, 93);
            this.cmb_material.Name = "cmb_material";
            this.cmb_material.Size = new System.Drawing.Size(171, 21);
            this.cmb_material.TabIndex = 18;
            // 
            // cmb_cat
            // 
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.Location = new System.Drawing.Point(418, 49);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(171, 21);
            this.cmb_cat.TabIndex = 18;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.Olive;
            this.metroGrid1.Location = new System.Drawing.Point(39, 194);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(841, 95);
            this.metroGrid1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(622, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Design No";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.ForeColor = System.Drawing.Color.Olive;
            this.label15.Location = new System.Drawing.Point(351, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Category";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(351, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Color";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(36, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Material";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(36, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.ForeColor = System.Drawing.Color.Olive;
            this.label12.Location = new System.Drawing.Point(622, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Size";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.ForeColor = System.Drawing.Color.Olive;
            this.label13.Location = new System.Drawing.Point(36, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.ForeColor = System.Drawing.Color.Olive;
            this.label14.Location = new System.Drawing.Point(36, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Item No";
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_qty.Location = new System.Drawing.Point(140, 141);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(171, 20);
            this.txt_qty.TabIndex = 6;
            // 
            // txt_itemno
            // 
            this.txt_itemno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_itemno.Location = new System.Drawing.Point(140, 52);
            this.txt_itemno.Name = "txt_itemno";
            this.txt_itemno.Size = new System.Drawing.Size(171, 20);
            this.txt_itemno.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(30, 43);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 23);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_srch_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.btn_clr);
            this.groupBox4.Controls.Add(this.btn_exit);
            this.groupBox4.Controls.Add(this.btn_delete);
            this.groupBox4.Controls.Add(this.btn_update);
            this.groupBox4.Controls.Add(this.btn_add);
            this.groupBox4.ForeColor = System.Drawing.Color.Olive;
            this.groupBox4.Location = new System.Drawing.Point(961, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 320);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action";
            // 
            // btn_clr
            // 
            this.btn_clr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_clr.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr.ForeColor = System.Drawing.Color.White;
            this.btn_clr.Location = new System.Drawing.Point(30, 194);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(63, 23);
            this.btn_clr.TabIndex = 28;
            this.btn_clr.Text = "CLEAR";
            this.btn_clr.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(32, 250);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(59, 28);
            this.btn_exit.TabIndex = 27;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(32, 149);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(59, 23);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(30, 94);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(63, 23);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // frm_sales_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 569);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_sales_order";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Sales Order";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_sales_order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_fnme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cid;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroDateTime dte1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_oid;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroDateTime dte2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_itemno;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_dsno;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.ComboBox cmb_color;
        private System.Windows.Forms.ComboBox cmb_material;
        private System.Windows.Forms.ComboBox cmb_cat;
    }
}