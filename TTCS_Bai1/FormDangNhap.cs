using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTCS_Bai1
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (tenDangNhap.Text.Trim() == "" || matKhau.Text.Trim() == "" || tenServer.Text.Trim() == "")
            {
                MessageBox.Show("Tên Server, Tên đăng nhập và mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.servername = tenServer.Text.Trim();
            Program.username = tenDangNhap.Text.Trim();
            Program.password = matKhau.Text.Trim();
            if (Program.KetNoi() == 0)
            {
                return;
            }
            Program.conn.Close();
            try
            {
                FormMain form = new FormMain();
                form.Activate();
                form.ShowDialog();
                //Program.form.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
                                                    // bắt sk khi mới mở form
        {
            this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.Show();
            this.Activate();
        }
    }
}
