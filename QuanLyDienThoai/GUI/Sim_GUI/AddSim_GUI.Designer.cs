namespace QuanLyDienThoai.GUI.Customer_GUI
{
    partial class AddSim_GUI
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSim_GUI));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.function_panel_btn = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.pnl_title_winform = new System.Windows.Forms.Panel();
            this.pnl_icon_logo = new System.Windows.Forms.Panel();
            this.exit_winform = new System.Windows.Forms.Panel();
            this.title_winform = new System.Windows.Forms.Label();
            this.lbl_id_customer = new DevExpress.XtraEditors.LabelControl();
            this.form_info = new System.Windows.Forms.Panel();
            this.btn_id_customer_null = new System.Windows.Forms.Button();
            this.group_rad_status = new DevExpress.XtraEditors.RadioGroup();
            this.lbl_status = new DevExpress.XtraEditors.LabelControl();
            this.pnl_numphone = new System.Windows.Forms.Panel();
            this.txt_numphone = new System.Windows.Forms.TextBox();
            this.lbl_numphone = new DevExpress.XtraEditors.LabelControl();
            this.pnl_id_customer = new System.Windows.Forms.Panel();
            this.txt_id_customer = new System.Windows.Forms.TextBox();
            this.pnl_window_add = new System.Windows.Forms.Panel();
            this.table_customer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnl_title_winform.SuspendLayout();
            this.form_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_rad_status.Properties)).BeginInit();
            this.pnl_numphone.SuspendLayout();
            this.pnl_id_customer.SuspendLayout();
            this.pnl_window_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // function_panel_btn
            // 
            this.function_panel_btn.AppearanceButton.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.function_panel_btn.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.Silver;
            this.function_panel_btn.AppearanceButton.Hovered.Options.UseFont = true;
            this.function_panel_btn.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.function_panel_btn.AppearanceButton.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.function_panel_btn.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.function_panel_btn.AppearanceButton.Normal.Options.UseFont = true;
            this.function_panel_btn.AppearanceButton.Normal.Options.UseForeColor = true;
            this.function_panel_btn.AppearanceButton.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.function_panel_btn.AppearanceButton.Pressed.Options.UseFont = true;
            this.function_panel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.function_panel_btn.ButtonInterval = 50;
            windowsUIButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions1.Image")));
            windowsUIButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions2.Image")));
            windowsUIButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions3.Image")));
            windowsUIButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions4.Image")));
            windowsUIButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions5.Image")));
            this.function_panel_btn.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm và Thêm mới", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save_new", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm và Đóng", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save_close", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm lại", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "refresh", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Đóng", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "close", -1, false)});
            this.function_panel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.function_panel_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.function_panel_btn.Location = new System.Drawing.Point(0, 277);
            this.function_panel_btn.Name = "function_panel_btn";
            this.function_panel_btn.Size = new System.Drawing.Size(994, 63);
            this.function_panel_btn.TabIndex = 13;
            this.function_panel_btn.UseButtonBackgroundImages = false;
            this.function_panel_btn.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.function_panel_btn_ButtonClick);
            // 
            // pnl_title_winform
            // 
            this.pnl_title_winform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.pnl_title_winform.Controls.Add(this.pnl_icon_logo);
            this.pnl_title_winform.Controls.Add(this.exit_winform);
            this.pnl_title_winform.Controls.Add(this.title_winform);
            this.pnl_title_winform.Location = new System.Drawing.Point(0, 0);
            this.pnl_title_winform.Name = "pnl_title_winform";
            this.pnl_title_winform.Size = new System.Drawing.Size(994, 35);
            this.pnl_title_winform.TabIndex = 12;
            // 
            // pnl_icon_logo
            // 
            this.pnl_icon_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_icon_logo.BackgroundImage")));
            this.pnl_icon_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_icon_logo.Location = new System.Drawing.Point(10, 5);
            this.pnl_icon_logo.Name = "pnl_icon_logo";
            this.pnl_icon_logo.Size = new System.Drawing.Size(23, 23);
            this.pnl_icon_logo.TabIndex = 3;
            // 
            // exit_winform
            // 
            this.exit_winform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_winform.BackgroundImage")));
            this.exit_winform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_winform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_winform.Location = new System.Drawing.Point(960, 5);
            this.exit_winform.Name = "exit_winform";
            this.exit_winform.Size = new System.Drawing.Size(23, 23);
            this.exit_winform.TabIndex = 1;
            this.exit_winform.Click += new System.EventHandler(this.exit_winform_Click);
            // 
            // title_winform
            // 
            this.title_winform.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.title_winform.ForeColor = System.Drawing.Color.White;
            this.title_winform.Location = new System.Drawing.Point(31, 4);
            this.title_winform.Name = "title_winform";
            this.title_winform.Size = new System.Drawing.Size(62, 25);
            this.title_winform.TabIndex = 0;
            this.title_winform.Text = "Thêm";
            this.title_winform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id_customer
            // 
            this.lbl_id_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_customer.Appearance.Options.UseFont = true;
            this.lbl_id_customer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_customer.Location = new System.Drawing.Point(15, 13);
            this.lbl_id_customer.Name = "lbl_id_customer";
            this.lbl_id_customer.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_customer.TabIndex = 14;
            this.lbl_id_customer.Text = "Mã khách hàng";
            // 
            // form_info
            // 
            this.form_info.Controls.Add(this.btn_id_customer_null);
            this.form_info.Controls.Add(this.group_rad_status);
            this.form_info.Controls.Add(this.lbl_status);
            this.form_info.Controls.Add(this.pnl_numphone);
            this.form_info.Controls.Add(this.lbl_numphone);
            this.form_info.Controls.Add(this.pnl_id_customer);
            this.form_info.Controls.Add(this.lbl_id_customer);
            this.form_info.Location = new System.Drawing.Point(10, 56);
            this.form_info.Name = "form_info";
            this.form_info.Size = new System.Drawing.Size(462, 215);
            this.form_info.TabIndex = 15;
            this.form_info.Paint += new System.Windows.Forms.PaintEventHandler(this.form_info_Paint);
            // 
            // btn_id_customer_null
            // 
            this.btn_id_customer_null.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btn_id_customer_null.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_id_customer_null.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_id_customer_null.ForeColor = System.Drawing.Color.White;
            this.btn_id_customer_null.Location = new System.Drawing.Point(406, 12);
            this.btn_id_customer_null.Name = "btn_id_customer_null";
            this.btn_id_customer_null.Size = new System.Drawing.Size(46, 35);
            this.btn_id_customer_null.TabIndex = 35;
            this.btn_id_customer_null.Text = "Rỗng";
            this.btn_id_customer_null.UseVisualStyleBackColor = false;
            this.btn_id_customer_null.Click += new System.EventHandler(this.btn_id_customer_null_Click);
            // 
            // group_rad_status
            // 
            this.group_rad_status.Location = new System.Drawing.Point(130, 113);
            this.group_rad_status.Name = "group_rad_status";
            this.group_rad_status.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chưa sử dụng", true, "0"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Sử dụng", true, "1")});
            this.group_rad_status.Size = new System.Drawing.Size(277, 33);
            this.group_rad_status.TabIndex = 19;
            // 
            // lbl_status
            // 
            this.lbl_status.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_status.Appearance.Options.UseFont = true;
            this.lbl_status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_status.Location = new System.Drawing.Point(15, 113);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(109, 33);
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Text = "Tình trạng";
            // 
            // pnl_numphone
            // 
            this.pnl_numphone.Controls.Add(this.txt_numphone);
            this.pnl_numphone.Location = new System.Drawing.Point(131, 63);
            this.pnl_numphone.Name = "pnl_numphone";
            this.pnl_numphone.Size = new System.Drawing.Size(276, 33);
            this.pnl_numphone.TabIndex = 18;
            this.pnl_numphone.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_Paint);
            // 
            // txt_numphone
            // 
            this.txt_numphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numphone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_numphone.Location = new System.Drawing.Point(10, 9);
            this.txt_numphone.Name = "txt_numphone";
            this.txt_numphone.Size = new System.Drawing.Size(259, 15);
            this.txt_numphone.TabIndex = 15;
            this.txt_numphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numphone_KeyPress);
            // 
            // lbl_numphone
            // 
            this.lbl_numphone.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_numphone.Appearance.Options.UseFont = true;
            this.lbl_numphone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_numphone.Location = new System.Drawing.Point(15, 63);
            this.lbl_numphone.Name = "lbl_numphone";
            this.lbl_numphone.Size = new System.Drawing.Size(109, 33);
            this.lbl_numphone.TabIndex = 17;
            this.lbl_numphone.Text = "Số điện thoại";
            // 
            // pnl_id_customer
            // 
            this.pnl_id_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnl_id_customer.Controls.Add(this.txt_id_customer);
            this.pnl_id_customer.Location = new System.Drawing.Point(131, 13);
            this.pnl_id_customer.Name = "pnl_id_customer";
            this.pnl_id_customer.Size = new System.Drawing.Size(276, 33);
            this.pnl_id_customer.TabIndex = 16;
            this.pnl_id_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_Paint);
            // 
            // txt_id_customer
            // 
            this.txt_id_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_id_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_customer.Enabled = false;
            this.txt_id_customer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_id_customer.Location = new System.Drawing.Point(10, 9);
            this.txt_id_customer.Name = "txt_id_customer";
            this.txt_id_customer.Size = new System.Drawing.Size(259, 15);
            this.txt_id_customer.TabIndex = 15;
            // 
            // pnl_window_add
            // 
            this.pnl_window_add.Controls.Add(this.table_customer);
            this.pnl_window_add.Controls.Add(this.pnl_title_winform);
            this.pnl_window_add.Controls.Add(this.function_panel_btn);
            this.pnl_window_add.Controls.Add(this.form_info);
            this.pnl_window_add.Location = new System.Drawing.Point(0, 0);
            this.pnl_window_add.Name = "pnl_window_add";
            this.pnl_window_add.Size = new System.Drawing.Size(994, 340);
            this.pnl_window_add.TabIndex = 16;
            this.pnl_window_add.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_window_add_Paint);
            // 
            // table_customer
            // 
            this.table_customer.Location = new System.Drawing.Point(478, 56);
            this.table_customer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.table_customer.MainView = this.gridView1;
            this.table_customer.Name = "table_customer";
            this.table_customer.Size = new System.Drawing.Size(505, 215);
            this.table_customer.TabIndex = 16;
            this.table_customer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.table_customer.Load += new System.EventHandler(this.table_customer_Load);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.ColumnPanelRowHeight = 3;
            this.gridView1.DetailHeight = 500;
            this.gridView1.GridControl = this.table_customer;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 25;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // AddSim_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 341);
            this.Controls.Add(this.pnl_window_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSim_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustome_GUI";
            this.pnl_title_winform.ResumeLayout(false);
            this.form_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group_rad_status.Properties)).EndInit();
            this.pnl_numphone.ResumeLayout(false);
            this.pnl_numphone.PerformLayout();
            this.pnl_id_customer.ResumeLayout(false);
            this.pnl_id_customer.PerformLayout();
            this.pnl_window_add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel function_panel_btn;
        private System.Windows.Forms.Panel pnl_title_winform;
        private System.Windows.Forms.Panel pnl_icon_logo;
        private System.Windows.Forms.Panel exit_winform;
        private System.Windows.Forms.Label title_winform;
        private DevExpress.XtraEditors.LabelControl lbl_id_customer;
        private System.Windows.Forms.Panel form_info;
        private System.Windows.Forms.Panel pnl_id_customer;
        private System.Windows.Forms.TextBox txt_id_customer;
        private DevExpress.XtraEditors.LabelControl lbl_status;
        private System.Windows.Forms.Panel pnl_numphone;
        private System.Windows.Forms.TextBox txt_numphone;
        private DevExpress.XtraEditors.LabelControl lbl_numphone;
        private System.Windows.Forms.Panel pnl_window_add;
        private DevExpress.XtraGrid.GridControl table_customer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.RadioGroup group_rad_status;
        private System.Windows.Forms.Button btn_id_customer_null;
    }
}