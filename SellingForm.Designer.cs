
namespace Shop
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Qcheck = new System.Windows.Forms.Label();
            this.prodnameedit = new System.Windows.Forms.TextBox();
            this.totallb = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
            this.paid = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.qtyedit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prodidedit = new System.Windows.Forms.TextBox();
            this.activesale = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ptotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.sellername = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.categoryS = new System.Windows.Forms.ComboBox();
            this.prodList = new System.Windows.Forms.DataGridView();
            this.prodeditbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodname = new System.Windows.Forms.TextBox();
            this.proddelbtn = new System.Windows.Forms.Button();
            this.prodaddbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activesale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(1445, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 39);
            this.label5.TabIndex = 41;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.Qcheck);
            this.panel1.Controls.Add(this.prodnameedit);
            this.panel1.Controls.Add(this.totallb);
            this.panel1.Controls.Add(this.change);
            this.panel1.Controls.Add(this.done);
            this.panel1.Controls.Add(this.paid);
            this.panel1.Controls.Add(this.calculate);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.qtyedit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.prodidedit);
            this.panel1.Controls.Add(this.activesale);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.sellername);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.categoryS);
            this.panel1.Controls.Add(this.prodList);
            this.panel1.Controls.Add(this.prodeditbtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.prodname);
            this.panel1.Controls.Add(this.proddelbtn);
            this.panel1.Controls.Add(this.prodaddbtn);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 671);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Qcheck
            // 
            this.Qcheck.AutoSize = true;
            this.Qcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qcheck.ForeColor = System.Drawing.Color.Maroon;
            this.Qcheck.Location = new System.Drawing.Point(864, 30);
            this.Qcheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Qcheck.Name = "Qcheck";
            this.Qcheck.Size = new System.Drawing.Size(0, 25);
            this.Qcheck.TabIndex = 48;
            // 
            // prodnameedit
            // 
            this.prodnameedit.Enabled = false;
            this.prodnameedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodnameedit.Location = new System.Drawing.Point(653, 294);
            this.prodnameedit.Margin = new System.Windows.Forms.Padding(4);
            this.prodnameedit.Name = "prodnameedit";
            this.prodnameedit.Size = new System.Drawing.Size(151, 29);
            this.prodnameedit.TabIndex = 47;
            // 
            // totallb
            // 
            this.totallb.AutoSize = true;
            this.totallb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallb.ForeColor = System.Drawing.Color.Transparent;
            this.totallb.Location = new System.Drawing.Point(915, 478);
            this.totallb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totallb.Name = "totallb";
            this.totallb.Size = new System.Drawing.Size(61, 25);
            this.totallb.TabIndex = 46;
            this.totallb.Text = "Total";
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.ForeColor = System.Drawing.Color.Transparent;
            this.change.Location = new System.Drawing.Point(915, 576);
            this.change.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(88, 25);
            this.change.TabIndex = 45;
            this.change.Text = "Change";
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.White;
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.Location = new System.Drawing.Point(929, 620);
            this.done.Margin = new System.Windows.Forms.Padding(4);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(107, 41);
            this.done.TabIndex = 44;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // paid
            // 
            this.paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid.Location = new System.Drawing.Point(915, 522);
            this.paid.Margin = new System.Windows.Forms.Padding(4);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(151, 29);
            this.paid.TabIndex = 41;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.White;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(1097, 522);
            this.calculate.Margin = new System.Windows.Forms.Padding(4);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(107, 30);
            this.calculate.TabIndex = 40;
            this.calculate.Text = "Calc";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(809, 576);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 25);
            this.label14.TabIndex = 39;
            this.label14.Text = "Change:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(845, 526);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Paid:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(835, 478);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 37;
            this.label12.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(596, 353);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Qty";
            // 
            // qtyedit
            // 
            this.qtyedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyedit.Location = new System.Drawing.Point(653, 350);
            this.qtyedit.Margin = new System.Windows.Forms.Padding(4);
            this.qtyedit.Name = "qtyedit";
            this.qtyedit.Size = new System.Drawing.Size(151, 29);
            this.qtyedit.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(572, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(560, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "ProdID";
            // 
            // prodidedit
            // 
            this.prodidedit.Enabled = false;
            this.prodidedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodidedit.Location = new System.Drawing.Point(653, 241);
            this.prodidedit.Margin = new System.Windows.Forms.Padding(4);
            this.prodidedit.Name = "prodidedit";
            this.prodidedit.Size = new System.Drawing.Size(151, 29);
            this.prodidedit.TabIndex = 31;
            // 
            // activesale
            // 
            this.activesale.AllowUserToAddRows = false;
            this.activesale.AllowUserToDeleteRows = false;
            this.activesale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activesale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.activesale.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activesale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.activesale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activesale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductName,
            this.ProductPrice,
            this.ProdQty,
            this.Ptotal});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activesale.DefaultCellStyle = dataGridViewCellStyle20;
            this.activesale.Location = new System.Drawing.Point(813, 144);
            this.activesale.Margin = new System.Windows.Forms.Padding(4);
            this.activesale.MultiSelect = false;
            this.activesale.Name = "activesale";
            this.activesale.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activesale.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.activesale.RowHeadersWidth = 51;
            this.activesale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activesale.Size = new System.Drawing.Size(624, 308);
            this.activesale.TabIndex = 30;
            this.activesale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activesale_CellContentClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.No.FillWeight = 33.76397F;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 68;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProductName.FillWeight = 203.0457F;
            this.ProductName.HeaderText = "ProdName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 142;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProductPrice.FillWeight = 78.56751F;
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 90;
            // 
            // ProdQty
            // 
            this.ProdQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProdQty.FillWeight = 76.08253F;
            this.ProdQty.HeaderText = "Quantity";
            this.ProdQty.MinimumWidth = 6;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.ReadOnly = true;
            this.ProdQty.Width = 122;
            // 
            // Ptotal
            // 
            this.Ptotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ptotal.FillWeight = 108.5403F;
            this.Ptotal.HeaderText = "Total";
            this.Ptotal.MinimumWidth = 6;
            this.Ptotal.Name = "Ptotal";
            this.Ptotal.ReadOnly = true;
            this.Ptotal.Width = 90;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(151, 181);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(167, 30);
            this.search.TabIndex = 29;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(1317, 17);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(52, 24);
            this.date.TabIndex = 28;
            this.date.Text = "Date";
            // 
            // sellername
            // 
            this.sellername.AutoSize = true;
            this.sellername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellername.ForeColor = System.Drawing.Color.Transparent;
            this.sellername.Location = new System.Drawing.Point(48, 17);
            this.sellername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sellername.Name = "sellername";
            this.sellername.Size = new System.Drawing.Size(68, 25);
            this.sellername.TabIndex = 27;
            this.sellername.Text = "Seller";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Maroon;
            this.refresh.Location = new System.Drawing.Point(327, 181);
            this.refresh.Margin = new System.Windows.Forms.Padding(4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(131, 32);
            this.refresh.TabIndex = 26;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // categoryS
            // 
            this.categoryS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryS.FormattingEnabled = true;
            this.categoryS.Items.AddRange(new object[] {
            "All"});
            this.categoryS.Location = new System.Drawing.Point(16, 182);
            this.categoryS.Margin = new System.Windows.Forms.Padding(4);
            this.categoryS.Name = "categoryS";
            this.categoryS.Size = new System.Drawing.Size(125, 32);
            this.categoryS.TabIndex = 24;
            this.categoryS.Text = "Category";
            this.categoryS.SelectionChangeCommitted += new System.EventHandler(this.categoryS_SelectionChangeCommitted);
            // 
            // prodList
            // 
            this.prodList.AllowUserToAddRows = false;
            this.prodList.AllowUserToDeleteRows = false;
            this.prodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.prodList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.prodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodList.DefaultCellStyle = dataGridViewCellStyle23;
            this.prodList.Location = new System.Drawing.Point(13, 222);
            this.prodList.Margin = new System.Windows.Forms.Padding(4);
            this.prodList.MultiSelect = false;
            this.prodList.Name = "prodList";
            this.prodList.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodList.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.prodList.RowHeadersWidth = 51;
            this.prodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodList.Size = new System.Drawing.Size(445, 439);
            this.prodList.TabIndex = 23;
            this.prodList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodList_CellContentClick);
            // 
            // prodeditbtn
            // 
            this.prodeditbtn.BackColor = System.Drawing.Color.White;
            this.prodeditbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodeditbtn.Location = new System.Drawing.Point(569, 401);
            this.prodeditbtn.Margin = new System.Windows.Forms.Padding(4);
            this.prodeditbtn.Name = "prodeditbtn";
            this.prodeditbtn.Size = new System.Drawing.Size(107, 37);
            this.prodeditbtn.TabIndex = 22;
            this.prodeditbtn.Text = "EDIT";
            this.prodeditbtn.UseVisualStyleBackColor = false;
            this.prodeditbtn.Click += new System.EventHandler(this.prodeditbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(407, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.White;
            this.price.Enabled = false;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Location = new System.Drawing.Point(477, 87);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(232, 29);
            this.price.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(756, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.White;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.Black;
            this.quantity.Location = new System.Drawing.Point(868, 85);
            this.quantity.Margin = new System.Windows.Forms.Padding(4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(232, 29);
            this.quantity.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ProdName";
            // 
            // prodname
            // 
            this.prodname.BackColor = System.Drawing.Color.White;
            this.prodname.Enabled = false;
            this.prodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodname.ForeColor = System.Drawing.Color.Black;
            this.prodname.Location = new System.Drawing.Point(147, 87);
            this.prodname.Margin = new System.Windows.Forms.Padding(4);
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(232, 29);
            this.prodname.TabIndex = 15;
            // 
            // proddelbtn
            // 
            this.proddelbtn.BackColor = System.Drawing.Color.White;
            this.proddelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proddelbtn.ForeColor = System.Drawing.Color.Maroon;
            this.proddelbtn.Location = new System.Drawing.Point(699, 401);
            this.proddelbtn.Margin = new System.Windows.Forms.Padding(4);
            this.proddelbtn.Name = "proddelbtn";
            this.proddelbtn.Size = new System.Drawing.Size(107, 37);
            this.proddelbtn.TabIndex = 14;
            this.proddelbtn.Text = "DELETE";
            this.proddelbtn.UseVisualStyleBackColor = false;
            this.proddelbtn.Click += new System.EventHandler(this.proddelbtn_Click);
            // 
            // prodaddbtn
            // 
            this.prodaddbtn.BackColor = System.Drawing.Color.White;
            this.prodaddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodaddbtn.Location = new System.Drawing.Point(1165, 81);
            this.prodaddbtn.Margin = new System.Windows.Forms.Padding(4);
            this.prodaddbtn.Name = "prodaddbtn";
            this.prodaddbtn.Size = new System.Drawing.Size(107, 37);
            this.prodaddbtn.TabIndex = 13;
            this.prodaddbtn.Text = "ADD";
            this.prodaddbtn.UseVisualStyleBackColor = false;
            this.prodaddbtn.Click += new System.EventHandler(this.prodaddbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(555, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "Manage Sales";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tomato;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(1379, 709);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 41);
            this.button4.TabIndex = 47;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(1399, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 39);
            this.label8.TabIndex = 58;
            this.label8.Text = "-";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1439, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 36);
            this.panel2.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1388, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 36);
            this.panel3.TabIndex = 59;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1484, 752);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SellingForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activesale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ComboBox categoryS;
        private System.Windows.Forms.DataGridView prodList;
        private System.Windows.Forms.Button prodeditbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.Button proddelbtn;
        private System.Windows.Forms.Button prodaddbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label sellername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox qtyedit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prodidedit;
        private System.Windows.Forms.DataGridView activesale;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totallb;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.TextBox paid;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox prodnameedit;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ptotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Qcheck;
    }
}