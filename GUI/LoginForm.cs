using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace GUI
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
        private void btnExit_Click_1(object sender, EventArgs e)
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


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string strEmail = txtEmail.Texts;
            string strPass = txtPassword.Texts;
            try
            {
                strEmail = strEmail.ToLower();
                UserDAL userDAL = new UserDAL();
                if (await userDAL.CheckAccount(strEmail, strPass))
                {
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.Show(this);
                    Hide();
                }
            }
            catch (Exception ex)
            {
                errProvider.SetError(txtEmail, ex.Message);
            }
        }

        private void lblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show(this);
            Hide(); 
        }
        #endregion  
        #region xử lý các sự kiện nhấp vào và nhả ra của của ô email và ô password
        
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Texts == "PASSWORD")
            {
                txtPassword.Texts = "";
               
            }
            txtPassword.ForeColor = Color.White;
            txtPassword.PasswordChar = true;
        }

        
       
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Texts == "")
            {
                txtPassword.Texts = "PASSWORD";
            }
            txtPassword.ForeColor = Color.DimGray;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "")
            {
                txtEmail.Texts = "EMAIL";
            }
            txtEmail.ForeColor = Color.DimGray;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "EMAIL")
            {
                txtEmail.Texts = "";
            }
            txtEmail.ForeColor = Color.White;
        }
        #endregion

    }

}
