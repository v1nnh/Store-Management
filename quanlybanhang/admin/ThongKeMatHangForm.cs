using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public partial class ThongKeMatHangForm : Form
    {
        MATHANG tk = new MATHANG();
        MY_DB mydb = new MY_DB();
        public ThongKeMatHangForm()
        {
            InitializeComponent();
        }

        private void ThongKeMatHangForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT magiohang as 'Mã giỏ hàng ',mahang as 'Mã hàng',tenhang as 'Tên hàng',soluong as 'Số lượng',gia as 'Giá',mskh as 'MSKH',ngay as 'Ngày' FROM dbo.LICHSU_GIOHANG");
                dataGridViewthongke.DataSource = tk.layLICHSU_GIOHANG(command);
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dataGridViewthongke.Columns[3];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch (Exception)
            {


            }
            // SqlCommand command = new SqlCommand("SELECT magiohang as 'Mã giỏ hàng ',mahang as 'Mã hàng',tenhang as 'Tên hàng',soluong as 'Số lượng',gia as 'Giá',mskh as 'MSKH',ngay as 'Ngày' FROM dbo.LICHSU_GIOHANG");
            // dataGridViewthongke.DataSource = tk.layLICHSU_GIOHANG(command);
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            // picCol = (DataGridViewImageColumn)dataGridViewthongke.Columns[3];
            // picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewthongke.ReadOnly = true;
            dataGridViewthongke.RowTemplate.Height = 60;
            dataGridViewthongke.BorderStyle = BorderStyle.None;
            dataGridViewthongke.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewthongke.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewthongke.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewthongke.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewthongke.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewthongke.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewthongke.EnableHeadersVisualStyles = false;
            dataGridViewthongke.AllowUserToAddRows = false;
            dataGridViewthongke.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewthongke.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13);

            //dòng tiêu đề của bảng
            dataGridViewthongke.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewthongke.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void buttonTimKiem1_Click(object sender, EventArgs e)
        {
            if (radioButtonMaMH.Checked)
            {
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    // SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
                    SqlCommand command = new SqlCommand("SELECT magiohang as 'Mã giỏ hàng ',mahang as 'Mã hàng',tenhang as 'Tên hàng',soluong as 'Số lượng',gia as 'Giá',mskh as 'MSKH',ngay as 'Ngày' FROM dbo.LICHSU_GIOHANG");
                    dataGridViewthongke.DataSource = tk.layLICHSU_GIOHANG(command);
                }
                else
                {

                    try
                    {
                        int mamh = int.Parse(textBoxTimKiem.Text);
                        // SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA WHERE mahang=" + mamh);
                        SqlCommand command = new SqlCommand("SELECT magiohang as 'Mã giỏ hàng ', mahang as 'Mã hàng', tenhang as 'Tên hàng', soluong as 'Số lượng', gia as 'Giá', mskh as 'MSKH', ngay as 'Ngày' FROM dbo.LICHSU_GIOHANG WHERE mahang= " + mamh);
                        dataGridViewthongke.DataSource = tk.layLICHSU_GIOHANG(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    //SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
                    SqlCommand command = new SqlCommand("SELECT magiohang as 'Mã giỏ hàng ',mahang as 'Mã hàng',tenhang as 'Tên hàng',soluong as 'Số lượng',gia as 'Giá',mskh as 'MSKH',ngay as 'Ngày' FROM dbo.LICHSU_GIOHANG");
                    dataGridViewthongke.DataSource = tk.layLICHSU_GIOHANG(command);
                }
                else
                {
                    try
                    {
                        string mamh = textBoxTimKiem.Text.ToString();
                        //SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA WHERE tenhang LIKE '%" + mamh + "%'");
                        SqlCommand command = new SqlCommand("SELECT magiohang as 'Mã giỏ hàng ',mahang as 'Mã hàng',tenhang as 'Tên hàng',soluong as 'Số lượng',gia as 'Giá',mskh as 'MSKH',ngay as 'Ngày' FROM dbo.LICHSU_GIOHANG WHERE tenhang LIKE '%" + mamh + "%'");
                        dataGridViewthongke.DataSource = tk.layLICHSU_GIOHANG(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
       // private void dataGridViewAVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
       // {

       // }

        private void dataGridViewthongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTimKiem_Click(object sender, EventArgs e)
        {


        }
        private void radioButtonTenMH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMaMH_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      //  private void buttonTimKiem1_Click(object sender, EventArgs e)
      //  {

        //}
    }
}



