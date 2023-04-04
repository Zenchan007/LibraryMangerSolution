namespace GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.cPictureBox1 = new CustomControl.CPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblLogin = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new CustomControl.CTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new CustomControl.CTextBox();
            this.lblSignup = new System.Windows.Forms.LinkLabel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tblLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.pnlLogo.Controls.Add(this.cPictureBox1);
            resources.ApplyResources(this.pnlLogo, "pnlLogo");
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            // 
            // cPictureBox1
            // 
            resources.ApplyResources(this.cPictureBox1, "cPictureBox1");
            this.cPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cPictureBox1.BorderColor = System.Drawing.Color.DimGray;
            this.cPictureBox1.BorderColor2 = System.Drawing.Color.Gainsboro;
            this.cPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cPictureBox1.BorderSize = 2;
            this.cPictureBox1.GradientAngle = 50F;
            this.cPictureBox1.Image = global::GUI.Properties.Resources.library1;
            this.cPictureBox1.Name = "cPictureBox1";
            this.cPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblLogin);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tblLogin
            // 
            resources.ApplyResources(this.tblLogin, "tblLogin");
            this.tblLogin.Controls.Add(this.btnLogin, 0, 3);
            this.tblLogin.Controls.Add(this.txtPassword, 0, 2);
            this.tblLogin.Controls.Add(this.label1, 0, 0);
            this.tblLogin.Controls.Add(this.txtEmail, 0, 1);
            this.tblLogin.Controls.Add(this.lblSignup, 0, 4);
            this.tblLogin.Name = "tblLogin";
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.BorderColor = System.Drawing.Color.DimGray;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.Blue;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = true;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Texts = "PASSWORD";
            this.txtPassword.UnderlinedStyle = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.BorderColor = System.Drawing.Color.DimGray;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.Blue;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Texts = "EMAIL";
            this.txtEmail.UnderlinedStyle = true;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblSignup
            // 
            this.lblSignup.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            resources.ApplyResources(this.lblSignup, "lblSignup");
            this.lblSignup.LinkColor = System.Drawing.Color.DimGray;
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.TabStop = true;
            this.lblSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSignup_LinkClicked);
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.DimGray;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlLogo);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tblLogin.ResumeLayout(false);
            this.tblLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblLogin;
        private System.Windows.Forms.Label label1;
        private CustomControl.CTextBox txtEmail;
        private CustomControl.CTextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblSignup;
        private CustomControl.CPictureBox cPictureBox1;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}

