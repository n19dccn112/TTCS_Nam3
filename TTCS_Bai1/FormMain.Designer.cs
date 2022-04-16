
namespace TTCS_Bai1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_PhucHoiTheoTG = new DevExpress.XtraEditors.SimpleButton();
            this.checkBox_PhucHoiTheoTG = new System.Windows.Forms.CheckBox();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaMotBan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaDia = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TaoThietBiSaoLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_PhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridViewListBackup = new System.Windows.Forms.DataGridView();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backup_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spbackupdateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TTCS_Bai1.DataSet();
            this.prog_phuchoi = new System.Windows.Forms.ProgressBar();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox_BangSaoLuu = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewCSDL = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databasesNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.timeStop = new DevExpress.XtraEditors.TimeEdit();
            this.dateStop = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Ngaygio = new System.Windows.Forms.Label();
            this.checkBox_XoaBanSaoLuuCu = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databases_nameTableAdapter = new TTCS_Bai1.DataSetTableAdapters.databases_nameTableAdapter();
            this.sp_backup_dateTableAdapter = new TTCS_Bai1.DataSetTableAdapters.sp_backup_dateTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbackupdateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSDL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesNameBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_PhucHoiTheoTG);
            this.panel1.Controls.Add(this.checkBox_PhucHoiTheoTG);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_XoaMotBan);
            this.panel1.Controls.Add(this.btn_XoaDia);
            this.panel1.Controls.Add(this.btn_TaoThietBiSaoLuu);
            this.panel1.Controls.Add(this.btn_LamMoi);
            this.panel1.Controls.Add(this.btn_PhucHoi);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 45);
            this.panel1.TabIndex = 4;
            // 
            // btn_PhucHoiTheoTG
            // 
            this.btn_PhucHoiTheoTG.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_PhucHoiTheoTG.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhucHoiTheoTG.ImageOptions.Image")));
            this.btn_PhucHoiTheoTG.Location = new System.Drawing.Point(856, 0);
            this.btn_PhucHoiTheoTG.Margin = new System.Windows.Forms.Padding(6);
            this.btn_PhucHoiTheoTG.Name = "btn_PhucHoiTheoTG";
            this.btn_PhucHoiTheoTG.Size = new System.Drawing.Size(193, 45);
            this.btn_PhucHoiTheoTG.TabIndex = 10;
            this.btn_PhucHoiTheoTG.Text = "Phục hồi theo thời gian";
            this.btn_PhucHoiTheoTG.Click += new System.EventHandler(this.PhucHoiTheoThoiGian);
            // 
            // checkBox_PhucHoiTheoTG
            // 
            this.checkBox_PhucHoiTheoTG.AutoSize = true;
            this.checkBox_PhucHoiTheoTG.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_PhucHoiTheoTG.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_PhucHoiTheoTG.Location = new System.Drawing.Point(838, 0);
            this.checkBox_PhucHoiTheoTG.Name = "checkBox_PhucHoiTheoTG";
            this.checkBox_PhucHoiTheoTG.Size = new System.Drawing.Size(18, 45);
            this.checkBox_PhucHoiTheoTG.TabIndex = 9;
            this.checkBox_PhucHoiTheoTG.UseVisualStyleBackColor = false;
            this.checkBox_PhucHoiTheoTG.CheckedChanged += new System.EventHandler(this.CB_PhucHoiChange);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.ImageOptions.Image")));
            this.btn_Thoat.Location = new System.Drawing.Point(731, 0);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(107, 45);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.Thoat);
            // 
            // btn_XoaMotBan
            // 
            this.btn_XoaMotBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_XoaMotBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaMotBan.ImageOptions.Image")));
            this.btn_XoaMotBan.Location = new System.Drawing.Point(600, 0);
            this.btn_XoaMotBan.Margin = new System.Windows.Forms.Padding(6);
            this.btn_XoaMotBan.Name = "btn_XoaMotBan";
            this.btn_XoaMotBan.Size = new System.Drawing.Size(131, 45);
            this.btn_XoaMotBan.TabIndex = 7;
            this.btn_XoaMotBan.Text = "Xóa một bản";
            this.btn_XoaMotBan.Click += new System.EventHandler(this.XoaMotBan);
            // 
            // btn_XoaDia
            // 
            this.btn_XoaDia.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_XoaDia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaDia.ImageOptions.Image")));
            this.btn_XoaDia.Location = new System.Drawing.Point(490, 0);
            this.btn_XoaDia.Margin = new System.Windows.Forms.Padding(6);
            this.btn_XoaDia.Name = "btn_XoaDia";
            this.btn_XoaDia.Size = new System.Drawing.Size(110, 45);
            this.btn_XoaDia.TabIndex = 6;
            this.btn_XoaDia.Text = "Xóa đĩa";
            this.btn_XoaDia.Click += new System.EventHandler(this.XoaDia);
            // 
            // btn_TaoThietBiSaoLuu
            // 
            this.btn_TaoThietBiSaoLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_TaoThietBiSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoThietBiSaoLuu.ImageOptions.Image")));
            this.btn_TaoThietBiSaoLuu.Location = new System.Drawing.Point(320, 0);
            this.btn_TaoThietBiSaoLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TaoThietBiSaoLuu.Name = "btn_TaoThietBiSaoLuu";
            this.btn_TaoThietBiSaoLuu.Size = new System.Drawing.Size(170, 45);
            this.btn_TaoThietBiSaoLuu.TabIndex = 5;
            this.btn_TaoThietBiSaoLuu.Text = "Tạo thiết bị sao lưu";
            this.btn_TaoThietBiSaoLuu.Click += new System.EventHandler(this.TaoThietBiSaoLuu_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.ImageOptions.Image")));
            this.btn_LamMoi.Location = new System.Drawing.Point(205, 0);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(6);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(115, 45);
            this.btn_LamMoi.TabIndex = 3;
            this.btn_LamMoi.Text = "Làm mới";
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_PhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhucHoi.ImageOptions.Image")));
            this.btn_PhucHoi.Location = new System.Drawing.Point(99, 0);
            this.btn_PhucHoi.Margin = new System.Windows.Forms.Padding(5);
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.Size = new System.Drawing.Size(106, 45);
            this.btn_PhucHoi.TabIndex = 2;
            this.btn_PhucHoi.Text = "Phục hồi";
            this.btn_PhucHoi.Click += new System.EventHandler(this.phucHoi);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.ImageOptions.Image")));
            this.btn_Luu.Location = new System.Drawing.Point(0, 0);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(99, 45);
            this.btn_Luu.TabIndex = 1;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.luu);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1582, 808);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1582, 808);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1582, 582);
            this.panel4.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.prog_phuchoi);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(247, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1335, 582);
            this.panel6.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridViewListBackup);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 36);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1335, 523);
            this.panel9.TabIndex = 31;
            // 
            // dataGridViewListBackup
            // 
            this.dataGridViewListBackup.AutoGenerateColumns = false;
            this.dataGridViewListBackup.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewListBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListBackup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.position,
            this.nameDataGridViewTextBoxColumn3,
            this.backup_start_date,
            this.user_name});
            this.dataGridViewListBackup.DataSource = this.spbackupdateBindingSource;
            this.dataGridViewListBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListBackup.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListBackup.Name = "dataGridViewListBackup";
            this.dataGridViewListBackup.RowHeadersWidth = 51;
            this.dataGridViewListBackup.RowTemplate.Height = 24;
            this.dataGridViewListBackup.Size = new System.Drawing.Size(1335, 523);
            this.dataGridViewListBackup.TabIndex = 0;
            this.dataGridViewListBackup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_click);
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "Bản sao lưu thứ #";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.Width = 225;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Diễn giải";
            this.nameDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.Width = 225;
            // 
            // backup_start_date
            // 
            this.backup_start_date.DataPropertyName = "backup_start_date";
            this.backup_start_date.HeaderText = "Ngày giờ sao lưu";
            this.backup_start_date.MinimumWidth = 6;
            this.backup_start_date.Name = "backup_start_date";
            this.backup_start_date.Width = 225;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "User sao lưu";
            this.user_name.MinimumWidth = 6;
            this.user_name.Name = "user_name";
            this.user_name.Width = 225;
            // 
            // spbackupdateBindingSource
            // 
            this.spbackupdateBindingSource.DataMember = "sp_backup_date";
            this.spbackupdateBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prog_phuchoi
            // 
            this.prog_phuchoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prog_phuchoi.Location = new System.Drawing.Point(0, 559);
            this.prog_phuchoi.Name = "prog_phuchoi";
            this.prog_phuchoi.Size = new System.Drawing.Size(1335, 23);
            this.prog_phuchoi.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel8.Controls.Add(this.textBox_BangSaoLuu);
            this.panel8.Controls.Add(this.textBox_name);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1335, 36);
            this.panel8.TabIndex = 28;
            // 
            // textBox_BangSaoLuu
            // 
            this.textBox_BangSaoLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_BangSaoLuu.Location = new System.Drawing.Point(325, 0);
            this.textBox_BangSaoLuu.Name = "textBox_BangSaoLuu";
            this.textBox_BangSaoLuu.ReadOnly = true;
            this.textBox_BangSaoLuu.Size = new System.Drawing.Size(100, 22);
            this.textBox_BangSaoLuu.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_name.Location = new System.Drawing.Point(90, 0);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(235, 22);
            this.textBox_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cơ sở dữ liệu";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridViewCSDL);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(247, 582);
            this.panel7.TabIndex = 13;
            // 
            // dataGridViewCSDL
            // 
            this.dataGridViewCSDL.AutoGenerateColumns = false;
            this.dataGridViewCSDL.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewCSDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSDL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewCSDL.DataSource = this.databasesNameBindingSource;
            this.dataGridViewCSDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCSDL.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCSDL.Name = "dataGridViewCSDL";
            this.dataGridViewCSDL.ReadOnly = true;
            this.dataGridViewCSDL.RowHeadersWidth = 51;
            this.dataGridViewCSDL.RowTemplate.Height = 24;
            this.dataGridViewCSDL.Size = new System.Drawing.Size(247, 582);
            this.dataGridViewCSDL.TabIndex = 10;
            this.dataGridViewCSDL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCSDL_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 225;
            // 
            // databasesNameBindingSource
            // 
            this.databasesNameBindingSource.DataMember = "databases_Name";
            this.databasesNameBindingSource.DataSource = this.dataSet;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.timeStop);
            this.panel5.Controls.Add(this.dateStop);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label_Ngaygio);
            this.panel5.Controls.Add(this.checkBox_XoaBanSaoLuuCu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 582);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1582, 226);
            this.panel5.TabIndex = 8;
            // 
            // timeStop
            // 
            this.timeStop.EditValue = new System.DateTime(2022, 4, 4, 0, 0, 0, 0);
            this.timeStop.Location = new System.Drawing.Point(1222, 65);
            this.timeStop.Name = "timeStop";
            this.timeStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeStop.Size = new System.Drawing.Size(125, 24);
            this.timeStop.TabIndex = 12;
            // 
            // dateStop
            // 
            this.dateStop.EditValue = null;
            this.dateStop.Location = new System.Drawing.Point(1007, 66);
            this.dateStop.Name = "dateStop";
            this.dateStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Size = new System.Drawing.Size(195, 22);
            this.dateStop.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(890, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = resources.GetString("button1.Text");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_Ngaygio
            // 
            this.label_Ngaygio.AutoSize = true;
            this.label_Ngaygio.Location = new System.Drawing.Point(759, 69);
            this.label_Ngaygio.Name = "label_Ngaygio";
            this.label_Ngaygio.Size = new System.Drawing.Size(242, 17);
            this.label_Ngaygio.TabIndex = 9;
            this.label_Ngaygio.Text = "Ngày giờ để phục hồi tới thời điểm đó";
            // 
            // checkBox_XoaBanSaoLuuCu
            // 
            this.checkBox_XoaBanSaoLuuCu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_XoaBanSaoLuuCu.AutoSize = true;
            this.checkBox_XoaBanSaoLuuCu.Location = new System.Drawing.Point(870, 19);
            this.checkBox_XoaBanSaoLuuCu.Name = "checkBox_XoaBanSaoLuuCu";
            this.checkBox_XoaBanSaoLuuCu.Size = new System.Drawing.Size(416, 21);
            this.checkBox_XoaBanSaoLuuCu.TabIndex = 8;
            this.checkBox_XoaBanSaoLuuCu.Text = "Xóa tất cả bản sao lưu cũ trong File trước khi sao lưu bản mới";
            this.checkBox_XoaBanSaoLuuCu.UseVisualStyleBackColor = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Width = 125;
            // 
            // databases_nameTableAdapter
            // 
            this.databases_nameTableAdapter.ClearBeforeFill = true;
            // 
            // sp_backup_dateTableAdapter
            // 
            this.sp_backup_dateTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup and Restore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbackupdateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSDL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesNameBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
        private DevExpress.XtraEditors.SimpleButton btn_XoaMotBan;
        private DevExpress.XtraEditors.SimpleButton btn_XoaDia;
        private DevExpress.XtraEditors.SimpleButton btn_TaoThietBiSaoLuu;
        private DevExpress.XtraEditors.SimpleButton btn_LamMoi;
        private DevExpress.XtraEditors.SimpleButton btn_PhucHoi;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_PhucHoiTheoTG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.CheckBox checkBox_PhucHoiTheoTG;
        private DataSet dataSet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Ngaygio;
        private System.Windows.Forms.CheckBox checkBox_XoaBanSaoLuuCu;
        private DevExpress.XtraEditors.DateEdit dateStop;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.TimeEdit timeStop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox_BangSaoLuu;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_CSDL;
        private System.Windows.Forms.ProgressBar prog_phuchoi;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dataGridViewCSDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource databasesNameBindingSource;
        private DataSetTableAdapters.databases_nameTableAdapter databases_nameTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewListBackup;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn backup_start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.BindingSource spbackupdateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataSetTableAdapters.sp_backup_dateTableAdapter sp_backup_dateTableAdapter;
    }
}