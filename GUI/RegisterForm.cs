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

        CancellationTokenSource cts = new CancellationTokenSource();
        #region
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
            if (txtUsername.Texts == "TÊN NGƯỜI DÙNG")
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
            if (txtPassword.Texts == "MẬT KHẨU")
                txtPassword.Texts = "";
            txtPassword.PasswordChar = true;
            txtPassword.ForeColor = Color.White;
        }
        private void txtReenterpassword_Enter(object sender, EventArgs e)
        {
            if (txtReEnterPassword.Texts == "XÁC NHẬN MẬT KHẨU")
                txtReEnterPassword.Texts = "";
            txtReEnterPassword.PasswordChar = true;
            txtReEnterPassword.ForeColor = Color.White;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Texts == "")
                txtUsername.Texts = "TÊN NGƯỜI DÙNG";
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
                txtPassword.Texts = "MẬT KHẨU";
                txtPassword.PasswordChar = false;
            }
            txtPassword.ForeColor = Color.DimGray;
        }

        private void txtReenterpassword_Leave(object sender, EventArgs e)
        {
            if (txtReEnterPassword.Texts == "")
            {
                txtReEnterPassword.Texts = "XÁC NHẬN MẬT KHẨU";
                txtReEnterPassword.PasswordChar = false;
            }
            txtReEnterPassword.ForeColor = Color.DimGray;
        }
        #endregion
        private void btnSingup_Click(object sender, EventArgs e)
        {
            XXX();
        }

        private async Task XXX()
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

                var taskCheckUserHaveExist = userDAL.GetUserReader(eMail);
                await taskCheckUserHaveExist.ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.Faulted)
                    {
                        Trace.TraceError("Có lỗi xảy ra");
                    }
                    else if (t.Status == TaskStatus.Canceled)
                    {
                        Trace.TraceError("Task Bị hủy giữa chừng!!");
                    }
                    else
                    {
                        var x = t.Result;
                        if (x == null)
                        {
                            var taskInser = userDAL.InsertUserDAL(userName, eMail, passWord);
                            taskInser.ContinueWith(r =>
                            {
                                if (r.IsCanceled)
                                {
                                    Trace.WriteLine("Bị hủy");
                                }
                                else
                                {
                                    Trace.WriteLine("Done");
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("Tài khoản đã tồn tại");
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                errProvider.SetError(txtUsername, ex.Message);
            }
            finally
            {
                
            }
        }

        private void txtUsername_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                control.MouseDown += new MouseEventHandler(control_MouseDown);
                if (control.HasChildren)
                {
                    foreach (Control childControl in control.Controls)
                    {
                        childControl.MouseDown += new MouseEventHandler(control_MouseDown);
                    }
                }
            }
        }

        #region
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }

}
