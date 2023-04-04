using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace GUI
{
    public partial class DashboardForm : Form
    {

        private Form currentChildform;
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void OpenChildform(Form childForm)
        {
                currentChildform = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlChildform.Controls.Add(currentChildform);
                childForm.BringToFront();
                childForm.Show();
        }

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Owner != null && !Owner.Disposing && !Owner.IsDisposed && !Owner.Visible)
                Owner.Show();
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenChildform(new BookForm());
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
