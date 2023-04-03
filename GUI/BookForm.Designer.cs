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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtStatusInfor = new CustomControl.CTextBox();
            this.txtCategoryInfor = new CustomControl.CTextBox();
            this.txtAuthorInfor = new CustomControl.CTextBox();
            this.txtBookInfor = new CustomControl.CTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ibtnDeleteBook = new FontAwesome.Sharp.IconButton();
            this.ibtnUpdateBook = new FontAwesome.Sharp.IconButton();
            this.ibtnAddBook = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBookName = new CustomControl.CTextBox();
            this.txtCategory = new CustomControl.CTextBox();
            this.txtStatus = new CustomControl.CTextBox();
            this.txtAuthor = new CustomControl.CTextBox();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer1.SplitterDistance = 901;
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(901, 599);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dtgBook
            // 
            this.dtgBook.AllowUserToAddRows = false;
            this.dtgBook.AllowUserToDeleteRows = false;
            this.dtgBook.AllowUserToResizeColumns = false;
            this.dtgBook.AllowUserToResizeRows = false;
            this.dtgBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBook.BackgroundColor = System.Drawing.Color.Pink;
            this.dtgBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgBook.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgBook.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBook.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBook.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgBook.Location = new System.Drawing.Point(3, 3);
            this.dtgBook.MultiSelect = false;
            this.dtgBook.Name = "dtgBook";
            this.dtgBook.ReadOnly = true;
            this.dtgBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgBook.RowHeadersVisible = false;
            this.dtgBook.RowHeadersWidth = 50;
            this.dtgBook.RowTemplate.Height = 24;
            this.dtgBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBook.Size = new System.Drawing.Size(895, 535);
            this.dtgBook.TabIndex = 7;
            this.dtgBook.TabStop = false;
            this.dtgBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBook_CellClick);
            this.dtgBook.Paint += new System.Windows.Forms.PaintEventHandler(this.dtgBook_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(895, 52);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // ibtnEnd
            // 
            this.ibtnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnEnd.BackColor = System.Drawing.Color.HotPink;
            this.ibtnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEnd.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnEnd.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            this.ibtnEnd.IconColor = System.Drawing.Color.Black;
            this.ibtnEnd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEnd.IconSize = 35;
            this.ibtnEnd.Location = new System.Drawing.Point(838, 3);
            this.ibtnEnd.Name = "ibtnEnd";
            this.ibtnEnd.Size = new System.Drawing.Size(54, 46);
            this.ibtnEnd.TabIndex = 8;
            this.ibtnEnd.UseVisualStyleBackColor = false;
            this.ibtnEnd.Click += new System.EventHandler(this.ibtnEnd_Click);
            // 
            // ibtnNext
            // 
            this.ibtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnNext.BackColor = System.Drawing.Color.HotPink;
            this.ibtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNext.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.ibtnNext.IconColor = System.Drawing.Color.Black;
            this.ibtnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNext.IconSize = 35;
            this.ibtnNext.Location = new System.Drawing.Point(749, 3);
            this.ibtnNext.Name = "ibtnNext";
            this.ibtnNext.Size = new System.Drawing.Size(52, 46);
            this.ibtnNext.TabIndex = 7;
            this.ibtnNext.UseVisualStyleBackColor = false;
            this.ibtnNext.Click += new System.EventHandler(this.ibtnNext_Click);
            // 
            // ibtnBack
            // 
            this.ibtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnBack.BackColor = System.Drawing.Color.HotPink;
            this.ibtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBack.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.ibtnBack.IconColor = System.Drawing.Color.Black;
            this.ibtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBack.IconSize = 35;
            this.ibtnBack.Location = new System.Drawing.Point(92, 3);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(52, 46);
            this.ibtnBack.TabIndex = 6;
            this.ibtnBack.UseVisualStyleBackColor = false;
            this.ibtnBack.Click += new System.EventHandler(this.ibtnBack_Click);
            // 
            // ibtnStart
            // 
            this.ibtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnStart.BackColor = System.Drawing.Color.HotPink;
            this.ibtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnStart.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnStart.IconChar = FontAwesome.Sharp.IconChar.BackwardFast;
            this.ibtnStart.IconColor = System.Drawing.Color.Black;
            this.ibtnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnStart.IconSize = 35;
            this.ibtnStart.Location = new System.Drawing.Point(3, 3);
            this.ibtnStart.Name = "ibtnStart";
            this.ibtnStart.Size = new System.Drawing.Size(52, 46);
            this.ibtnStart.TabIndex = 5;
            this.ibtnStart.UseVisualStyleBackColor = false;
            this.ibtnStart.Click += new System.EventHandler(this.ibtnStart_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtStatusInfor, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtCategoryInfor, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtAuthorInfor, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBookInfor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(399, 544);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtStatusInfor
            // 
            this.txtStatusInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusInfor.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatusInfor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtStatusInfor.BorderFocusColor = System.Drawing.Color.Pink;
            this.txtStatusInfor.BorderSize = 2;
            this.txtStatusInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusInfor.ForeColor = System.Drawing.Color.DimGray;
            this.txtStatusInfor.Location = new System.Drawing.Point(25, 472);
            this.txtStatusInfor.Margin = new System.Windows.Forms.Padding(25, 25, 25, 32);
            this.txtStatusInfor.Multiline = false;
            this.txtStatusInfor.Name = "txtStatusInfor";
            this.txtStatusInfor.Padding = new System.Windows.Forms.Padding(7);
            this.txtStatusInfor.PasswordChar = false;
            this.txtStatusInfor.Size = new System.Drawing.Size(349, 40);
            this.txtStatusInfor.TabIndex = 3;
            this.txtStatusInfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStatusInfor.Texts = "";
            this.txtStatusInfor.UnderlinedStyle = true;
            // 
            // txtCategoryInfor
            // 
            this.txtCategoryInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryInfor.BackColor = System.Drawing.SystemColors.Window;
            this.txtCategoryInfor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCategoryInfor.BorderFocusColor = System.Drawing.Color.Pink;
            this.txtCategoryInfor.BorderSize = 2;
            this.txtCategoryInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryInfor.ForeColor = System.Drawing.Color.DimGray;
            this.txtCategoryInfor.Location = new System.Drawing.Point(25, 360);
            this.txtCategoryInfor.Margin = new System.Windows.Forms.Padding(25, 25, 25, 32);
            this.txtCategoryInfor.Multiline = false;
            this.txtCategoryInfor.Name = "txtCategoryInfor";
            this.txtCategoryInfor.Padding = new System.Windows.Forms.Padding(7);
            this.txtCategoryInfor.PasswordChar = false;
            this.txtCategoryInfor.Size = new System.Drawing.Size(349, 40);
            this.txtCategoryInfor.TabIndex = 2;
            this.txtCategoryInfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategoryInfor.Texts = "";
            this.txtCategoryInfor.UnderlinedStyle = true;
            // 
            // txtAuthorInfor
            // 
            this.txtAuthorInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthorInfor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthorInfor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAuthorInfor.BorderFocusColor = System.Drawing.Color.Pink;
            this.txtAuthorInfor.BorderSize = 2;
            this.txtAuthorInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorInfor.ForeColor = System.Drawing.Color.DimGray;
            this.txtAuthorInfor.Location = new System.Drawing.Point(25, 252);
            this.txtAuthorInfor.Margin = new System.Windows.Forms.Padding(25, 25, 25, 32);
            this.txtAuthorInfor.Multiline = false;
            this.txtAuthorInfor.Name = "txtAuthorInfor";
            this.txtAuthorInfor.Padding = new System.Windows.Forms.Padding(7);
            this.txtAuthorInfor.PasswordChar = false;
            this.txtAuthorInfor.Size = new System.Drawing.Size(349, 40);
            this.txtAuthorInfor.TabIndex = 1;
            this.txtAuthorInfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAuthorInfor.Texts = "";
            this.txtAuthorInfor.UnderlinedStyle = true;
            // 
            // txtBookInfor
            // 
            this.txtBookInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookInfor.BackColor = System.Drawing.SystemColors.Window;
            this.txtBookInfor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBookInfor.BorderFocusColor = System.Drawing.Color.Pink;
            this.txtBookInfor.BorderSize = 2;
            this.txtBookInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookInfor.ForeColor = System.Drawing.Color.DimGray;
            this.txtBookInfor.Location = new System.Drawing.Point(25, 144);
            this.txtBookInfor.Margin = new System.Windows.Forms.Padding(25, 25, 25, 32);
            this.txtBookInfor.Multiline = false;
            this.txtBookInfor.Name = "txtBookInfor";
            this.txtBookInfor.Padding = new System.Windows.Forms.Padding(7);
            this.txtBookInfor.PasswordChar = false;
            this.txtBookInfor.Size = new System.Drawing.Size(349, 40);
            this.txtBookInfor.TabIndex = 0;
            this.txtBookInfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBookInfor.Texts = "";
            this.txtBookInfor.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 108);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(399, 55);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ibtnDeleteBook
            // 
            this.ibtnDeleteBook.BackColor = System.Drawing.Color.Crimson;
            this.ibtnDeleteBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibtnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDeleteBook.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnDeleteBook.IconColor = System.Drawing.Color.Black;
            this.ibtnDeleteBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDeleteBook.IconSize = 30;
            this.ibtnDeleteBook.Location = new System.Drawing.Point(291, 2);
            this.ibtnDeleteBook.Margin = new System.Windows.Forms.Padding(25, 2, 25, 5);
            this.ibtnDeleteBook.Name = "ibtnDeleteBook";
            this.ibtnDeleteBook.Size = new System.Drawing.Size(83, 48);
            this.ibtnDeleteBook.TabIndex = 2;
            this.ibtnDeleteBook.TabStop = false;
            this.ibtnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // ibtnUpdateBook
            // 
            this.ibtnUpdateBook.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ibtnUpdateBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibtnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUpdateBook.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.ibtnUpdateBook.IconColor = System.Drawing.Color.Black;
            this.ibtnUpdateBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUpdateBook.IconSize = 30;
            this.ibtnUpdateBook.Location = new System.Drawing.Point(158, 2);
            this.ibtnUpdateBook.Margin = new System.Windows.Forms.Padding(25, 2, 25, 5);
            this.ibtnUpdateBook.Name = "ibtnUpdateBook";
            this.ibtnUpdateBook.Size = new System.Drawing.Size(83, 48);
            this.ibtnUpdateBook.TabIndex = 1;
            this.ibtnUpdateBook.TabStop = false;
            this.ibtnUpdateBook.UseVisualStyleBackColor = false;
            // 
            // ibtnAddBook
            // 
            this.ibtnAddBook.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ibtnAddBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAddBook.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.ibtnAddBook.IconColor = System.Drawing.Color.Black;
            this.ibtnAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAddBook.IconSize = 30;
            this.ibtnAddBook.Location = new System.Drawing.Point(25, 2);
            this.ibtnAddBook.Margin = new System.Windows.Forms.Padding(25, 2, 25, 5);
            this.ibtnAddBook.Name = "ibtnAddBook";
            this.ibtnAddBook.Size = new System.Drawing.Size(83, 48);
            this.ibtnAddBook.TabIndex = 0;
            this.ibtnAddBook.TabStop = false;
            this.ibtnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtnAddBook.UseVisualStyleBackColor = false;
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
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
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
            this.txtPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPage.Enabled = false;
            this.txtPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.Location = new System.Drawing.Point(181, 16);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(531, 33);
            this.txtPage.TabIndex = 9;
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPage_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
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
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private CustomControl.CTextBox txtStatusInfor;
        private CustomControl.CTextBox txtCategoryInfor;
        private CustomControl.CTextBox txtAuthorInfor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dtgBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private FontAwesome.Sharp.IconButton ibtnEnd;
        private FontAwesome.Sharp.IconButton ibtnNext;
        private FontAwesome.Sharp.IconButton ibtnBack;
        private FontAwesome.Sharp.IconButton ibtnStart;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibtnDeleteBook;
        private FontAwesome.Sharp.IconButton ibtnUpdateBook;
        private FontAwesome.Sharp.IconButton ibtnAddBook;
        private CustomControl.CTextBox txtBookInfor;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}