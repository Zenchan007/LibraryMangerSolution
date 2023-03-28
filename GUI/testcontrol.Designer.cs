namespace GUI
{
    partial class testcontrol
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
            this.cTextBox1 = new CustomControl.CTextBox();
            this.cPictureBox1 = new CustomControl.CPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cTextBox1
            // 
            this.cTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox1.BorderFocusColor = System.Drawing.Color.DarkViolet;
            this.cTextBox1.BorderSize = 2;
            this.cTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox1.Location = new System.Drawing.Point(166, 226);
            this.cTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox1.Multiline = false;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox1.PasswordChar = false;
            this.cTextBox1.Size = new System.Drawing.Size(250, 35);
            this.cTextBox1.TabIndex = 1;
            this.cTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cTextBox1.Texts = "";
            this.cTextBox1.UnderlinedStyle = false;
            // 
            // cPictureBox1
            // 
            this.cPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.cPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cPictureBox1.BorderSize = 2;
            this.cPictureBox1.GradientAngle = 50F;
            this.cPictureBox1.Location = new System.Drawing.Point(501, 187);
            this.cPictureBox1.Name = "cPictureBox1";
            this.cPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.cPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cPictureBox1.TabIndex = 0;
            this.cPictureBox1.TabStop = false;
            // 
            // testcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cTextBox1);
            this.Controls.Add(this.cPictureBox1);
            this.Name = "testcontrol";
            this.Text = "testcontrol";
            ((System.ComponentModel.ISupportInitialize)(this.cPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.CPictureBox cPictureBox1;
        private CustomControl.CTextBox cTextBox1;
    }
}