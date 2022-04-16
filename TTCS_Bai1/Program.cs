using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using System.Collections;

namespace TTCS_Bai1
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static string connstr;// tên server của máy - HUYNHMY
        public static SqlDataAdapter da;

        public static string servername = "HUYNHMY";
        public static string username = "sa";
        public static string password = "";
        public static string database = "tempdb";//xem lại
        public static string mlogin = "";

        public static int nambatdau = 2022;//để cho cmbNK tự động tính dựa vào năm này
                                            // tra gg thằng này
        public static int flagRestore = 0;//để kiểm tra user có phục hồi csdl?
        public static string strDefaultPath = "D:/PTIT/HK6/TTCS/TTCS_Bai1/";//thư mục mặc định lưu back up, restore


        public static String device_type = "Disk";
        public static FormDangNhap form;
        public static String[] sp_Name = { @" CREATE PROCEDURE [dbo].[sp_xoamotban]
            @database_name NVARCHAR(100),
            @VTRI INT
            AS
            BEGIN
                 DECLARE @backup_set_id INT
                 DECLARE @media_set_id INT
                 DECLARE @restore_history_id TABLE (restore_history_id INT)
                 SELECT @backup_set_id = MIN(backup_set_id)
                 FROM msdb.dbo.backupset
                 WHERE database_name = @database_name AND type = 'D' AND backup_set_id >=
                    (SELECT MAX(backup_set_id) FROM msdb.dbo.backupset WHERE media_set_id =
                        (SELECT  MAX(media_set_id) FROM msdb.dbo.backupset WHERE database_name = @database_name AND type='D') AND position = @VTRI)
                SELECT @media_set_id = media_set_id FROM msdb.dbo.backupset WHERE backup_set_id = @backup_set_id
                INSERT INTO @restore_history_id (restore_history_id)
                SELECT DISTINCT restore_history_id FROM msdb.dbo.restorehistory WHERE backup_set_id = @backup_set_id
                SET XACT_ABORT ON
                BEGIN TRANSACTION
                BEGIN TRY
                    DELETE FROM msdb.dbo.backupfile WHERE backup_set_id = @backup_set_id
                    DELETE FROM msdb.dbo.backupfilegroup WHERE backup_set_id = @backup_set_id
                    DELETE FROM msdb.dbo.restorefile WHERE restore_history_id IN (SELECT restore_history_id FROM @restore_history_id)
                    DELETE FROM msdb.dbo.restorefilegroup WHERE restore_history_id IN (SELECT restore_history_id FROM @restore_history_id)
                    DELETE FROM msdb.dbo.restorehistory WHERE restore_history_id IN (SELECT restore_history_id FROM @restore_history_id)
                    DELETE FROM msdb.dbo.backupset WHERE backup_set_id = @backup_set_id
                    COMMIT TRANSACTION
               END TRY
                BEGIN CATCH
                    ROLLBACK
                    DECLARE @ErrMess VARCHAR(1000) SELECT @ErrMess = 'LOI: ' + ERROR_MESSAGE() RAISERROR(@ErrMess, 16, 1)
                END CATCH
                END",
            ////////////////////////////////////
            @"CREATE PROCEDURE [dbo].[sp_phucHoiTheoTHoiGian]
	            @dBName nvarchar(50),
	            @date datetime,
	            @directory Nvarchar(MAX),
	            @bansaoluu int
            AS
            Begin
	            Declare @SQLCommand Nvarchar(MAX)
	            Declare @deviceName Nvarchar(100)
	            SET @deviceName = 'DEV_' + @dBName
	            -- bật transaction - giao tác
	            SET XACT_ABORT ON
                BEGIN TRANSACTION
                BEGIN TRY
                    Set @SQLCommand = N'ALTER DATABASE ' + @dBName + ' SET SINGLE_USER WITH ROLLBACK IMMEDIATE'
		            -- phục hồi file nhật kí
		            + N' BACKUP LOG ' + @dBName + ' TO DISK = ''' + @directory + ''' WITH INIT'
		            + N' ,NORECOVERY' --thao tac restore không quay lại bất kì giao tác nào k được xác định, sẽ không hoàn giao tác lỗi   
		            EXEC sp_sqlexec @SQLCommand

		            Set @SQLCommand = N'USE tempdb RESTORE DATABASE ' + @dBName + 'FROM ' + @deviceName 
		            + 'WITH FILE = ' + @bansaoluu + ',NORECOVERY'
		            EXEC sp_sqlexec @SQLCommand

		            Set @SQLCommand = N'RESTORE DATABASE ' + @dBName + 'FROM DISK = ''' + @directory 
		            + ''' WITH STOPAT=''' + @date + ''''
		            EXEC sp_sqlexec @SQLCommand

		            Set @SQLCommand = N'ALTER DATABASE ' + @dBName + ' SET MULTI_USER'
		            EXEC sp_sqlexec @SQLCommand
                    COMMIT TRANSACTION
	            END TRY
                BEGIN CATCH
                    ROLLBACK
                    DECLARE @ErrMess VARCHAR(1000) SELECT @ErrMess = 'LOI: ' + ERROR_MESSAGE() RAISERROR(@ErrMess, 16, 1)
                END CATCH
            END"
        };
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)         Program.conn.Close();
                // conn đang đc sd      state-trạng thái mở - đã đăng nhập vào              Thì đóng cái kết nối thằng trước
                // cái này chỉ cho mình sd phòng phần mềm chạy ẩn chạy ngầm k tắt đc
            try
            {
                //Program.connstr = "Data source=" + Program.servername + ";Initial Catalog=" + Program.database +
                //    ";User Id=" + Program.mlogin + ";Password=" + Program.password;
                Program.connstr = "Data source=" + Program.servername + ";User Id = " + Program.username + "; Password = " + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                //40-41 gộp 1 dòng
                Program.conn.Open();
                return 1;
            }
            catch (SqlException e)
            {
                MessageBox.Show(" Lỗi kết nối CSDL.\nXem lại username và password.\n" + e.Message, "", MessageBoxButtons.RetryCancel);
                return 0;
            }
        }

        public static SqlDataReader myreader;


        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {// viết để nhận câu query-thực thi câu lệnh sql để đọc data
            conn.Close();

            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);//mấy câu query-là mấy câu select đồ
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();//chứa các dong dữ liệu sau khi thực hiện lệnh
                                //      !
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //chưa được sl khi truy vấn trên server khác
        
      
        
        public static DataTable ExecSqlDataTable(String strlenh, Hashtable paras)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            da = new SqlDataAdapter(strlenh, conn);
            foreach (DictionaryEntry s in paras)
            {
                da.SelectCommand.Parameters.AddWithValue(s.Key.ToString(), s.Value);
            }
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh, String connectionstring, string errstr)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600; //10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int loi = Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format lại các cột kiểu char qua int");
                else
                    MessageBox.Show(errstr + "\n" + ex.Message);
                conn.Close();
                return (ex.State);// trạng thái lỗi gửi từ RAISERROR trong sql server qua
            }
        }
        // nếu câu query gửi nhầm qua hàm nonquery thì sẽ vào catch, ngược lại tương tự

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
        }
    }
}
