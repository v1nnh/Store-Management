using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Size = System.Drawing.Size;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace quản_lý_bán_hàng
{
    public partial class ChamCongForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        CHAMCONG chamcong = new CHAMCONG();
        public ChamCongForm()
        {
            InitializeComponent();
        }

        private void ChamCongForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
            dataGridViewChamCong.DataSource = nv.layNV(command);
            dataGridViewChamCong.ReadOnly = true;
            dataGridViewChamCong.RowTemplate.Height = 60;
            dataGridViewChamCong.BorderStyle = BorderStyle.None;
            dataGridViewChamCong.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewChamCong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewChamCong.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewChamCong.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewChamCong.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewChamCong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewChamCong.EnableHeadersVisualStyles = false;
            dataGridViewChamCong.AllowUserToAddRows = false;
            dataGridViewChamCong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (radioButtonCo.Checked)
            {
                if (radioButtonMaNV.Checked)
                {
                    if ((textBoxTimKiem.Text.Trim() == ""))
                    {
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                    else
                    {
                        try
                        {
                            int msnv = int.Parse(textBoxTimKiem.Text);
                            string giovao = dateTimePicker1.Value.ToString();
                            SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG WHERE msnv=" + msnv + "AND giovao=@gv");
                            command.Parameters.Add("@gv", SqlDbType.VarChar).Value = giovao;
                            dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (radioButtonTen.Checked)
                {
                    if ((textBoxTimKiem.Text.Trim() == ""))
                    {
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                    else
                    {


                        string hoten = textBoxTimKiem.Text;
                        string giovao = dateTimePicker1.Value.ToString();
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG WHERE hoten LIKE '%" + hoten + "%' AND giovao=@gv");
                        command.Parameters.Add("@gv", SqlDbType.VarChar).Value = giovao;
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                    dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                }
            }
            else
            {
                if (radioButtonTen.Checked)
                {
                    if ((textBoxTimKiem.Text.Trim() == ""))
                    {
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                    else
                    {

                        string hoten = textBoxTimKiem.Text.ToString();
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG WHERE hoten LIKE '%" + hoten + "%'");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);

                    }
                }
                else
                {
                    if ((textBoxTimKiem.Text.Trim() == ""))
                    {
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                    else
                    {

                        try
                        {
                            int msnv = int.Parse(textBoxTimKiem.Text);
                            SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG WHERE msnv=" + msnv);
                            dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        
        }

       private void customButton1_Click(object sender, EventArgs e)
       {
            PrintDialog printDlg = new PrintDialog();
           PrintDocument printDoc = new PrintDocument();
           printDoc.DocumentName = "Print Document";
           printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
           if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (dataGridViewChamCong.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridViewChamCong.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = dataGridViewChamCong.Columns[i - 1].HeaderText;

                }
                for (int i = 0; i < dataGridViewChamCong.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewChamCong.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dataGridViewChamCong.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonCo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonKhong_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
