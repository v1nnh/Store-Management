﻿
namespace quản_lý_bán_hàng
{
    partial class CheckmaAdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.customButton2 = new quản_lý_bán_hàng.customButton();
            this.customButton1 = new quản_lý_bán_hàng.customButton();
            this.textBoxCustom1 = new quản_lý_bán_hàng.textBoxCustom();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã xác nhận";
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.customButton2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.customButton2.BoderRadius = 40;
            this.customButton2.BoderSize = 0;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton2.ForeColor = System.Drawing.Color.Black;
            this.customButton2.Location = new System.Drawing.Point(33, 110);
            this.customButton2.Name = "customButton2";
            this.customButton2.ReadOnly = false;
            this.customButton2.Size = new System.Drawing.Size(121, 40);
            this.customButton2.TabIndex = 4;
            this.customButton2.Text = "Thoát";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.customButton1.BoderRadius = 40;
            this.customButton1.BoderSize = 0;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(202, 110);
            this.customButton1.Name = "customButton1";
            this.customButton1.ReadOnly = false;
            this.customButton1.Size = new System.Drawing.Size(121, 40);
            this.customButton1.TabIndex = 5;
            this.customButton1.Text = "Xác nhận";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxCustom1.BorderColor = System.Drawing.Color.Gray;
            this.textBoxCustom1.BorderSize = 1;
            this.textBoxCustom1.Br = System.Drawing.Color.White;
            this.textBoxCustom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxCustom1.ForeColor = System.Drawing.Color.Black;
            this.textBoxCustom1.Location = new System.Drawing.Point(78, 59);
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.PasswordChar = '*';
            this.textBoxCustom1.ReadOnly = false;
            this.textBoxCustom1.Size = new System.Drawing.Size(206, 30);
            this.textBoxCustom1.TabIndex = 3;
            this.textBoxCustom1.textboxRadius = 12;
            this.textBoxCustom1.UseSystemPasswordChar = false;
            this.textBoxCustom1.Click += new System.EventHandler(this.textBoxCustom1_Click);
            // 
            // CheckmaAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(357, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.textBoxCustom1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "CheckmaAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiểm tra ";
            this.Load += new System.EventHandler(this.CheckmaAdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private customButton customButton2;
        private customButton customButton1;
        private textBoxCustom textBoxCustom1;
    }
}