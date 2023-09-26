
namespace quản_lý_bán_hàng
{
    partial class QuanLyForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChamCong = new quản_lý_bán_hàng.customButton();
            this.customButton4 = new quản_lý_bán_hàng.customButton();
            this.customButton3 = new quản_lý_bán_hàng.customButton();
            this.customButton2 = new quản_lý_bán_hàng.customButton();
            this.customButton1 = new quản_lý_bán_hàng.customButton();
            this.buttonQuanLyNV = new quản_lý_bán_hàng.customButton();
            this.buttonXoaNV = new quản_lý_bán_hàng.customButton();
            this.ButtonThemNV = new quản_lý_bán_hàng.customButton();
            this.buttonDangXuat = new quản_lý_bán_hàng.customButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.buttonDangXuat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 75);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(24, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bạn đang đăng nhập dưới quyền admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.buttonQuanLyNV);
            this.panel2.Controls.Add(this.buttonXoaNV);
            this.panel2.Controls.Add(this.ButtonThemNV);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(2, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 143);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quản lý nhân viên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản lý cửa hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quản_lý_bán_hàng.Properties.Resources.cua_hang_tien_loi;
            this.pictureBox1.Location = new System.Drawing.Point(350, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonChamCong
            // 
            this.buttonChamCong.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonChamCong.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.buttonChamCong.BoderRadius = 40;
            this.buttonChamCong.BoderSize = 0;
            this.buttonChamCong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonChamCong.FlatAppearance.BorderSize = 0;
            this.buttonChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChamCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChamCong.ForeColor = System.Drawing.Color.White;
            this.buttonChamCong.Location = new System.Drawing.Point(12, 383);
            this.buttonChamCong.Name = "buttonChamCong";
            this.buttonChamCong.ReadOnly = false;
            this.buttonChamCong.Size = new System.Drawing.Size(324, 40);
            this.buttonChamCong.TabIndex = 10;
            this.buttonChamCong.Text = "Chấm công";
            this.buttonChamCong.TextColor = System.Drawing.Color.White;
            this.buttonChamCong.UseVisualStyleBackColor = false;
            this.buttonChamCong.Click += new System.EventHandler(this.buttonChamCong_Click);
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.DarkMagenta;
            this.customButton4.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.customButton4.BoderRadius = 40;
            this.customButton4.BoderSize = 0;
            this.customButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(12, 324);
            this.customButton4.Name = "customButton4";
            this.customButton4.ReadOnly = false;
            this.customButton4.Size = new System.Drawing.Size(324, 40);
            this.customButton4.TabIndex = 9;
            this.customButton4.Text = "Thống kê doanh thu";
            this.customButton4.TextColor = System.Drawing.Color.White;
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.DarkMagenta;
            this.customButton3.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.customButton3.BoderRadius = 40;
            this.customButton3.BoderSize = 0;
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(12, 261);
            this.customButton3.Name = "customButton3";
            this.customButton3.ReadOnly = false;
            this.customButton3.Size = new System.Drawing.Size(324, 40);
            this.customButton3.TabIndex = 8;
            this.customButton3.Text = "Thống kê mua sắm";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.DarkMagenta;
            this.customButton2.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.customButton2.BoderRadius = 39;
            this.customButton2.BoderSize = 0;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(12, 197);
            this.customButton2.Name = "customButton2";
            this.customButton2.ReadOnly = false;
            this.customButton2.Size = new System.Drawing.Size(324, 43);
            this.customButton2.TabIndex = 7;
            this.customButton2.Text = "Mã giảm giá";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkMagenta;
            this.customButton1.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.customButton1.BoderRadius = 39;
            this.customButton1.BoderSize = 0;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(12, 130);
            this.customButton1.Name = "customButton1";
            this.customButton1.ReadOnly = false;
            this.customButton1.Size = new System.Drawing.Size(324, 46);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "Kho hàng\r\n";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // buttonQuanLyNV
            // 
            this.buttonQuanLyNV.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonQuanLyNV.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.buttonQuanLyNV.BoderRadius = 40;
            this.buttonQuanLyNV.BoderSize = 0;
            this.buttonQuanLyNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonQuanLyNV.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyNV.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLyNV.Location = new System.Drawing.Point(27, 67);
            this.buttonQuanLyNV.Name = "buttonQuanLyNV";
            this.buttonQuanLyNV.ReadOnly = false;
            this.buttonQuanLyNV.Size = new System.Drawing.Size(302, 40);
            this.buttonQuanLyNV.TabIndex = 11;
            this.buttonQuanLyNV.Text = "Quản lý nhân viên";
            this.buttonQuanLyNV.TextColor = System.Drawing.Color.White;
            this.buttonQuanLyNV.UseVisualStyleBackColor = false;
            this.buttonQuanLyNV.Click += new System.EventHandler(this.buttonQuanLyNV_Click);
            // 
            // buttonXoaNV
            // 
            this.buttonXoaNV.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonXoaNV.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.buttonXoaNV.BoderRadius = 40;
            this.buttonXoaNV.BoderSize = 0;
            this.buttonXoaNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonXoaNV.FlatAppearance.BorderSize = 0;
            this.buttonXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoaNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaNV.ForeColor = System.Drawing.Color.White;
            this.buttonXoaNV.Location = new System.Drawing.Point(693, 67);
            this.buttonXoaNV.Name = "buttonXoaNV";
            this.buttonXoaNV.ReadOnly = false;
            this.buttonXoaNV.Size = new System.Drawing.Size(212, 40);
            this.buttonXoaNV.TabIndex = 11;
            this.buttonXoaNV.Text = "Xóa nhân viên";
            this.buttonXoaNV.TextColor = System.Drawing.Color.White;
            this.buttonXoaNV.UseVisualStyleBackColor = false;
            this.buttonXoaNV.Click += new System.EventHandler(this.buttonXoaNV_Click);
            // 
            // ButtonThemNV
            // 
            this.ButtonThemNV.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonThemNV.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.ButtonThemNV.BoderRadius = 40;
            this.ButtonThemNV.BoderSize = 0;
            this.ButtonThemNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonThemNV.FlatAppearance.BorderSize = 0;
            this.ButtonThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThemNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThemNV.ForeColor = System.Drawing.Color.White;
            this.ButtonThemNV.Location = new System.Drawing.Point(360, 67);
            this.ButtonThemNV.Name = "ButtonThemNV";
            this.ButtonThemNV.ReadOnly = false;
            this.ButtonThemNV.Size = new System.Drawing.Size(212, 40);
            this.ButtonThemNV.TabIndex = 11;
            this.ButtonThemNV.Text = "Thêm nhân viên";
            this.ButtonThemNV.TextColor = System.Drawing.Color.White;
            this.ButtonThemNV.UseVisualStyleBackColor = false;
            this.ButtonThemNV.Click += new System.EventHandler(this.ButtonThemNV_Click);
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.White;
            this.buttonDangXuat.BackgroundColor = System.Drawing.Color.White;
            this.buttonDangXuat.BoderRadius = 25;
            this.buttonDangXuat.BoderSize = 0;
            this.buttonDangXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDangXuat.FlatAppearance.BorderSize = 0;
            this.buttonDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangXuat.ForeColor = System.Drawing.Color.Black;
            this.buttonDangXuat.Location = new System.Drawing.Point(3, 47);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.ReadOnly = false;
            this.buttonDangXuat.Size = new System.Drawing.Size(72, 25);
            this.buttonDangXuat.TabIndex = 17;
            this.buttonDangXuat.Text = "Thoát\r\n";
            this.buttonDangXuat.TextColor = System.Drawing.Color.Black;
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonChamCong);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "QuanLyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.QuanLyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private customButton customButton1;
        private customButton customButton2;
        private customButton customButton3;
        private customButton customButton4;
        private System.Windows.Forms.Label label4;
        public customButton buttonChamCong;
        public customButton buttonXoaNV;
        public customButton ButtonThemNV;
        public customButton buttonQuanLyNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        public customButton buttonDangXuat;
    }
}