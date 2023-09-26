
namespace quản_lý_bán_hàng
{
    partial class ThongKeMatHangForm
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
            this.buttonTimKiem1 = new quản_lý_bán_hàng.customButton();
            this.textBoxTimKiem = new quản_lý_bán_hàng.textBoxCustom();
            this.radioButtonTenMH = new System.Windows.Forms.RadioButton();
            this.radioButtonMaMH = new System.Windows.Forms.RadioButton();
            this.dataGridViewthongke = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonTimKiem1);
            this.panel1.Controls.Add(this.textBoxTimKiem);
            this.panel1.Controls.Add(this.radioButtonTenMH);
            this.panel1.Controls.Add(this.radioButtonMaMH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 112);
            this.panel1.TabIndex = 4;
            // 
            // buttonTimKiem1
            // 
            this.buttonTimKiem1.BackColor = System.Drawing.Color.Cyan;
            this.buttonTimKiem1.BackgroundColor = System.Drawing.Color.Cyan;
            this.buttonTimKiem1.BoderRadius = 40;
            this.buttonTimKiem1.BoderSize = 0;
            this.buttonTimKiem1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonTimKiem1.FlatAppearance.BorderSize = 0;
            this.buttonTimKiem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem1.ForeColor = System.Drawing.Color.Black;
            this.buttonTimKiem1.Location = new System.Drawing.Point(636, 30);
            this.buttonTimKiem1.Name = "buttonTimKiem1";
            this.buttonTimKiem1.ReadOnly = false;
            this.buttonTimKiem1.Size = new System.Drawing.Size(150, 40);
            this.buttonTimKiem1.TabIndex = 4;
            this.buttonTimKiem1.Text = "Tìm kiếm";
            this.buttonTimKiem1.TextColor = System.Drawing.Color.Black;
            this.buttonTimKiem1.UseVisualStyleBackColor = false;
            this.buttonTimKiem1.Click += new System.EventHandler(this.buttonTimKiem1_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTimKiem.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTimKiem.BorderSize = 1;
            this.textBoxTimKiem.Br = System.Drawing.Color.White;
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimKiem.Location = new System.Drawing.Point(366, 40);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.PasswordChar = '\0';
            this.textBoxTimKiem.ReadOnly = false;
            this.textBoxTimKiem.Size = new System.Drawing.Size(241, 30);
            this.textBoxTimKiem.TabIndex = 3;
            this.textBoxTimKiem.textboxRadius = 15;
            this.textBoxTimKiem.UseSystemPasswordChar = false;
            this.textBoxTimKiem.Click += new System.EventHandler(this.textBoxTimKiem_Click);
            // 
            // radioButtonTenMH
            // 
            this.radioButtonTenMH.AutoSize = true;
            this.radioButtonTenMH.Location = new System.Drawing.Point(501, 12);
            this.radioButtonTenMH.Name = "radioButtonTenMH";
            this.radioButtonTenMH.Size = new System.Drawing.Size(92, 18);
            this.radioButtonTenMH.TabIndex = 2;
            this.radioButtonTenMH.TabStop = true;
            this.radioButtonTenMH.Text = "Tên mặt hàng";
            this.radioButtonTenMH.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaMH
            // 
            this.radioButtonMaMH.AutoSize = true;
            this.radioButtonMaMH.Location = new System.Drawing.Point(377, 12);
            this.radioButtonMaMH.Name = "radioButtonMaMH";
            this.radioButtonMaMH.Size = new System.Drawing.Size(88, 18);
            this.radioButtonMaMH.TabIndex = 1;
            this.radioButtonMaMH.TabStop = true;
            this.radioButtonMaMH.Text = "Mã mặt hàng";
            this.radioButtonMaMH.UseVisualStyleBackColor = true;
            // 
            // dataGridViewthongke
            // 
            this.dataGridViewthongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewthongke.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewthongke.Location = new System.Drawing.Point(3, 118);
            this.dataGridViewthongke.Name = "dataGridViewthongke";
            this.dataGridViewthongke.RowHeadersWidth = 51;
            this.dataGridViewthongke.RowTemplate.Height = 50;
            this.dataGridViewthongke.Size = new System.Drawing.Size(1118, 369);
            this.dataGridViewthongke.TabIndex = 5;
            this.dataGridViewthongke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewthongke_CellContentClick);
            // 
            // ThongKeMatHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 511);
            this.Controls.Add(this.dataGridViewthongke);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "ThongKeMatHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê hàng đã bán";
            this.Load += new System.EventHandler(this.ThongKeMatHangForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public customButton buttonTimKiem1;
        public textBoxCustom textBoxTimKiem;
        public System.Windows.Forms.RadioButton radioButtonTenMH;
        public System.Windows.Forms.RadioButton radioButtonMaMH;
        private System.Windows.Forms.DataGridView dataGridViewthongke;
    }
}