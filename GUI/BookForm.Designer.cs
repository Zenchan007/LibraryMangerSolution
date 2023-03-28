namespace GUI
{
    partial class BookForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgBook = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ibtnEnd = new FontAwesome.Sharp.IconButton();
            this.ibtnNext = new FontAwesome.Sharp.IconButton();
            this.ibtnBack = new FontAwesome.Sharp.IconButton();
            this.ibtnStart = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ibtnDeleteBook = new FontAwesome.Sharp.IconButton();
            this.ibtnUpdateBook = new FontAwesome.Sharp.IconButton();
            this.ibtnAddBook = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtPage = new CustomControl.CTextBox();
            this.cTextBox4 = new CustomControl.CTextBox();
            this.cTextBox3 = new CustomControl.CTextBox();
            this.cTextBox2 = new CustomControl.CTextBox();
            this.cTextBox1 = new CustomControl.CTextBox();
            this.txtBookName = new CustomControl.CTextBox();
            this.txtCategory = new CustomControl.CTextBox();
            this.txtStatus = new CustomControl.CTextBox();
            this.txtAuthor = new CustomControl.CTextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBook)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 599);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1304, 599);
            this.panel3.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(1304, 599);
            this.splitContainer1.SplitterDistance = 884;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dtgBook, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.44444F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.555555F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(884, 599);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dtgBook
            // 
            this.dtgBook.AllowUserToAddRows = false;
            this.dtgBook.AllowUserToDeleteRows = false;
            this.dtgBook.AllowUserToResizeColumns = false;
            this.dtgBook.AllowUserToResizeRows = false;
            this.dtgBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBook.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBook.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBook.Location = new System.Drawing.Point(3, 3);
            this.dtgBook.Name = "dtgBook";
            this.dtgBook.ReadOnly = true;
            this.dtgBook.RowHeadersWidth = 51;
            this.dtgBook.RowTemplate.Height = 24;
            this.dtgBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBook.Size = new System.Drawing.Size(878, 535);
            this.dtgBook.TabIndex = 7;
            this.dtgBook.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Controls.Add(this.ibtnEnd, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.ibtnNext, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.ibtnBack, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ibtnStart, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtPage, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 544);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(878, 52);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // ibtnEnd
            // 
            this.ibtnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEnd.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnEnd.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            this.ibtnEnd.IconColor = System.Drawing.Color.Black;
            this.ibtnEnd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEnd.IconSize = 35;
            this.ibtnEnd.Location = new System.Drawing.Point(804, 3);
            this.ibtnEnd.Name = "ibtnEnd";
            this.ibtnEnd.Size = new System.Drawing.Size(71, 46);
            this.ibtnEnd.TabIndex = 8;
            this.ibtnEnd.UseVisualStyleBackColor = true;
            this.ibtnEnd.Click += new System.EventHandler(this.ibtnEnd_Click);
            // 
            // ibtnNext
            // 
            this.ibtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNext.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.ibtnNext.IconColor = System.Drawing.Color.Black;
            this.ibtnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNext.IconSize = 35;
            this.ibtnNext.Location = new System.Drawing.Point(672, 3);
            this.ibtnNext.Name = "ibtnNext";
            this.ibtnNext.Size = new System.Drawing.Size(69, 46);
            this.ibtnNext.TabIndex = 7;
            this.ibtnNext.UseVisualStyleBackColor = true;
            this.ibtnNext.Click += new System.EventHandler(this.ibtnNext_Click);
            // 
            // ibtnBack
            // 
            this.ibtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBack.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.ibtnBack.IconColor = System.Drawing.Color.Black;
            this.ibtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBack.IconSize = 35;
            this.ibtnBack.Location = new System.Drawing.Point(134, 3);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(69, 46);
            this.ibtnBack.TabIndex = 6;
            this.ibtnBack.UseVisualStyleBackColor = true;
            this.ibtnBack.Click += new System.EventHandler(this.ibtnBack_Click);
            // 
            // ibtnStart
            // 
            this.ibtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnStart.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnStart.IconChar = FontAwesome.Sharp.IconChar.BackwardFast;
            this.ibtnStart.IconColor = System.Drawing.Color.Black;
            this.ibtnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnStart.IconSize = 35;
            this.ibtnStart.Location = new System.Drawing.Point(3, 3);
            this.ibtnStart.Name = "ibtnStart";
            this.ibtnStart.Size = new System.Drawing.Size(69, 46);
            this.ibtnStart.TabIndex = 5;
            this.ibtnStart.UseVisualStyleBackColor = true;
            this.ibtnStart.Click += new System.EventHandler(this.ibtnStart_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cTextBox4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cTextBox3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cTextBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cTextBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 544);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.ibtnDeleteBook, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ibtnUpdateBook, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ibtnAddBook, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 544);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(416, 55);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ibtnDeleteBook
            // 
            this.ibtnDeleteBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDeleteBook.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnDeleteBook.IconColor = System.Drawing.Color.Black;
            this.ibtnDeleteBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDeleteBook.IconSize = 30;
            this.ibtnDeleteBook.Location = new System.Drawing.Point(279, 3);
            this.ibtnDeleteBook.Name = "ibtnDeleteBook";
            this.ibtnDeleteBook.Size = new System.Drawing.Size(134, 49);
            this.ibtnDeleteBook.TabIndex = 2;
            this.ibtnDeleteBook.TabStop = false;
            this.ibtnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // ibtnUpdateBook
            // 
            this.ibtnUpdateBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUpdateBook.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.ibtnUpdateBook.IconColor = System.Drawing.Color.Black;
            this.ibtnUpdateBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUpdateBook.IconSize = 30;
            this.ibtnUpdateBook.Location = new System.Drawing.Point(141, 3);
            this.ibtnUpdateBook.Name = "ibtnUpdateBook";
            this.ibtnUpdateBook.Size = new System.Drawing.Size(132, 49);
            this.ibtnUpdateBook.TabIndex = 1;
            this.ibtnUpdateBook.TabStop = false;
            this.ibtnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // ibtnAddBook
            // 
            this.ibtnAddBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAddBook.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.ibtnAddBook.IconColor = System.Drawing.Color.Black;
            this.ibtnAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAddBook.IconSize = 30;
            this.ibtnAddBook.Location = new System.Drawing.Point(3, 3);
            this.ibtnAddBook.Name = "ibtnAddBook";
            this.ibtnAddBook.Size = new System.Drawing.Size(132, 49);
            this.ibtnAddBook.TabIndex = 0;
            this.ibtnAddBook.TabStop = false;
            this.ibtnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtnAddBook.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 132);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtBookName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCategory, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtStatus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAuthor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ibtnSearch, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1302, 130);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnSearch.FlatAppearance.BorderSize = 0;
            this.ibtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.ibtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ibtnSearch.IconColor = System.Drawing.Color.Black;
            this.ibtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearch.Location = new System.Drawing.Point(1092, 42);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(157, 46);
            this.ibtnSearch.TabIndex = 5;
            this.ibtnSearch.Text = "Tìm kiếm";
            this.ibtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtnSearch.UseVisualStyleBackColor = true;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // txtPage
            // 
            this.txtPage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPage.BorderColor = System.Drawing.Color.Blue;
            this.txtPage.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPage.BorderSize = 1;
            this.txtPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPage.Enabled = false;
            this.txtPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.ForeColor = System.Drawing.Color.DimGray;
            this.txtPage.Location = new System.Drawing.Point(267, 14);
            this.txtPage.Margin = new System.Windows.Forms.Padding(5);
            this.txtPage.Multiline = false;
            this.txtPage.Name = "txtPage";
            this.txtPage.Padding = new System.Windows.Forms.Padding(5);
            this.txtPage.PasswordChar = false;
            this.txtPage.Size = new System.Drawing.Size(341, 33);
            this.txtPage.TabIndex = 4;
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPage.Texts = "";
            this.txtPage.UnderlinedStyle = false;
            this.txtPage.Leave += new System.EventHandler(this.txtPage_Leave);
            // 
            // cTextBox4
            // 
            this.cTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextBox4.BorderSize = 2;
            this.cTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox4.Location = new System.Drawing.Point(4, 412);
            this.cTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox4.Multiline = false;
            this.cTextBox4.Name = "cTextBox4";
            this.cTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox4.PasswordChar = false;
            this.cTextBox4.Size = new System.Drawing.Size(408, 40);
            this.cTextBox4.TabIndex = 3;
            this.cTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cTextBox4.Texts = "";
            this.cTextBox4.UnderlinedStyle = true;
            // 
            // cTextBox3
            // 
            this.cTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextBox3.BorderSize = 2;
            this.cTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox3.Location = new System.Drawing.Point(4, 276);
            this.cTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox3.Multiline = false;
            this.cTextBox3.Name = "cTextBox3";
            this.cTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox3.PasswordChar = false;
            this.cTextBox3.Size = new System.Drawing.Size(408, 40);
            this.cTextBox3.TabIndex = 2;
            this.cTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cTextBox3.Texts = "";
            this.cTextBox3.UnderlinedStyle = true;
            // 
            // cTextBox2
            // 
            this.cTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextBox2.BorderSize = 2;
            this.cTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox2.Location = new System.Drawing.Point(4, 140);
            this.cTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox2.Multiline = false;
            this.cTextBox2.Name = "cTextBox2";
            this.cTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox2.PasswordChar = false;
            this.cTextBox2.Size = new System.Drawing.Size(408, 40);
            this.cTextBox2.TabIndex = 1;
            this.cTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cTextBox2.Texts = "";
            this.cTextBox2.UnderlinedStyle = true;
            // 
            // cTextBox1
            // 
            this.cTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextBox1.BorderSize = 2;
            this.cTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox1.Location = new System.Drawing.Point(4, 4);
            this.cTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox1.Multiline = false;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox1.PasswordChar = false;
            this.cTextBox1.Size = new System.Drawing.Size(408, 40);
            this.cTextBox1.TabIndex = 0;
            this.cTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cTextBox1.Texts = "";
            this.cTextBox1.UnderlinedStyle = true;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBookName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBookName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBookName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBookName.BorderSize = 2;
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBookName.Location = new System.Drawing.Point(5, 45);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Multiline = false;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Padding = new System.Windows.Forms.Padding(7);
            this.txtBookName.PasswordChar = false;
            this.txtBookName.Size = new System.Drawing.Size(250, 40);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBookName.Texts = "Tên sách";
            this.txtBookName.UnderlinedStyle = false;
            this.txtBookName.Enter += new System.EventHandler(this.txtBookName_Enter);
            this.txtBookName.Leave += new System.EventHandler(this.txtBookName_Leave);
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategory.BackColor = System.Drawing.SystemColors.Window;
            this.txtCategory.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCategory.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCategory.BorderSize = 2;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.Color.DimGray;
            this.txtCategory.Location = new System.Drawing.Point(525, 45);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Multiline = false;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Padding = new System.Windows.Forms.Padding(7);
            this.txtCategory.PasswordChar = false;
            this.txtCategory.Size = new System.Drawing.Size(250, 40);
            this.txtCategory.TabIndex = 3;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategory.Texts = "Thể loại";
            this.txtCategory.UnderlinedStyle = false;
            this.txtCategory.Enter += new System.EventHandler(this.txtCategory_Enter);
            this.txtCategory.Leave += new System.EventHandler(this.txtCategory_Leave);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatus.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtStatus.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtStatus.BorderSize = 2;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.DimGray;
            this.txtStatus.Location = new System.Drawing.Point(785, 45);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Multiline = false;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Padding = new System.Windows.Forms.Padding(7);
            this.txtStatus.PasswordChar = false;
            this.txtStatus.Size = new System.Drawing.Size(250, 40);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStatus.Texts = "Trạng thái";
            this.txtStatus.UnderlinedStyle = false;
            this.txtStatus.Enter += new System.EventHandler(this.txtStatus_Enter);
            this.txtStatus.Leave += new System.EventHandler(this.txtStatus_Leave);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAuthor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAuthor.BorderSize = 2;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.DimGray;
            this.txtAuthor.Location = new System.Drawing.Point(265, 45);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Multiline = false;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Padding = new System.Windows.Forms.Padding(7);
            this.txtAuthor.PasswordChar = false;
            this.txtAuthor.Size = new System.Drawing.Size(250, 40);
            this.txtAuthor.TabIndex = 2;
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAuthor.Texts = "Tên tác giả";
            this.txtAuthor.UnderlinedStyle = false;
            this.txtAuthor.Enter += new System.EventHandler(this.txtAuthor_Enter);
            this.txtAuthor.Leave += new System.EventHandler(this.txtAuthor_Leave);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBook)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton ibtnSearch;
        private CustomControl.CTextBox txtBookName;
        private CustomControl.CTextBox txtCategory;
        private CustomControl.CTextBox txtStatus;
        private CustomControl.CTextBox txtAuthor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControl.CTextBox cTextBox4;
        private CustomControl.CTextBox cTextBox3;
        private CustomControl.CTextBox cTextBox2;
        private CustomControl.CTextBox cTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton ibtnDeleteBook;
        private FontAwesome.Sharp.IconButton ibtnUpdateBook;
        private FontAwesome.Sharp.IconButton ibtnAddBook;
        private System.Windows.Forms.DataGridView dtgBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private FontAwesome.Sharp.IconButton ibtnEnd;
        private FontAwesome.Sharp.IconButton ibtnNext;
        private FontAwesome.Sharp.IconButton ibtnBack;
        private FontAwesome.Sharp.IconButton ibtnStart;
        private CustomControl.CTextBox txtPage;
    }
}