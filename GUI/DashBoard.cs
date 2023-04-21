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
using System.Diagnostics;

namespace GUI
{
    public partial class DashboardForm : Form
    {

        private Form currentChildform;
        public DashboardForm()
        {
            Trace.WriteLine(Environment.Version);
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
            {
                Owner.Show();
            }    
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenChildform(new BookForm());
            this.Refresh();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            OpenChildform(new AuthorForm());
            this.Refresh();
        }

        private void btnBorrowbook_Click(object sender, EventArgs e)
        {
            OpenChildform(new BorrowBookForm());
            this.Refresh();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenChildform(new ReportForm());
            this.Refresh();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildform(new AccountForm());
            this.Refresh();
        }
    }
}
