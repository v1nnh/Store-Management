﻿
namespace quản_lý_bán_hàng
{
    partial class HoaDonForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxNhanVien = new System.Windows.Forms.PictureBox();
            this.labelNhanVien = new System.Windows.Forms.Label();
            this.dateTimePickerNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMokigui = new quản_lý_bán_hàng.customButton();
            this.textBoxMaKH = new quản_lý_bán_hàng.textBoxCustom();
            this.buttonHuyDon = new quản_lý_bán_hàng.customButton();
            this.textBoxTongTien = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxTenNV = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxMaNV = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxMaHD = new quản_lý_bán_hàng.textBoxCustom();
            this.buttonKiGui = new quản_lý_bán_hàng.customButton();
            this.buttonThanhToan = new quản_lý_bán_hàng.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(2, 77);
            this.dataGridViewHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.RowHeadersWidth = 51;
            this.dataGridViewHoaDon.RowTemplate.Height = 24;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(797, 530);
            this.dataGridViewHoaDon.TabIndex = 0;
            this.dataGridViewHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtHóaĐơnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            this.chiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chiTiếtHóaĐơnToolStripMenuItem.Text = "Chi tiết hóa đơn";
            this.chiTiếtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtHóaĐơnToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonMokigui);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMaKH);
            this.groupBox1.Controls.Add(this.buttonHuyDon);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayThanhToan);
            this.groupBox1.Controls.Add(this.textBoxTongTien);
            this.groupBox1.Controls.Add(this.textBoxTenNV);
            this.groupBox1.Controls.Add(this.textBoxMaNV);
            this.groupBox1.Controls.Add(this.textBoxMaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonKiGui);
            this.groupBox1.Controls.Add(this.buttonThanhToan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(799, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(307, 609);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh toán";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 285);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã khách hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.pictureBoxNhanVien);
            this.panel3.Controls.Add(this.labelNhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 509);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 98);
            this.panel3.TabIndex = 12;
            // 
            // pictureBoxNhanVien
            // 
            this.pictureBoxNhanVien.BackColor = System.Drawing.Color.White;
            this.pictureBoxNhanVien.Location = new System.Drawing.Point(201, 2);
            this.pictureBoxNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNhanVien.Name = "pictureBoxNhanVien";
            this.pictureBoxNhanVien.Size = new System.Drawing.Size(99, 98);
            this.pictureBoxNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNhanVien.TabIndex = 10;
            this.pictureBoxNhanVien.TabStop = false;
            // 
            // labelNhanVien
            // 
            this.labelNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhanVien.Location = new System.Drawing.Point(4, 1);
            this.labelNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNhanVien.Name = "labelNhanVien";
            this.labelNhanVien.Size = new System.Drawing.Size(169, 67);
            this.labelNhanVien.TabIndex = 9;
            this.labelNhanVien.Text = "Nhân viên";
            // 
            // dateTimePickerNgayThanhToan
            // 
            this.dateTimePickerNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayThanhToan.Location = new System.Drawing.Point(124, 241);
            this.dateTimePickerNgayThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNgayThanhToan.Name = "dateTimePickerNgayThanhToan";
            this.dateTimePickerNgayThanhToan.Size = new System.Drawing.Size(152, 19);
            this.dateTimePickerNgayThanhToan.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày thanh toán";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã số nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 81);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(262, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // buttonMokigui
            // 
            this.buttonMokigui.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMokigui.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.buttonMokigui.BoderRadius = 32;
            this.buttonMokigui.BoderSize = 0;
            this.buttonMokigui.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonMokigui.FlatAppearance.BorderSize = 0;
            this.buttonMokigui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMokigui.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMokigui.ForeColor = System.Drawing.Color.White;
            this.buttonMokigui.Location = new System.Drawing.Point(39, 436);
            this.buttonMokigui.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMokigui.Name = "buttonMokigui";
            this.buttonMokigui.ReadOnly = false;
            this.buttonMokigui.Size = new System.Drawing.Size(245, 32);
            this.buttonMokigui.TabIndex = 16;
            this.buttonMokigui.Text = "Mở kí gửi";
            this.buttonMokigui.TextColor = System.Drawing.Color.White;
            this.buttonMokigui.UseVisualStyleBackColor = false;
            this.buttonMokigui.Click += new System.EventHandler(this.buttonMokigui_Click);
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaKH.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaKH.BorderSize = 1;
            this.textBoxMaKH.Br = System.Drawing.Color.White;
            this.textBoxMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxMaKH.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaKH.Location = new System.Drawing.Point(124, 34);
            this.textBoxMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.PasswordChar = '\0';
            this.textBoxMaKH.ReadOnly = false;
            this.textBoxMaKH.Size = new System.Drawing.Size(152, 24);
            this.textBoxMaKH.TabIndex = 14;
            this.textBoxMaKH.textboxRadius = 12;
            this.textBoxMaKH.UseSystemPasswordChar = false;
            // 
            // buttonHuyDon
            // 
            this.buttonHuyDon.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHuyDon.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.buttonHuyDon.BoderRadius = 32;
            this.buttonHuyDon.BoderSize = 0;
            this.buttonHuyDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonHuyDon.FlatAppearance.BorderSize = 0;
            this.buttonHuyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuyDon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuyDon.ForeColor = System.Drawing.Color.White;
            this.buttonHuyDon.Location = new System.Drawing.Point(172, 383);
            this.buttonHuyDon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHuyDon.Name = "buttonHuyDon";
            this.buttonHuyDon.ReadOnly = false;
            this.buttonHuyDon.Size = new System.Drawing.Size(112, 32);
            this.buttonHuyDon.TabIndex = 13;
            this.buttonHuyDon.Text = "Hủy đơn ";
            this.buttonHuyDon.TextColor = System.Drawing.Color.White;
            this.buttonHuyDon.UseVisualStyleBackColor = false;
            this.buttonHuyDon.Click += new System.EventHandler(this.buttonHuyDon_Click);
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTongTien.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTongTien.BorderSize = 1;
            this.textBoxTongTien.Br = System.Drawing.Color.White;
            this.textBoxTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTongTien.ForeColor = System.Drawing.Color.Black;
            this.textBoxTongTien.Location = new System.Drawing.Point(124, 280);
            this.textBoxTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.PasswordChar = '\0';
            this.textBoxTongTien.ReadOnly = false;
            this.textBoxTongTien.Size = new System.Drawing.Size(129, 24);
            this.textBoxTongTien.TabIndex = 6;
            this.textBoxTongTien.textboxRadius = 12;
            this.textBoxTongTien.UseSystemPasswordChar = false;
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTenNV.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTenNV.BorderSize = 1;
            this.textBoxTenNV.Br = System.Drawing.Color.White;
            this.textBoxTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTenNV.ForeColor = System.Drawing.Color.Black;
            this.textBoxTenNV.Location = new System.Drawing.Point(124, 196);
            this.textBoxTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.PasswordChar = '\0';
            this.textBoxTenNV.ReadOnly = false;
            this.textBoxTenNV.Size = new System.Drawing.Size(152, 24);
            this.textBoxTenNV.TabIndex = 6;
            this.textBoxTenNV.textboxRadius = 12;
            this.textBoxTenNV.UseSystemPasswordChar = false;
            this.textBoxTenNV.Click += new System.EventHandler(this.textBoxTenNV_Click);
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaNV.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaNV.BorderSize = 1;
            this.textBoxMaNV.Br = System.Drawing.Color.White;
            this.textBoxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxMaNV.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaNV.Location = new System.Drawing.Point(124, 143);
            this.textBoxMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.PasswordChar = '\0';
            this.textBoxMaNV.ReadOnly = false;
            this.textBoxMaNV.Size = new System.Drawing.Size(152, 24);
            this.textBoxMaNV.TabIndex = 6;
            this.textBoxMaNV.textboxRadius = 12;
            this.textBoxMaNV.UseSystemPasswordChar = false;
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaHD.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaHD.BorderSize = 1;
            this.textBoxMaHD.Br = System.Drawing.Color.White;
            this.textBoxMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxMaHD.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaHD.Location = new System.Drawing.Point(124, 92);
            this.textBoxMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.PasswordChar = '\0';
            this.textBoxMaHD.ReadOnly = false;
            this.textBoxMaHD.Size = new System.Drawing.Size(152, 24);
            this.textBoxMaHD.TabIndex = 6;
            this.textBoxMaHD.textboxRadius = 12;
            this.textBoxMaHD.UseSystemPasswordChar = false;
            // 
            // buttonKiGui
            // 
            this.buttonKiGui.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonKiGui.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.buttonKiGui.BoderRadius = 32;
            this.buttonKiGui.BoderSize = 0;
            this.buttonKiGui.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonKiGui.FlatAppearance.BorderSize = 0;
            this.buttonKiGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKiGui.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKiGui.ForeColor = System.Drawing.Color.White;
            this.buttonKiGui.Location = new System.Drawing.Point(39, 383);
            this.buttonKiGui.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKiGui.Name = "buttonKiGui";
            this.buttonKiGui.ReadOnly = false;
            this.buttonKiGui.Size = new System.Drawing.Size(112, 32);
            this.buttonKiGui.TabIndex = 4;
            this.buttonKiGui.Text = "Kí gửi";
            this.buttonKiGui.TextColor = System.Drawing.Color.White;
            this.buttonKiGui.UseVisualStyleBackColor = false;
            this.buttonKiGui.Click += new System.EventHandler(this.buttonKiGui_Click);
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonThanhToan.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.buttonThanhToan.BoderRadius = 32;
            this.buttonThanhToan.BoderSize = 0;
            this.buttonThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonThanhToan.FlatAppearance.BorderSize = 0;
            this.buttonThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThanhToan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhToan.ForeColor = System.Drawing.Color.White;
            this.buttonThanhToan.Location = new System.Drawing.Point(38, 335);
            this.buttonThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.ReadOnly = false;
            this.buttonThanhToan.Size = new System.Drawing.Size(245, 32);
            this.buttonThanhToan.TabIndex = 2;
            this.buttonThanhToan.Text = "Thanh toán";
            this.buttonThanhToan.TextColor = System.Drawing.Color.White;
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HoaDonForm";
            this.Size = new System.Drawing.Size(1106, 609);
            this.Load += new System.EventHandler(this.HoaDonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label labelNhanVien;
        public System.Windows.Forms.PictureBox pictureBoxNhanVien;
        public customButton buttonHuyDon;
        public customButton buttonKiGui;
        public customButton buttonThanhToan;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayThanhToan;
        public textBoxCustom textBoxTongTien;
        public textBoxCustom textBoxTenNV;
        public textBoxCustom textBoxMaNV;
        public textBoxCustom textBoxMaHD;
        private System.Windows.Forms.Label label7;
        public textBoxCustom textBoxMaKH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
        public customButton buttonMokigui;
        private System.Windows.Forms.Label label8;
    }
}
