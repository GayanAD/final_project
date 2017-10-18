namespace final_project
{
    partial class frm_invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dte = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_inv_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_soid = new System.Windows.Forms.ComboBox();
            this.txt_cfnme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cmnme = new System.Windows.Forms.TextBox();
            this.txt_clnme = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.txt_other = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.txt_disc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nettot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tpaid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_bal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.txt_clnme);
            this.groupBox2.Controls.Add(this.txt_cmnme);
            this.groupBox2.Controls.Add(this.txt_cfnme);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_soid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dte);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_inv_no);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.Olive;
            this.groupBox2.Location = new System.Drawing.Point(23, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 205);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Details";
            // 
            // dte
            // 
            this.dte.Location = new System.Drawing.Point(447, 36);
            this.dte.MinimumSize = new System.Drawing.Size(0, 29);
            this.dte.Name = "dte";
            this.dte.Size = new System.Drawing.Size(282, 29);
            this.dte.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(335, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Invoice Date";
            // 
            // txt_inv_no
            // 
            this.txt_inv_no.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_inv_no.Location = new System.Drawing.Point(139, 43);
            this.txt_inv_no.Name = "txt_inv_no";
            this.txt_inv_no.Size = new System.Drawing.Size(168, 20);
            this.txt_inv_no.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Invoice No";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(16, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sales Order ID";
            // 
            // cmb_soid
            // 
            this.cmb_soid.FormattingEnabled = true;
            this.cmb_soid.Location = new System.Drawing.Point(139, 91);
            this.cmb_soid.Name = "cmb_soid";
            this.cmb_soid.Size = new System.Drawing.Size(168, 21);
            this.cmb_soid.TabIndex = 24;
            // 
            // txt_cfnme
            // 
            this.txt_cfnme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cfnme.Location = new System.Drawing.Point(139, 146);
            this.txt_cfnme.Name = "txt_cfnme";
            this.txt_cfnme.Size = new System.Drawing.Size(168, 20);
            this.txt_cfnme.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(16, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Customer Name";
            // 
            // txt_cmnme
            // 
            this.txt_cmnme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cmnme.Location = new System.Drawing.Point(338, 146);
            this.txt_cmnme.Name = "txt_cmnme";
            this.txt_cmnme.Size = new System.Drawing.Size(168, 20);
            this.txt_cmnme.TabIndex = 27;
            // 
            // txt_clnme
            // 
            this.txt_clnme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_clnme.Location = new System.Drawing.Point(561, 146);
            this.txt_clnme.Name = "txt_clnme";
            this.txt_clnme.Size = new System.Drawing.Size(168, 20);
            this.txt_clnme.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.metroGrid1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.Olive;
            this.groupBox3.Location = new System.Drawing.Point(23, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(797, 175);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Manage";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.Olive;
            this.metroGrid1.Location = new System.Drawing.Point(19, 47);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(736, 95);
            this.metroGrid1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.txt_bal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_tpaid);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_nettot);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.domainUpDown2);
            this.groupBox1.Controls.Add(this.txt_disc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_other);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.domainUpDown1);
            this.groupBox1.Controls.Add(this.txt_tax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_stot);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.Olive;
            this.groupBox1.Location = new System.Drawing.Point(832, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 400);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tax";
            // 
            // txt_stot
            // 
            this.txt_stot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_stot.Location = new System.Drawing.Point(165, 47);
            this.txt_stot.Name = "txt_stot";
            this.txt_stot.Size = new System.Drawing.Size(182, 20);
            this.txt_stot.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(15, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sub Total";
            // 
            // txt_tax
            // 
            this.txt_tax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tax.Location = new System.Drawing.Point(165, 94);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(182, 20);
            this.txt_tax.TabIndex = 18;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(87, 91);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(50, 20);
            this.domainUpDown1.TabIndex = 19;
            // 
            // txt_other
            // 
            this.txt_other.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_other.Location = new System.Drawing.Point(165, 148);
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(182, 20);
            this.txt_other.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(15, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Other";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(87, 198);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(50, 20);
            this.domainUpDown2.TabIndex = 24;
            // 
            // txt_disc
            // 
            this.txt_disc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_disc.Location = new System.Drawing.Point(165, 201);
            this.txt_disc.Name = "txt_disc";
            this.txt_disc.Size = new System.Drawing.Size(182, 20);
            this.txt_disc.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(15, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Discount";
            // 
            // txt_nettot
            // 
            this.txt_nettot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nettot.Location = new System.Drawing.Point(165, 250);
            this.txt_nettot.Name = "txt_nettot";
            this.txt_nettot.Size = new System.Drawing.Size(182, 20);
            this.txt_nettot.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(15, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Net Total";
            // 
            // txt_tpaid
            // 
            this.txt_tpaid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tpaid.Location = new System.Drawing.Point(165, 297);
            this.txt_tpaid.Name = "txt_tpaid";
            this.txt_tpaid.Size = new System.Drawing.Size(182, 20);
            this.txt_tpaid.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.ForeColor = System.Drawing.Color.Olive;
            this.label10.Location = new System.Drawing.Point(15, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Total Paid";
            // 
            // txt_bal
            // 
            this.txt_bal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_bal.Location = new System.Drawing.Point(165, 349);
            this.txt_bal.Name = "txt_bal";
            this.txt_bal.Size = new System.Drawing.Size(182, 20);
            this.txt_bal.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(15, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Balance";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.btn_print);
            this.groupBox4.Controls.Add(this.btn_exit);
            this.groupBox4.Controls.Add(this.btn_delete);
            this.groupBox4.Controls.Add(this.btn_clr);
            this.groupBox4.Controls.Add(this.btn_add);
            this.groupBox4.Controls.Add(this.btn_update);
            this.groupBox4.ForeColor = System.Drawing.Color.Olive;
            this.groupBox4.Location = new System.Drawing.Point(23, 490);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1209, 78);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action";
            // 
            // btn_clr
            // 
            this.btn_clr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_clr.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr.ForeColor = System.Drawing.Color.White;
            this.btn_clr.Location = new System.Drawing.Point(461, 30);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(73, 23);
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
            this.btn_exit.Location = new System.Drawing.Point(578, 30);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(71, 24);
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
            this.btn_delete.Location = new System.Drawing.Point(236, 31);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(71, 23);
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
            this.btn_update.Location = new System.Drawing.Point(121, 31);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(73, 23);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(19, 31);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 23);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(351, 30);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(71, 23);
            this.btn_print.TabIndex = 29;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // frm_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 591);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_invoice";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Invoice";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_invoice_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_inv_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_clnme;
        private System.Windows.Forms.TextBox txt_cmnme;
        private System.Windows.Forms.TextBox txt_cfnme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_soid;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_bal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tpaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nettot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.TextBox txt_disc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_other;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_print;
    }
}