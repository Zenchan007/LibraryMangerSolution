namespace GUI
{
    partial class AccountForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cTextBox1 = new CustomControl.CTextBox();
            this.cTextBox2 = new CustomControl.CTextBox();
            this.cTextBox3 = new CustomControl.CTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cTextBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cTextBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cTextBox3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 391);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cTextBox1
            // 
            this.cTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextBox1.BorderSize = 2;
            this.cTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox1.Location = new System.Drawing.Point(38, 134);
            this.cTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox1.Multiline = false;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox1.PasswordChar = false;
            this.cTextBox1.Size = new System.Drawing.Size(633, 35);
            this.cTextBox1.TabIndex = 1;
            this.cTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cTextBox1.Texts = "";
            this.cTextBox1.UnderlinedStyle = false;
            // 
            // cTextBox2
            // 
            this.cTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextBox2.BorderSize = 2;
            this.cTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox2.Location = new System.Drawing.Point(38, 199);
            this.cTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox2.Multiline = false;
            this.cTextBox2.Name = "cTextBox2";
            this.cTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox2.PasswordChar = false;
            this.cTextBox2.Size = new System.Drawing.Size(633, 35);
            this.cTextBox2.TabIndex = 2;
            this.cTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cTextBox2.Texts = "";
            this.cTextBox2.UnderlinedStyle = false;
            // 
            // cTextBox3
            // 
            this.cTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextBox3.BorderSize = 2;
            this.cTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox3.Location = new System.Drawing.Point(38, 264);
            this.cTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox3.Multiline = false;
            this.cTextBox3.Name = "cTextBox3";
            this.cTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox3.PasswordChar = false;
            this.cTextBox3.Size = new System.Drawing.Size(633, 35);
            this.cTextBox3.TabIndex = 3;
            this.cTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cTextBox3.Texts = "";
            this.cTextBox3.UnderlinedStyle = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 328);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(704, 60);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(476, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(124, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private CustomControl.CTextBox cTextBox1;
        private CustomControl.CTextBox cTextBox2;
        private CustomControl.CTextBox cTextBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}