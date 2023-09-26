using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Size = System.Drawing.Size;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace quản_lý_bán_hàng
{
    public partial class KhoHangForm : Form
    {
        MATHANG mh = new MATHANG();
        public KhoHangForm()
        {
            InitializeComponent();
        }

        private void KhoHangForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
            dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewKhoHang.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewKhoHang.ReadOnly = true;
            dataGridViewKhoHang.RowTemplate.Height = 60;
            dataGridViewKhoHang.BorderStyle = BorderStyle.None;
            dataGridViewKhoHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKhoHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKhoHang.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewKhoHang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKhoHang.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewKhoHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewKhoHang.EnableHeadersVisualStyles = false;
            dataGridViewKhoHang.AllowUserToAddRows = false;
            dataGridViewKhoHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKhoHang.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewKhoHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewKhoHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void buttonXuatDS_Click(object sender, EventArgs e)
        {
            if(dataGridViewKhoHang.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                
                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridViewKhoHang.Columns.Count + 1 ; i++)
                {
                    excel.Cells[1, i] = dataGridViewKhoHang.Columns[i - 1].HeaderText;

                }
                for (int i = 0; i <dataGridViewKhoHang.Rows.Count; i++)
                {
                   for (int j = 0; j < dataGridViewKhoHang.Columns.Count; j ++)
                    {
                        excel.Cells[i + 2, j + 1] = dataGridViewKhoHang.Rows[i].Cells[j].Value.ToString();
                    }    
                }
                excel.Columns.AutoFit();
                excel.Visible = true;

            }    
        }
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (radioButtonMaMH.Checked)
            {
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
                    dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
                }
                else
                {

                    try
                    {
                        int mamh = int.Parse(textBoxTimKiem.Text);
                        SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA WHERE mahang=" + mamh);
                        dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
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
                    SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
                    dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
                }
                else
                {
                    try
                    {
                        string mamh = textBoxTimKiem.Text.ToString();
                        SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA WHERE tenhang LIKE '%" + mamh + "%'");
                        dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void dataGridViewKhoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
