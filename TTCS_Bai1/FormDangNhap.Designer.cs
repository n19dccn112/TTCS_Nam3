
namespace TTCS_Bai1
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.tenServer = new System.Windows.Forms.TextBox();
            this.matKhau = new System.Windows.Forms.TextBox();
            this.DangNhap = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.Lable_TenDangNhap = new System.Windows.Forms.Label();
            this.label_MatKhau = new System.Windows.Forms.Label();
            this.lable_TenServer = new System.Windows.Forms.Label();
            this.tenDangNhap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tenServer
            // 
            this.tenServer.Location = new System.Drawing.Point(187, 57);
            this.tenServer.Name = "tenServer";
            this.tenServer.Size = new System.Drawing.Size(200, 23);
            this.tenServer.TabIndex = 0;
            this.tenServer.Text = "HUYNHMY";
            // 
            // matKhau
            // 
            this.matKhau.Location = new System.Drawing.Point(187, 126);
            this.matKhau.Name = "matKhau";
            this.matKhau.PasswordChar = '*';
            this.matKhau.Size = new System.Drawing.Size(200, 23);
            this.matKhau.TabIndex = 2;
            this.matKhau.Text = "N19dccn112";
            this.matKhau.UseSystemPasswordChar = true;
            // 
            // DangNhap
            // 
            this.DangNhap.Location = new System.Drawing.Point(120, 196);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(100, 30);
            this.DangNhap.TabIndex = 3;
            this.DangNhap.Text = "Đăng nhập";
            this.DangNhap.UseVisualStyleBackColor = true;
            this.DangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(257, 196);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(100, 30);
            this.Thoat.TabIndex = 4;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Lable_TenDangNhap
            // 
            this.Lable_TenDangNhap.AutoSize = true;
            this.Lable_TenDangNhap.Location = new System.Drawing.Point(68, 93);
            this.Lable_TenDangNhap.Name = "Lable_TenDangNhap";
            this.Lable_TenDangNhap.Size = new System.Drawing.Size(101, 17);
            this.Lable_TenDangNhap.TabIndex = 5;
            this.Lable_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // label_MatKhau
            // 
            this.label_MatKhau.AutoSize = true;
            this.label_MatKhau.Location = new System.Drawing.Point(68, 129);
            this.label_MatKhau.Name = "label_MatKhau";
            this.label_MatKhau.Size = new System.Drawing.Size(64, 17);
            this.label_MatKhau.TabIndex = 6;
            this.label_MatKhau.Text = "Mật khẩu";
            // 
            // lable_TenServer
            // 
            this.lable_TenServer.AutoSize = true;
            this.lable_TenServer.BackColor = System.Drawing.Color.LightGray;
            this.lable_TenServer.Location = new System.Drawing.Point(68, 57);
            this.lable_TenServer.Name = "lable_TenServer";
            this.lable_TenServer.Size = new System.Drawing.Size(75, 17);
            this.lable_TenServer.TabIndex = 8;
            this.lable_TenServer.Text = "Tên Server";
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.Location = new System.Drawing.Point(187, 90);
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.Size = new System.Drawing.Size(200, 23);
            this.tenDangNhap.TabIndex = 1;
            this.tenDangNhap.Text = "sa";
            // 
            // FormDangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 325);
            this.Controls.Add(this.tenDangNhap);
            this.Controls.Add(this.lable_TenServer);
            this.Controls.Add(this.label_MatKhau);
            this.Controls.Add(this.Lable_TenDangNhap);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.matKhau);
            this.Controls.Add(this.tenServer);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormDangNhap.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(542, 365);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tenServer;
        private System.Windows.Forms.TextBox matKhau;
        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label Lable_TenDangNhap;
        private System.Windows.Forms.Label label_MatKhau;
        private System.Windows.Forms.Label lable_TenServer;
        private System.Windows.Forms.TextBox tenDangNhap;
    }
}

