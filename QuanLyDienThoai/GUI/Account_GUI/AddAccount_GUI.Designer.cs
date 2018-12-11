namespace QuanLyDienThoai.GUI.Account_GUI
{
    partial class AddAccount_GUI
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount_GUI));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions9 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions10 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.function_panel_btn = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.pnl_title_winform = new System.Windows.Forms.Panel();
            this.pnl_icon_logo = new System.Windows.Forms.Panel();
            this.exit_winform = new System.Windows.Forms.Panel();
            this.title_winform = new System.Windows.Forms.Label();
            this.lbl_id_customer = new DevExpress.XtraEditors.LabelControl();
            this.form_info = new System.Windows.Forms.Panel();
            this.pnl_password = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new DevExpress.XtraEditors.LabelControl();
            this.pnl_email = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new DevExpress.XtraEditors.LabelControl();
            this.pnl_id_customer = new System.Windows.Forms.Panel();
            this.txt_id_customer = new System.Windows.Forms.TextBox();
            this.pnl_window_add = new System.Windows.Forms.Panel();
            this.table_customer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel_conPass = new System.Windows.Forms.Panel();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnl_title_winform.SuspendLayout();
            this.form_info.SuspendLayout();
            this.pnl_password.SuspendLayout();
            this.pnl_email.SuspendLayout();
            this.pnl_id_customer.SuspendLayout();
            this.pnl_window_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel_conPass.SuspendLayout();
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
            windowsUIButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions6.Image")));
            windowsUIButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions7.Image")));
            windowsUIButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions8.Image")));
            windowsUIButtonImageOptions9.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions9.Image")));
            windowsUIButtonImageOptions10.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions10.Image")));
            this.function_panel_btn.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm và Thêm mới", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save_new", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm và Đóng", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save_close", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm lại", true, windowsUIButtonImageOptions9, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "refresh", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Đóng", true, windowsUIButtonImageOptions10, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "close", -1, false)});
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
            this.form_info.Controls.Add(this.panel_conPass);
            this.form_info.Controls.Add(this.pnl_password);
            this.form_info.Controls.Add(this.labelControl1);
            this.form_info.Controls.Add(this.lbl_password);
            this.form_info.Controls.Add(this.pnl_email);
            this.form_info.Controls.Add(this.lbl_email);
            this.form_info.Controls.Add(this.pnl_id_customer);
            this.form_info.Controls.Add(this.lbl_id_customer);
            this.form_info.Location = new System.Drawing.Point(10, 56);
            this.form_info.Name = "form_info";
            this.form_info.Size = new System.Drawing.Size(462, 215);
            this.form_info.TabIndex = 15;
            this.form_info.Paint += new System.Windows.Forms.PaintEventHandler(this.form_info_Paint);
            // 
            // pnl_password
            // 
            this.pnl_password.Controls.Add(this.txt_password);
            this.pnl_password.Location = new System.Drawing.Point(131, 109);
            this.pnl_password.Name = "pnl_password";
            this.pnl_password.Size = new System.Drawing.Size(277, 33);
            this.pnl_password.TabIndex = 38;
            this.pnl_password.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_Paint);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_password.Location = new System.Drawing.Point(10, 9);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(255, 15);
            this.txt_password.TabIndex = 7;
            // 
            // lbl_password
            // 
            this.lbl_password.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_password.Appearance.Options.UseFont = true;
            this.lbl_password.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_password.Location = new System.Drawing.Point(15, 109);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(109, 33);
            this.lbl_password.TabIndex = 17;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // pnl_email
            // 
            this.pnl_email.Controls.Add(this.txt_email);
            this.pnl_email.Location = new System.Drawing.Point(131, 63);
            this.pnl_email.Name = "pnl_email";
            this.pnl_email.Size = new System.Drawing.Size(276, 33);
            this.pnl_email.TabIndex = 18;
            this.pnl_email.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_Paint);
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_email.Location = new System.Drawing.Point(10, 9);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(259, 15);
            this.txt_email.TabIndex = 15;
            // 
            // lbl_email
            // 
            this.lbl_email.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_email.Appearance.Options.UseFont = true;
            this.lbl_email.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_email.Location = new System.Drawing.Point(15, 63);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(109, 33);
            this.lbl_email.TabIndex = 17;
            this.lbl_email.Text = "Email";
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
            // panel_conPass
            // 
            this.panel_conPass.Controls.Add(this.txt_confirmPass);
            this.panel_conPass.Location = new System.Drawing.Point(131, 157);
            this.panel_conPass.Name = "panel_conPass";
            this.panel_conPass.Size = new System.Drawing.Size(277, 33);
            this.panel_conPass.TabIndex = 40;
            this.panel_conPass.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_Paint);
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_confirmPass.Location = new System.Drawing.Point(10, 9);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.PasswordChar = '*';
            this.txt_confirmPass.Size = new System.Drawing.Size(255, 15);
            this.txt_confirmPass.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(15, 157);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 33);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Nhập lại mật khẩu";
            // 
            // AddAccount_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 341);
            this.Controls.Add(this.pnl_window_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAccount_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustome_GUI";
            this.pnl_title_winform.ResumeLayout(false);
            this.form_info.ResumeLayout(false);
            this.pnl_password.ResumeLayout(false);
            this.pnl_password.PerformLayout();
            this.pnl_email.ResumeLayout(false);
            this.pnl_email.PerformLayout();
            this.pnl_id_customer.ResumeLayout(false);
            this.pnl_id_customer.PerformLayout();
            this.pnl_window_add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel_conPass.ResumeLayout(false);
            this.panel_conPass.PerformLayout();
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
        private DevExpress.XtraEditors.LabelControl lbl_password;
        private System.Windows.Forms.Panel pnl_email;
        private System.Windows.Forms.TextBox txt_email;
        private DevExpress.XtraEditors.LabelControl lbl_email;
        private System.Windows.Forms.Panel pnl_window_add;
        private DevExpress.XtraGrid.GridControl table_customer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel pnl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel panel_conPass;
        private System.Windows.Forms.TextBox txt_confirmPass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}