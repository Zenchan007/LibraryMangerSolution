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
using BLL;
namespace GUI
{
    public partial class BookForm : Form
    {
        private int pageIndex = 0;
        private int pageSize = 50;
        private int maxPage;
        DataSet ds = null;
        public BookForm()
        {
            InitializeComponent();
        }


        private async void BookForm_Load(object sender, EventArgs e)
        {
            await Load_Data();
            this.txtPage.Parent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtPage_MouseDoubleClick);

        }
        public async Task Load_Data()
        {
            dtgBook.AutoGenerateColumns = false;
            dtgBook.DataSource = null;
            dtgBook.ColumnCount = 6;
            string bookName = ConvertTextbox(txtBookName.Texts, "Tên sách");
            string author = ConvertTextbox(txtAuthor.Texts, "Tên tác giả");
            string category = ConvertTextbox(txtCategory.Texts, "Thể loại");
            string status = ConvertTextbox(txtStatus.Texts, "Trạng thái");
            BookDAL bookDAL = new BookDAL();
            ds = await bookDAL.getDataBook(bookName, author, category, status, pageIndex, pageSize);
            await Rename_column();
            dtgBook.Columns[0].DataPropertyName = "BookName";
            dtgBook.Columns[1].DataPropertyName = "Author";
            dtgBook.Columns[2].DataPropertyName = "Category";
            dtgBook.Columns[3].DataPropertyName = "Price";
            dtgBook.Columns[4].DataPropertyName = "Status";
            dtgBook.Columns[5].DataPropertyName = "Quantity";
            dtgBook.DataSource = ds.Tables[0];
            maxPage = BookDAL.maxPage;
            if (pageIndex == 0)
            {
                ibtnStart.Enabled = false;
                ibtnBack.Enabled = false;
            }
            else
            {
                ibtnStart.Enabled = true;
                ibtnBack.Enabled = true;
            }

            if ((pageIndex + 1) >= maxPage)
            {
                ibtnNext.Enabled = false;
                ibtnEnd.Enabled = false;
            }
            else
            {
                ibtnNext.Enabled = true;
                ibtnEnd.Enabled = true;
            }
            txtPage.Text = "Trang " + (pageIndex + 1) + " trên tổng số " + maxPage;
            this.Refresh();
        }

        public async Task Rename_column()
        {
            dtgBook.Columns[0].HeaderText = "Tên sách";           
            dtgBook.Columns[1].HeaderText = "Tên tác giả";           
            dtgBook.Columns[2].HeaderText = "Tên thể loại";        
            dtgBook.Columns[3].HeaderText = "Giá";       
            dtgBook.Columns[4].HeaderText = "Trạng thái";       
            dtgBook.Columns[5].HeaderText = "Số lượng";
        }
        private void txtBookName_Enter(object sender, EventArgs e)
        {
            if (txtBookName.Texts == "Tên sách")
                txtBookName.Texts = "";
        }

        private void txtAuthor_Enter(object sender, EventArgs e)
        {
            if (txtAuthor.Texts == "Tên tác giả")
                txtAuthor.Texts = "";
        }

        private void txtCategory_Enter(object sender, EventArgs e)
        {
            if (txtCategory.Texts == "Thể loại")
                txtCategory.Texts = "";
        }

        private void txtStatus_Enter(object sender, EventArgs e)
        {
            if (txtStatus.Texts == "Trạng thái")
                txtStatus.Texts = "";
        }

        private void txtBookName_Leave(object sender, EventArgs e)
        {
            if (txtBookName.Texts == "")
                txtBookName.Texts = "Tên sách";
        }

        private void txtAuthor_Leave(object sender, EventArgs e)
        {
            if (txtAuthor.Texts == "")
                txtAuthor.Texts = "Tên tác giả";
        }

        private void txtCategory_Leave(object sender, EventArgs e)
        {
            if (txtCategory.Texts == "")
                txtCategory.Texts = "Thể loại";
        }

        private void txtStatus_Leave(object sender, EventArgs e)
        {
            if (txtStatus.Texts == "")
                txtStatus.Texts = "Trạng thái";
        }



        private async void ibtnSearch_Click(object sender, EventArgs e)
        {
            pageIndex = 0;
            await Load_Data();
        }

        private string ConvertTextbox(string textbox, string v) // Check xem người dùng đã thay đổi gì trong ô textbox chưa 
        {
            return textbox == v ? "" : textbox;
        }

        private void txtPage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!txtPage.Enabled)
            {
                txtPage.Enabled = true;
                txtPage.Text = "";
                txtPage.Focus();
            }
        }

        private void txtPage_Leave(object sender, EventArgs e)
        {
            if (txtPage.Enabled)
            {
                txtPage.Enabled = false;
                txtPage.Text = "Trang " + (pageIndex + 1) + " trên tổng số " + maxPage;
            }
        }

        private async void ibtnStart_Click(object sender, EventArgs e)
        {
            this.pageIndex = 0;
            await Load_Data();
        }

        private async void ibtnBack_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0)
            {
                this.pageIndex--;
                await Load_Data();
            }
        }

        private async void ibtnNext_Click(object sender, EventArgs e)
        {
            if (pageIndex < maxPage)
            {
                this.pageIndex++;
                await Load_Data();
            }
        }

        private async void ibtnEnd_Click(object sender, EventArgs e)
        {
            this.pageIndex = maxPage - 1;
            await Load_Data();
        }

        private void dtgBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != null)
            {
                DataGridViewRow row = dtgBook.Rows[e.RowIndex];
                txtBookInfor.DataBindings.Clear();
                txtAuthorInfor.DataBindings.Clear();
                txtCategoryInfor.DataBindings.Clear();
                txtStatusInfor.DataBindings.Clear();
                txtBookInfor.DataBindings.Add("Texts", ds.Tables[0], "BookName");
                txtAuthorInfor.DataBindings.Add("Texts", ds.Tables[0], "Author");
                txtCategoryInfor.DataBindings.Add("Texts", ds.Tables[0], "Category");
                txtStatusInfor.DataBindings.Add("Texts", ds.Tables[0], "Status");
            }
        }

        private void txtPage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    pageIndex = Convert.ToInt32(txtPage.Text) - 1;
                    if (pageIndex >= 0 && (pageIndex + 1) <= maxPage)
                    {
                        dtgBook.Refresh();
                        Load_Data();
                        txtPage.Enabled = false;
                    }
                    else throw new Exception("Not Found Page");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ibtnAddBook_Click(object sender, EventArgs e)
        {

        }

        private void ibtnUpdateBook_Click(object sender, EventArgs e)
        {

        }

        private void ibtnDeleteBook_Click(object sender, EventArgs e)
        {

        }
        private void dtgBook_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                dtgBook.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
                dtgBook.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void dtgBook_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dtgBook.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dtgBook.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
            }
        }
    }
    
}
