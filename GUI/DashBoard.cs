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
        private void BookForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

        private void btnName_Click(object sender, EventArgs e)
        {
            OpenChildform(new BookForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
