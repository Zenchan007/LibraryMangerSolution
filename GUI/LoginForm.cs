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
    public partial class LoginForm : Form
    {
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private string defautTextLogin = "Vui lòng điền email hoặc tên tài khoản";
        private string defautTextPassword = "Vui lòng điền mật khẩu";
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // tắt app
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            // thu áp xuống taskbar
            this.WindowState = FormWindowState.Minimized;
        }

        #region Đoạn này dùng để giúp mình có thể di, kéo thả cái form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] // API của windown. Dùng hàm ReleaseCapture của DLL của window, cụ thể là lớp user32.DLL 
        private extern static void ReleaseCapture(); // Khai báo phương thức này triển khai bên ngoài với từ khóa extern. 

        [DllImport("user32.DLL", EntryPoint = "SendMessage")] // Dùng hàm SendMessage của lớp user32.DLL
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam); // 

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); // Giải phóng bộ nhớ chuột tại ứng dụng hiện thời
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            //Tin nhắn WM_SYSCOMMAND là một tin nhắn hệ thống Windows
            //, nó được gửi đến cửa sổ để yêu cầu hành động được thực hiện,
            //chẳng hạn như di chuyển cửa sổ, tối đa hoặc tối thiểu hoặc đóng cửa sổ.
            //Mã SC_MOVE(0xf012) là một hằng số được định nghĩa bởi Windows
            //và nó chỉ ra rằng yêu cầu được gửi cho hệ thống để di chuyển cửa sổ.
            //Khi mã này được gửi, cửa sổ được chuyển đến vị trí mới trên màn hình dựa trên vị trí của chuột.
        }

        private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbErr.Visible = false;
            errProvider.Clear();
            if (btnLogin.Text == "ĐĂNG NHẬP")
            {
                btnLogin.Text = "HỦY ĐĂNG NHẬP";
                string strEmail = txtEmail.Texts;
                string strPass = txtPassword.Texts;
                UserDAL userDAL = new UserDAL();
                try
                {
                    var taskCheckAccount = userDAL.CheckAccounInfomationt(strEmail, strPass, cancellationTokenSource.Token);
                    taskCheckAccount.ContinueWith(t =>
                   {
                       if (t.IsCanceled) // task bị hủy giữa chừng
                       {
                           Trace.WriteLine("Hủy đăng đăng nhập");
                       }
                       else if (t.Result) // task chạy và có kết quả == true;
                       {
                           this.Invoke(new Action(() =>
                           {
                               Trace.WriteLine("Đăng nhập thành công");
                               DashboardForm dashboardForm = new DashboardForm();
                               dashboardForm.Show(this);
                               Hide();
                               btnLogin.Text = "ĐĂNG NHẬP";
                           }));
                       }
                       else if (t.IsFaulted)
                       {
                           Trace.WriteLine("Có lỗi khi đang nhập");
                       }
                       else // task chạy và có kết quả = false;
                       {
                           tblLogin.Invoke(new Action(() =>
                           {
                               errProvider.Clear();
                               //errProvider.SetError(txtEmail, "Vui lòng kiểm tra lại thông tin tài khoản");
                               lbErr.Text = "Tài khoản hoặc mật khẩu không đúng. vui lòng kiểm tra lại";
                               lbErr.Visible = true;
                               btnLogin.Text = "ĐĂNG NHẬP";
                           }));
                       }
                       cancellationTokenSource.Dispose();
                       cancellationTokenSource = new CancellationTokenSource();
                   });

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                btnLogin.Text = "ĐĂNG NHẬP";
                cancellationTokenSource.Cancel();
            }
        }
        private void lblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show(this);
            Hide();
        }
        #region xử lý enter, leave, validating của textbox
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "")
            {
                txtEmail.Texts = defautTextLogin;
            }
            txtEmail.ForeColor = Color.DimGray;
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Texts == defautTextLogin)
            {
                txtEmail.Texts = "";
            }
            txtEmail.ForeColor = Color.White;
            Trace.WriteLine(txtPassword.Texts);
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Texts == "")
            {
                txtPassword.Texts = defautTextPassword;
                txtPassword.PasswordChar = false;
            }
            txtPassword.ForeColor = Color.DimGray;
            Trace.WriteLine(txtPassword.Texts);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
            if (txtPassword.Texts == defautTextPassword)
            {
                txtPassword.Texts = "";
            }
            txtPassword.ForeColor = Color.White;
            Trace.WriteLine(txtPassword.Texts);
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            txtEmail.Texts = (txtEmail.Texts == defautTextLogin ? "" : txtEmail.Texts);
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Texts))
                {
                    throw new Exception("Vui lòng điền thông tin tài khoản");
                }
                else
                {
                    errProvider.Clear();
                }
            }
            catch (Exception ex)
            {
                errProvider.SetError(txtEmail, ex.Message);
                txtEmail.Texts =defautTextLogin;
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            txtPassword.Texts = (txtPassword.Texts == defautTextPassword ? "" : txtPassword.Texts); // check xem mail và pass có text hay không? 
            txtEmail.Texts = (txtEmail.Texts == defautTextLogin ? "" : txtEmail.Texts);
            try
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Texts)) // Pass không có text
                {
                    if (string.IsNullOrWhiteSpace(txtEmail.Texts)) // Mail cũng không có text
                    {
                        txtPassword.Texts = defautTextPassword; // thì set về trạng thái ban đầu
                        errProvider.Clear();
                    }
                    else throw new Exception("Vui lòng điền mật khẩu"); // Mail có text
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(txtEmail.Texts))
                    {
                        if (txtPassword.Texts.Length < 8)
                        {
                            throw new Exception("Mật khẩu không được nhỏ hơn 8 ký tự");
                        }
                        else
                        {
                            errProvider.Clear(); // Pass có thì clear lỗi
                        }
                    } 
                }
                
            }
            catch (Exception ex)
            {
                errProvider.SetError(txtPassword, ex.Message);
            }
        }
        #endregion

    }

}
