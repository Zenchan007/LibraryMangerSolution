using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace GUI
{
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        //CancellationTokenSource cts = new CancellationTokenSource();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Owner != null && !Owner.Disposing && !Owner.IsDisposed && !Owner.Visible)
                Owner.Show();
            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Texts == "USERNAME")
                txtUsername.Texts = "";
            txtUsername.ForeColor = Color.White;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "EMAIL")
                txtEmail.Texts = "";
            txtEmail.ForeColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Texts == "PASSWORD")
                txtPassword.Texts = "";
            txtPassword.PasswordChar = true;
            txtPassword.ForeColor = Color.White;
        }
        private void txtReenterpassword_Enter(object sender, EventArgs e)
        {
            if (txtReEnterPassword.Texts == "RE-ENTER PASSWORD")
                txtReEnterPassword.Texts = "";
            txtReEnterPassword.PasswordChar = true;
            txtReEnterPassword.ForeColor = Color.White;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Texts == "")
                txtUsername.Texts = "USERNAME";
            txtUsername.ForeColor = Color.DimGray;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "")
                txtEmail.Texts = "EMAIL";
            txtEmail.ForeColor = Color.DimGray;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Texts == "")
            {
                txtPassword.Texts = "PASSWORD";
                txtPassword.PasswordChar = false;
            }
            txtPassword.ForeColor = Color.DimGray;
        }    

        private void txtReenterpassword_Leave(object sender, EventArgs e)
        {
            if (txtReEnterPassword.Texts == "")
            {
                txtReEnterPassword.Texts = "RE-ENTER PASSWORD";
                txtReEnterPassword.PasswordChar = false;
            }
            txtReEnterPassword.ForeColor = Color.DimGray;
        }

        private  void  btnSingup_Click(object sender, EventArgs e)
        {
            string userName = (txtUsername.Texts == "USERNAME") ? "" : txtUsername.Texts;
            string eMail = (txtEmail.Texts == "EMAIL") ? "" : txtEmail.Texts;
            string passWord = (txtPassword.Texts == "PASSWORD") ? "" : txtPassword.Texts;
            string reEnterPassword = (txtReEnterPassword.Texts == "RE-ENTER PASSWORD") ? "" : txtEmail.Texts;
            var userDAL = new UserDAL();
            
            try
            {
                if (userName == "" || eMail == "" || passWord == "" || reEnterPassword == "")
                    throw new Exception("Please complete all information");
                if (passWord.Length < 8)
                    throw new Exception("Password must be more than 8 characters");
                if (passWord != reEnterPassword)
                    throw new Exception("Verify password does not match");
                string strEmail = eMail.ToLower();

                var taskCheckUserHaveExist = userDAL.UserHaveExist(eMail);
                taskCheckUserHaveExist.ContinueWith(t =>
                {
                   if(t.Status == TaskStatus.Faulted)
                    {
                        Trace.TraceError("Có lỗi xảy ra");

                    }else if(t.Status == TaskStatus.Canceled)
                    {
                        Trace.TraceError("Task Bị hủy giữa chừng!!");
                    }
                    else
                    {
                        var us = t.Result;
                        if (us != null)
                        {
                            throw new Exception("Email already in use");
                        }
                    }
                });
                 var taskInsertUser = userDAL.InsertUserDAL(userName, eMail, passWord);
                taskInsertUser.ContinueWith(t => {

                    if (Owner != null && !Owner.Disposing && !Owner.IsDisposed && !Owner.Visible)
                        Owner.Show();
                });
            }
            catch (Exception ex)
            {
                errProvider.SetError(txtUsername, ex.Message);
            }
            finally
            {
                userDAL.Dispose_Connection();
            }
        }
        private void txtUsername_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
            foreach(Control control in this.Controls)
            {
                control.MouseDown += new MouseEventHandler(control_MouseDown);
                if (control.HasChildren)
                {
                    foreach(Control childControl in control.Controls)
                    {
                        childControl.MouseDown += new MouseEventHandler(control_MouseDown);
                    }
                }
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] 
        private extern static void ReleaseCapture(); 

        [DllImport("user32.DLL", EntryPoint = "SendMessage")] 
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam); 
        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
