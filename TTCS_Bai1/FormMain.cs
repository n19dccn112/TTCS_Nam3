using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace TTCS_Bai1
{
    public partial class FormMain : Form
    {
        int bansaoluu;
        String deviceName;
        int vitri = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.databases_Name' table. You can move, or remove it, as needed.
            this.databases_nameTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databases_nameTableAdapter.Fill(this.dataSet.databases_Name);

            HideNullData();
        }
        private void dataGridViewCSDL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (databasesNameBindingSource.Position == -1 || databasesNameBindingSource.Count == 0 || databasesNameBindingSource.DataSource == null)
                    textBox_name.Text = "";
                else textBox_name.Text = ((DataRowView)databasesNameBindingSource[databasesNameBindingSource.Position])["name"].ToString();
                LoadLaiTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void luu(object sender, EventArgs e)
        {
            String StrBackup;
            if (textBox_name.Text.Trim() == "" || deviceName == "") return;
            CheckDeviceExist();
            StrBackup = "BACKUP DATABASE " + textBox_name.Text.Trim() + " TO " + deviceName;
            if (checkBox_PhucHoiTheoTG.Checked == true)
                if (MessageBox.Show("Bạn thật sự muốn xóa các bản sao lưu cũ.", " Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    StrBackup = StrBackup + " WITH INIT";
                else
                    return;
            //ham program ExecSqlNonquery
            int err = Program.ExecSqlNonQuery(StrBackup, Program.connstr, "");
            if (err != 0)
            {
                MessageBox.Show("Lỗi lưu cơ sở dữ liệu" + textBox_name.Text);
                return;
            }
            MessageBox.Show("Đã lưu cơ sở dữ liệu");

            LoadLaiTrang();
        }
        private void HideNullData()
        {
            btn_Luu.Enabled = btn_PhucHoi.Enabled = btn_PhucHoiTheoTG.Enabled = checkBox_PhucHoiTheoTG.Enabled = false;
            btn_TaoThietBiSaoLuu.Enabled = btn_LamMoi.Enabled = btn_XoaDia.Enabled = btn_XoaMotBan.Enabled = false;
            label_Ngaygio.Enabled = dateStop.Enabled = timeStop.Enabled = false;
        }
        private void ShowDevice()
        {
            btn_Luu.Enabled = btn_PhucHoi.Enabled = btn_PhucHoiTheoTG.Enabled = checkBox_PhucHoiTheoTG.Enabled = btn_LamMoi.Enabled = false;
            btn_TaoThietBiSaoLuu.Enabled = true;
        }
        private void HideDevice()
        {
            btn_Luu.Enabled = btn_PhucHoi.Enabled = btn_PhucHoiTheoTG.Enabled = checkBox_PhucHoiTheoTG.Enabled = btn_LamMoi.Enabled = true;
            btn_TaoThietBiSaoLuu.Enabled = false;
        }
        private void CheckDeviceExist()
        {
            String StrTendevice = "select  COUNT(name)  from  sys.backup_devices  WHERE  name  =  N'DEV_" + textBox_name.Text.Trim() + "'";
            Program.myreader = Program.ExecSqlDataReader(StrTendevice);
            if (Program.myreader == null) return;
            Program.myreader.Read();

            //có device thì ẩn btn newdevice
            if (Program.myreader.GetInt32(0) == 1)
            {
                HideDevice();
                deviceName = "DEV_" + textBox_name.Text.Trim();

            }
            // chưa có device chỉ hiện newdevice vs thoát
            else ShowDevice();
                
            Program.myreader.Close();
        }
        private void LoadLaiTrang()
        {
            if (textBox_name.Text.Trim() == "") return;
            try
            {

                this.sp_backup_dateTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_backup_dateTableAdapter.Fill(this.dataSet.sp_backup_date, textBox_name.Text.Trim());


                CheckDeviceExist();
                // có bảng sao lưu
                if (spbackupdateBindingSource.Count > 0)
                {
                    btn_XoaMotBan.Enabled = true;
                    btn_XoaDia.Enabled = true;
                    bansaoluu = int.Parse(((DataRowView)spbackupdateBindingSource[0])["position"].ToString());
                }
                else // không có bản sao lưu nào
                {
                    btn_XoaMotBan.Enabled = false;
                    btn_XoaDia.Enabled = false;
                    bansaoluu = 0;
                }
                textBox_BangSaoLuu.Text = bansaoluu.ToString();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void phucHoi(object sender, EventArgs e)
        {
            int err;
            LoadLaiTrang();
            // chạy sp rồi dếm dòng
            if (this.spbackupdateBindingSource.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (bansaoluu == 0)
            {
                MessageBox.Show("Chưa có 1 bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();//đóng kết nối

            if (textBox_name .Text.Trim() == "" || deviceName == "") return;
            if (checkBox_PhucHoiTheoTG.Checked == false)
            {
                label_Ngaygio.Enabled = dateStop.Enabled = timeStop.Enabled = false;

                String strRestore = " ALTER DATABASE " + textBox_name.Text.Trim()
                    + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE "
                    + " USE tempdb "
                    // cú pháp RESTORE DATABASE
                    + "RESTORE DATABASE " + textBox_name.Text.Trim()
                    // from backup_device
                    + " FROM   " + deviceName + " WITH FILE =  " + bansaoluu + ", REPLACE  "
                    + " ALTER DATABASE  " + textBox_name.Text.Trim() + " SET MULTI_USER";


                if (MessageBox.Show("Bạn chắc chắc muốn phục hồi database ", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                    if (err == 0)
                        MessageBox.Show("Phục hồi thành công", "", MessageBoxButtons.OK);
                }
                else
                    return;

            }


            else
            {
                label_Ngaygio.Enabled = dateStop.Enabled = timeStop.Enabled = true;

                DateTime ngaygiobk = (DateTime)((DataRowView)spbackupdateBindingSource[0])["backup_start_date"];
                string strThoiDiemStopAt = dateStop.DateTime.ToString("yyyy-MM-dd") + " " + timeStop.Time.ToString("HH:mm:ss");
                Console.Write(((DataRowView)spbackupdateBindingSource[0])["position"].ToString());
                DateTime ThoiDiemStopAt;
                ThoiDiemStopAt = DateTime.Parse(strThoiDiemStopAt);
                if ((dateStop.DateTime.Date < ngaygiobk.Date) ||
                           (dateStop.DateTime.Date == ngaygiobk.Date && ThoiDiemStopAt.TimeOfDay.Ticks < ngaygiobk.TimeOfDay.Ticks))
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải sau bản sao luu đã chọn.", "", MessageBoxButtons.OK);
                    return;
                }
                if (ThoiDiemStopAt > DateTime.Now)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại", "", MessageBoxButtons.OK);
                    return;
                }
                if ((MessageBox.Show("Bạn chắc chắn muốn phục hồi database " + textBox_name.Text + " về ngày " +
                    ThoiDiemStopAt + " ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                    
                    String CheckTime = dateStop.DateTime.ToString("yyyy-MM-dd") + " " + timeStop.Time.ToString("HH:mm:ss");
                    String StrTendevice = "use " + textBox_name.Text.Trim() +
                        "\nselect  [Begin Time]  from  fn_dblog(null,null)" +
                        "where[Begin Time] < '" + CheckTime + "'";
                    Program.myreader = Program.ExecSqlDataReader(StrTendevice);

                    if (Program.myreader == null) return;
                    Program.myreader.Read();

                    
                    if (!Program.myreader.Read())
                    {
                        MessageBox.Show("Không tìm thấy bản log trong lịch sử.", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            //restore về thời điểm người dùng nhập
                            String strLenh = "EXEC sp_phucHoiTheoTHoiGian " + textBox_name.Text.Trim() + ", \'" + strThoiDiemStopAt + "\', \'" +
                                            Program.strDefaultPath  + "DEV_" + textBox_name.Text.Trim() + ".bak\'" + ", " + bansaoluu;
                            MessageBox.Show(strLenh);
                            err = Program.ExecSqlNonQuery(strLenh, Program.connstr, "Lỗi phục hồi csdl.");
                            if (err == 0)   MessageBox.Show("Phục hồi cơ sở dữ liệu đến " + strThoiDiemStopAt + " thành công!", "", MessageBoxButtons.OK);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi Restore:\n" + ex + "\n Tự động phục hồi về bản sao lưu mới nhất!", "", MessageBoxButtons.OK);
                            String strRestore = " ALTER DATABASE " + textBox_name.Text.Trim()
                            + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " 
                            + " USE tempdb RESTORE DATABASE " + textBox_name.Text.Trim()
                            + " FROM   " + deviceName + " WITH FILE =  " + ((DataRowView)spbackupdateBindingSource[0])["position"].ToString()
                            + ", REPLACE  " // một cơ chế an toàn không cho phép chồng lên csdl khác
                            + " ALTER DATABASE  " + textBox_name.Text.Trim() + " SET MULTI_USER";
                            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi");
                            if (err == 0)   MessageBox.Show("Đã phục hồi về bản mới nhất", "", MessageBoxButtons.OK);

                        }
                    }
                    label_Ngaygio.Enabled = dateStop.Enabled = timeStop.Enabled = false
                        ;

                }
                else
                {
                    label_Ngaygio.Enabled = dateStop.Enabled = timeStop.Enabled = false;
                    return;
                }

            }
        }
        private void TaoThietBiSaoLuu_Click(object sender, EventArgs e)
        {
            deviceName = "DEV_" + textBox_name.Text.Trim();
            String strFullPathDevice = Program.strDefaultPath + deviceName + ".bak";

            String query = "USE master " + 
                           "EXEC sp_addumpdevice \'" + Program.device_type + "\', \'" + deviceName + "\',\'" + strFullPathDevice + "\'";
            try
            {
                Program.myreader = Program.ExecSqlDataReader(query);
                if (Program.myreader != null)
                {
                    MessageBox.Show(" Tạo Device thành công!", "", MessageBoxButtons.OK);
                    this.sp_backup_dateTableAdapter.Fill(this.dataSet.sp_backup_date, textBox_name.Text.Trim());
                    btn_TaoThietBiSaoLuu.Enabled = false;
                    btn_Luu.Enabled = true;

                }
                else MessageBox.Show(" Tạo Device thất bại!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "!", MessageBoxButtons.OK);
                return;
            }

            Program.conn.Close();
        }
        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }
        private void XoaDia(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa toàn bộ đĩa không ", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            try
            {
                deviceName = "DEV_" + textBox_name.Text.Trim();

                String strLenh;
                if (textBox_name.Text.Trim() == "" || deviceName == "") return;
                CheckDeviceExist();

                // xóa device
                strLenh = "EXEC sp_dropdevice " + deviceName + ",'delfile'";
                Program.ExecSqlNonQuery(strLenh, Program.connstr, "Lỗi xóa device");

                // Xóa thông tin về cơ sở dữ liệu được chỉ định khỏi bảng lịch sử backup và restore.
                // sp_delete_database_backuphistory [ @database_name = ] 'database_name'
                strLenh = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = " + textBox_name.Text.Trim();
                Program.ExecSqlNonQuery(strLenh, Program.connstr, "Lỗi xóa lịch sử");

                LoadLaiTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Question", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void XoaMotBan(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản này không ", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            if (bansaoluu == 1)
            {
                if (MessageBox.Show("Nếu Xóa bản backup đầu tiên thì sẽ mất các bản backup còn lại!!! ", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
            }
            string sql = "USE master EXEC sp_xoamotban @database_name = " + textBox_name.Text.Trim() + ", @VTRI = " + bansaoluu;

            
                int err = Program.ExecSqlNonQuery(sql, Program.connstr, "Lỗi phục hồi");
                if (err == 0)
                {
                    MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK);
                    LoadLaiTrang();
                }
                else if (err==62)// KHÔNG TÌM THẤY SP LÀ MÃ 62
            {
                var taomoisp = MessageBox.Show("Bạn có muốn tạo sp_xoamotban không?", "", MessageBoxButtons.YesNo);
                if(taomoisp.Equals(DialogResult.Yes))
                {
                    TaoMoiSPHeThong(0);
                }    
            }

            
        }

        private void TaoMoiSPHeThong(int v)
        {
            int err = Program.ExecSqlNonQuery(Program.sp_Name[v], Program.connstr, "Lỗi tạo sp");
            if (err == 0)
            {
                MessageBox.Show("Tạo thành công", "", MessageBoxButtons.OK);
               
            }
        }

        private void PhucHoiTheoThoiGian(object sender, EventArgs e)
        {
            checkBox_PhucHoiTheoTG.Checked = true;
            
        }

       private void DoPhucHoiTheoThoiGian()
        {
            
            //
        }

        private void Cell_click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            bansaoluu = int.Parse(((DataRowView)spbackupdateBindingSource[index])["position"].ToString());
            textBox_BangSaoLuu.Text = bansaoluu + "";

        }

        private void CB_PhucHoiChange(object sender, EventArgs e)
        {
           button1.Visible= timeStop.Visible=dateStop.Visible = label_Ngaygio.Visible = checkBox_PhucHoiTheoTG.Checked;
            label_Ngaygio.Enabled = dateStop.Enabled = timeStop.Enabled = checkBox_PhucHoiTheoTG.Checked;
            DoPhucHoiTheoThoiGian();
        }
    }
}
