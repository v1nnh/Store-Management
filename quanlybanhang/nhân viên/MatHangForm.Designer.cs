﻿
namespace quản_lý_bán_hàng
{
    partial class MatHangForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMaHang = new quản_lý_bán_hàng.textBoxCustom();
            this.pictureBoxNhanVien = new System.Windows.Forms.PictureBox();
            this.buttonUpload = new quản_lý_bán_hàng.customButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxHinh = new System.Windows.Forms.PictureBox();
            this.textBoxSL = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxGia = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxTenMH = new quản_lý_bán_hàng.textBoxCustom();
            this.comboBoxLoaiHang = new System.Windows.Forms.ComboBox();
            this.buttonSua = new quản_lý_bán_hàng.customButton();
            this.buttonXoa = new quản_lý_bán_hàng.customButton();
            this.buttonNhap = new quản_lý_bán_hàng.customButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNhanVien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelThongTinKho = new System.Windows.Forms.Label();
            this.dataGridViewMatHang = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new quản_lý_bán_hàng.customButton();
            this.textBoxTimKiem = new quản_lý_bán_hàng.textBoxCustom();
            this.radioButtonTenMH = new System.Windows.Forms.RadioButton();
            this.radioButtonMaMH = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(824, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(282, 609);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxMaHang);
            this.panel1.Controls.Add(this.pictureBoxNhanVien);
            this.panel1.Controls.Add(this.buttonUpload);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBoxHinh);
            this.panel1.Controls.Add(this.textBoxSL);
            this.panel1.Controls.Add(this.textBoxGia);
            this.panel1.Controls.Add(this.textBoxTenMH);
            this.panel1.Controls.Add(this.comboBoxLoaiHang);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonNhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.panel1.Location = new System.Drawing.Point(2, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 593);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "VNĐ";
            // 
            // textBoxMaHang
            // 
            this.textBoxMaHang.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaHang.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaHang.BorderSize = 1;
            this.textBoxMaHang.Br = System.Drawing.Color.White;
            this.textBoxMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxMaHang.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaHang.Location = new System.Drawing.Point(107, 12);
            this.textBoxMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaHang.Name = "textBoxMaHang";
            this.textBoxMaHang.PasswordChar = '\0';
            this.textBoxMaHang.ReadOnly = false;
            this.textBoxMaHang.Size = new System.Drawing.Size(135, 24);
            this.textBoxMaHang.TabIndex = 10;
            this.textBoxMaHang.textboxRadius = 12;
            this.textBoxMaHang.UseSystemPasswordChar = false;
            // 
            // pictureBoxNhanVien
            // 
            this.pictureBoxNhanVien.BackColor = System.Drawing.Color.White;
            this.pictureBoxNhanVien.Location = new System.Drawing.Point(178, 495);
            this.pictureBoxNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNhanVien.Name = "pictureBoxNhanVien";
            this.pictureBoxNhanVien.Size = new System.Drawing.Size(99, 98);
            this.pictureBoxNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNhanVien.TabIndex = 8;
            this.pictureBoxNhanVien.TabStop = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonUpload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonUpload.BoderRadius = 24;
            this.buttonUpload.BoderSize = 0;
            this.buttonUpload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonUpload.FlatAppearance.BorderSize = 0;
            this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpload.ForeColor = System.Drawing.Color.White;
            this.buttonUpload.Location = new System.Drawing.Point(107, 266);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.ReadOnly = false;
            this.buttonUpload.Size = new System.Drawing.Size(135, 24);
            this.buttonUpload.TabIndex = 7;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.TextColor = System.Drawing.Color.White;
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 363);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // pictureBoxHinh
            // 
            this.pictureBoxHinh.BackColor = System.Drawing.Color.White;
            this.pictureBoxHinh.Location = new System.Drawing.Point(107, 154);
            this.pictureBoxHinh.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHinh.Name = "pictureBoxHinh";
            this.pictureBoxHinh.Size = new System.Drawing.Size(135, 108);
            this.pictureBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinh.TabIndex = 5;
            this.pictureBoxHinh.TabStop = false;
            // 
            // textBoxSL
            // 
            this.textBoxSL.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSL.BorderColor = System.Drawing.Color.Gray;
            this.textBoxSL.BorderSize = 1;
            this.textBoxSL.Br = System.Drawing.Color.White;
            this.textBoxSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxSL.ForeColor = System.Drawing.Color.Black;
            this.textBoxSL.Location = new System.Drawing.Point(107, 358);
            this.textBoxSL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.PasswordChar = '\0';
            this.textBoxSL.ReadOnly = false;
            this.textBoxSL.Size = new System.Drawing.Size(135, 24);
            this.textBoxSL.TabIndex = 4;
            this.textBoxSL.textboxRadius = 12;
            this.textBoxSL.UseSystemPasswordChar = false;
            // 
            // textBoxGia
            // 
            this.textBoxGia.BackColor = System.Drawing.Color.Transparent;
            this.textBoxGia.BorderColor = System.Drawing.Color.Gray;
            this.textBoxGia.BorderSize = 1;
            this.textBoxGia.Br = System.Drawing.Color.White;
            this.textBoxGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxGia.ForeColor = System.Drawing.Color.Black;
            this.textBoxGia.Location = new System.Drawing.Point(107, 307);
            this.textBoxGia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.PasswordChar = '\0';
            this.textBoxGia.ReadOnly = false;
            this.textBoxGia.Size = new System.Drawing.Size(113, 24);
            this.textBoxGia.TabIndex = 4;
            this.textBoxGia.textboxRadius = 12;
            this.textBoxGia.UseSystemPasswordChar = false;
            this.textBoxGia.Click += new System.EventHandler(this.textBoxGia_Click);
            // 
            // textBoxTenMH
            // 
            this.textBoxTenMH.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTenMH.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTenMH.BorderSize = 1;
            this.textBoxTenMH.Br = System.Drawing.Color.White;
            this.textBoxTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTenMH.ForeColor = System.Drawing.Color.Black;
            this.textBoxTenMH.Location = new System.Drawing.Point(107, 106);
            this.textBoxTenMH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenMH.Name = "textBoxTenMH";
            this.textBoxTenMH.PasswordChar = '\0';
            this.textBoxTenMH.ReadOnly = false;
            this.textBoxTenMH.Size = new System.Drawing.Size(135, 24);
            this.textBoxTenMH.TabIndex = 4;
            this.textBoxTenMH.textboxRadius = 12;
            this.textBoxTenMH.UseSystemPasswordChar = false;
            this.textBoxTenMH.Click += new System.EventHandler(this.textBoxCustom1_Click);
            // 
            // comboBoxLoaiHang
            // 
            this.comboBoxLoaiHang.FormattingEnabled = true;
            this.comboBoxLoaiHang.Items.AddRange(new object[] {
            "Khô",
            "Đông lạnh",
            "Gia dụng",
            "Nước"});
            this.comboBoxLoaiHang.Location = new System.Drawing.Point(107, 58);
            this.comboBoxLoaiHang.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLoaiHang.Name = "comboBoxLoaiHang";
            this.comboBoxLoaiHang.Size = new System.Drawing.Size(136, 21);
            this.comboBoxLoaiHang.TabIndex = 3;
            this.comboBoxLoaiHang.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiHang_SelectedIndexChanged);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonSua.BoderRadius = 32;
            this.buttonSua.BoderSize = 0;
            this.buttonSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(153, 401);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.ReadOnly = false;
            this.buttonSua.Size = new System.Drawing.Size(102, 32);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Điều chỉnh";
            this.buttonSua.TextColor = System.Drawing.Color.White;
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXoa.BoderRadius = 32;
            this.buttonXoa.BoderSize = 0;
            this.buttonXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(21, 448);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.ReadOnly = false;
            this.buttonXoa.Size = new System.Drawing.Size(100, 32);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Hủy Hàng";
            this.buttonXoa.TextColor = System.Drawing.Color.White;
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonNhap
            // 
            this.buttonNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonNhap.BoderRadius = 32;
            this.buttonNhap.BoderSize = 0;
            this.buttonNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonNhap.FlatAppearance.BorderSize = 0;
            this.buttonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhap.ForeColor = System.Drawing.Color.White;
            this.buttonNhap.Location = new System.Drawing.Point(20, 401);
            this.buttonNhap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNhap.Name = "buttonNhap";
            this.buttonNhap.ReadOnly = false;
            this.buttonNhap.Size = new System.Drawing.Size(100, 32);
            this.buttonNhap.TabIndex = 2;
            this.buttonNhap.Text = "Nhập vào kho";
            this.buttonNhap.TextColor = System.Drawing.Color.White;
            this.buttonNhap.UseVisualStyleBackColor = false;
            this.buttonNhap.Click += new System.EventHandler(this.buttonNhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá/sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên mặt hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.labelNhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 495);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 98);
            this.panel3.TabIndex = 11;
            // 
            // labelNhanVien
            // 
            this.labelNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNhanVien.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhanVien.Location = new System.Drawing.Point(4, 1);
            this.labelNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNhanVien.Name = "labelNhanVien";
            this.labelNhanVien.Size = new System.Drawing.Size(169, 67);
            this.labelNhanVien.TabIndex = 9;
            this.labelNhanVien.Text = "Nhân viên";
            this.labelNhanVien.Click += new System.EventHandler(this.labelNhanVien_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.labelThongTinKho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 564);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 45);
            this.panel2.TabIndex = 2;
            // 
            // labelThongTinKho
            // 
            this.labelThongTinKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelThongTinKho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelThongTinKho.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongTinKho.Location = new System.Drawing.Point(45, 13);
            this.labelThongTinKho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThongTinKho.Name = "labelThongTinKho";
            this.labelThongTinKho.Size = new System.Drawing.Size(229, 20);
            this.labelThongTinKho.TabIndex = 0;
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatHang.Location = new System.Drawing.Point(2, 95);
            this.dataGridViewMatHang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 51;
            this.dataGridViewMatHang.RowTemplate.Height = 24;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(820, 466);
            this.dataGridViewMatHang.TabIndex = 1;
            this.dataGridViewMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.buttonTimKiem);
            this.panel4.Controls.Add(this.textBoxTimKiem);
            this.panel4.Controls.Add(this.radioButtonTenMH);
            this.panel4.Controls.Add(this.radioButtonMaMH);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(824, 90);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonTimKiem.BoderRadius = 32;
            this.buttonTimKiem.BoderSize = 0;
            this.buttonTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonTimKiem.FlatAppearance.BorderSize = 0;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiem.Location = new System.Drawing.Point(492, 41);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.ReadOnly = false;
            this.buttonTimKiem.Size = new System.Drawing.Size(112, 32);
            this.buttonTimKiem.TabIndex = 8;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.TextColor = System.Drawing.Color.White;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTimKiem.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTimKiem.BorderSize = 1;
            this.textBoxTimKiem.Br = System.Drawing.Color.White;
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimKiem.Location = new System.Drawing.Point(298, 50);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.PasswordChar = '\0';
            this.textBoxTimKiem.ReadOnly = false;
            this.textBoxTimKiem.Size = new System.Drawing.Size(181, 24);
            this.textBoxTimKiem.TabIndex = 7;
            this.textBoxTimKiem.textboxRadius = 12;
            this.textBoxTimKiem.UseSystemPasswordChar = false;
            // 
            // radioButtonTenMH
            // 
            this.radioButtonTenMH.AutoSize = true;
            this.radioButtonTenMH.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.radioButtonTenMH.Location = new System.Drawing.Point(391, 27);
            this.radioButtonTenMH.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTenMH.Name = "radioButtonTenMH";
            this.radioButtonTenMH.Size = new System.Drawing.Size(92, 18);
            this.radioButtonTenMH.TabIndex = 6;
            this.radioButtonTenMH.TabStop = true;
            this.radioButtonTenMH.Text = "Tên mặt hàng";
            this.radioButtonTenMH.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaMH
            // 
            this.radioButtonMaMH.AutoSize = true;
            this.radioButtonMaMH.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.radioButtonMaMH.Location = new System.Drawing.Point(298, 27);
            this.radioButtonMaMH.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMaMH.Name = "radioButtonMaMH";
            this.radioButtonMaMH.Size = new System.Drawing.Size(88, 18);
            this.radioButtonMaMH.TabIndex = 5;
            this.radioButtonMaMH.TabStop = true;
            this.radioButtonMaMH.Text = "Mã mặt hàng";
            this.radioButtonMaMH.UseVisualStyleBackColor = true;
            // 
            // MatHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MatHangForm";
            this.Size = new System.Drawing.Size(1106, 609);
            this.Load += new System.EventHandler(this.MatHangForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelThongTinKho;
        public System.Windows.Forms.DataGridView dataGridViewMatHang;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pictureBoxHinh;
        public textBoxCustom textBoxSL;
        public textBoxCustom textBoxGia;
        public textBoxCustom textBoxTenMH;
        public System.Windows.Forms.ComboBox comboBoxLoaiHang;
        public customButton buttonSua;
        public customButton buttonXoa;
        public customButton buttonNhap;
        public customButton buttonUpload;
        public System.Windows.Forms.Label labelNhanVien;
        public System.Windows.Forms.PictureBox pictureBoxNhanVien;
        public textBoxCustom textBoxMaHang;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        public customButton buttonTimKiem;
        public textBoxCustom textBoxTimKiem;
        public System.Windows.Forms.RadioButton radioButtonTenMH;
        public System.Windows.Forms.RadioButton radioButtonMaMH;
    }
}
