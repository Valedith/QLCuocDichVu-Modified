namespace QuanLyDienThoai.GUI.Account_GUI
{
    partial class Account_GUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_GUI));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.lbl_title = new System.Windows.Forms.Label();
            this.table_account = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnl_function = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Button_exe_panel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.lbl_id_customer = new DevExpress.XtraEditors.LabelControl();
            this.pnl_id_customer = new System.Windows.Forms.Panel();
            this.txt_id_customer = new System.Windows.Forms.TextBox();
            this.lbl_id_account = new DevExpress.XtraEditors.LabelControl();
            this.pnl_id_account = new System.Windows.Forms.Panel();
            this.txt_id_account = new System.Windows.Forms.TextBox();
            this.lbl_password = new DevExpress.XtraEditors.LabelControl();
            this.pnl_password = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_view_customer = new System.Windows.Forms.Button();
            this.lbl_email = new DevExpress.XtraEditors.LabelControl();
            this.pnl_email = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pnl_form_input_customer = new System.Windows.Forms.Panel();
            this.note_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnl_function.SuspendLayout();
            this.pnl_search.SuspendLayout();
            this.pnl_id_customer.SuspendLayout();
            this.pnl_id_account.SuspendLayout();
            this.pnl_password.SuspendLayout();
            this.pnl_email.SuspendLayout();
            this.pnl_form_input_customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.lbl_title.Location = new System.Drawing.Point(4, 14);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(144, 23);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "TÀI KHOẢN";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // table_account
            // 
            this.table_account.Location = new System.Drawing.Point(3, 181);
            this.table_account.LookAndFeel.UseDefaultLookAndFeel = false;
            this.table_account.MainView = this.gridView1;
            this.table_account.Name = "table_account";
            this.table_account.Size = new System.Drawing.Size(879, 265);
            this.table_account.TabIndex = 6;
            this.table_account.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.table_account.Load += new System.EventHandler(this.table_account_Load);
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
            this.gridView1.GridControl = this.table_account;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 25;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // pnl_function
            // 
            this.pnl_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnl_function.Controls.Add(this.btn_search);
            this.pnl_function.Controls.Add(this.pnl_search);
            this.pnl_function.Controls.Add(this.Button_exe_panel);
            this.pnl_function.Location = new System.Drawing.Point(0, 452);
            this.pnl_function.Name = "pnl_function";
            this.pnl_function.Size = new System.Drawing.Size(885, 74);
            this.pnl_function.TabIndex = 7;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_search.Appearance.Options.UseBackColor = true;
            this.btn_search.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_search.Location = new System.Drawing.Point(801, 25);
            this.btn_search.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(31, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pnl_search
            // 
            this.pnl_search.BackColor = System.Drawing.Color.White;
            this.pnl_search.Controls.Add(this.txt_search);
            this.pnl_search.Location = new System.Drawing.Point(589, 26);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(212, 30);
            this.pnl_search.TabIndex = 1;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_search.Location = new System.Drawing.Point(9, 7);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(196, 16);
            this.txt_search.TabIndex = 0;
            // 
            // Button_exe_panel
            // 
            this.Button_exe_panel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.Silver;
            this.Button_exe_panel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.Button_exe_panel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.Button_exe_panel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.Button_exe_panel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.White;
            this.Button_exe_panel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.Button_exe_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_exe_panel.ButtonInterval = 40;
            windowsUIButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions1.Image")));
            windowsUIButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions2.Image")));
            windowsUIButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions3.Image")));
            windowsUIButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions4.Image")));
            this.Button_exe_panel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm mới", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "add", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "delete", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm tươi", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "refresh", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("In", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "print", -1, false)});
            this.Button_exe_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_exe_panel.ForeColor = System.Drawing.Color.White;
            this.Button_exe_panel.Location = new System.Drawing.Point(35, 5);
            this.Button_exe_panel.Name = "Button_exe_panel";
            this.Button_exe_panel.Size = new System.Drawing.Size(468, 66);
            this.Button_exe_panel.TabIndex = 0;
            this.Button_exe_panel.Text = "windowsUIButtonPanel1";
            this.Button_exe_panel.UseButtonBackgroundImages = false;
            this.Button_exe_panel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.Button_exe_panel_ButtonClick);
            // 
            // lbl_id_customer
            // 
            this.lbl_id_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_customer.Appearance.Options.UseFont = true;
            this.lbl_id_customer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_customer.Location = new System.Drawing.Point(470, 15);
            this.lbl_id_customer.Name = "lbl_id_customer";
            this.lbl_id_customer.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_customer.TabIndex = 21;
            this.lbl_id_customer.Text = "Mã Khách hàng";
            // 
            // pnl_id_customer
            // 
            this.pnl_id_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnl_id_customer.Controls.Add(this.txt_id_customer);
            this.pnl_id_customer.Location = new System.Drawing.Point(586, 14);
            this.pnl_id_customer.Name = "pnl_id_customer";
            this.pnl_id_customer.Size = new System.Drawing.Size(227, 33);
            this.pnl_id_customer.TabIndex = 22;
            this.pnl_id_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_lbl_form);
            // 
            // txt_id_customer
            // 
            this.txt_id_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_id_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_customer.Enabled = false;
            this.txt_id_customer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_id_customer.Location = new System.Drawing.Point(10, 9);
            this.txt_id_customer.Name = "txt_id_customer";
            this.txt_id_customer.Size = new System.Drawing.Size(204, 15);
            this.txt_id_customer.TabIndex = 5;
            // 
            // lbl_id_account
            // 
            this.lbl_id_account.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_account.Appearance.Options.UseFont = true;
            this.lbl_id_account.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_account.Location = new System.Drawing.Point(30, 15);
            this.lbl_id_account.Name = "lbl_id_account";
            this.lbl_id_account.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_account.TabIndex = 31;
            this.lbl_id_account.Text = "Mã tài khoản";
            // 
            // pnl_id_account
            // 
            this.pnl_id_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnl_id_account.Controls.Add(this.txt_id_account);
            this.pnl_id_account.Location = new System.Drawing.Point(146, 15);
            this.pnl_id_account.Name = "pnl_id_account";
            this.pnl_id_account.Size = new System.Drawing.Size(227, 33);
            this.pnl_id_account.TabIndex = 32;
            this.pnl_id_account.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_lbl_form);
            // 
            // txt_id_account
            // 
            this.txt_id_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_id_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_account.Enabled = false;
            this.txt_id_account.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_id_account.Location = new System.Drawing.Point(10, 9);
            this.txt_id_account.Name = "txt_id_account";
            this.txt_id_account.Size = new System.Drawing.Size(204, 15);
            this.txt_id_account.TabIndex = 4;
            // 
            // lbl_password
            // 
            this.lbl_password.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_password.Appearance.Options.UseFont = true;
            this.lbl_password.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_password.Location = new System.Drawing.Point(471, 67);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(109, 33);
            this.lbl_password.TabIndex = 32;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // pnl_password
            // 
            this.pnl_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnl_password.Controls.Add(this.txt_password);
            this.pnl_password.Location = new System.Drawing.Point(586, 67);
            this.pnl_password.Name = "pnl_password";
            this.pnl_password.Size = new System.Drawing.Size(227, 33);
            this.pnl_password.TabIndex = 33;
            this.pnl_password.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_lbl_form);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_password.Location = new System.Drawing.Point(10, 9);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(205, 15);
            this.txt_password.TabIndex = 7;
            // 
            // btn_view_customer
            // 
            this.btn_view_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btn_view_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_customer.ForeColor = System.Drawing.Color.White;
            this.btn_view_customer.Location = new System.Drawing.Point(819, 13);
            this.btn_view_customer.Name = "btn_view_customer";
            this.btn_view_customer.Size = new System.Drawing.Size(38, 35);
            this.btn_view_customer.TabIndex = 34;
            this.btn_view_customer.Text = "Xem";
            this.btn_view_customer.UseVisualStyleBackColor = false;
            this.btn_view_customer.Click += new System.EventHandler(this.btn_view_customer_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_email.Appearance.Options.UseFont = true;
            this.lbl_email.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_email.Location = new System.Drawing.Point(31, 66);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(109, 33);
            this.lbl_email.TabIndex = 34;
            this.lbl_email.Text = "Email";
            // 
            // pnl_email
            // 
            this.pnl_email.Controls.Add(this.txt_email);
            this.pnl_email.Location = new System.Drawing.Point(146, 66);
            this.pnl_email.Name = "pnl_email";
            this.pnl_email.Size = new System.Drawing.Size(227, 33);
            this.pnl_email.TabIndex = 35;
            this.pnl_email.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_lbl_form);
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_email.Location = new System.Drawing.Point(10, 9);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(205, 15);
            this.txt_email.TabIndex = 7;
            // 
            // pnl_form_input_customer
            // 
            this.pnl_form_input_customer.Controls.Add(this.note_password);
            this.pnl_form_input_customer.Controls.Add(this.pnl_email);
            this.pnl_form_input_customer.Controls.Add(this.lbl_email);
            this.pnl_form_input_customer.Controls.Add(this.btn_view_customer);
            this.pnl_form_input_customer.Controls.Add(this.pnl_password);
            this.pnl_form_input_customer.Controls.Add(this.lbl_password);
            this.pnl_form_input_customer.Controls.Add(this.pnl_id_account);
            this.pnl_form_input_customer.Controls.Add(this.lbl_id_account);
            this.pnl_form_input_customer.Controls.Add(this.pnl_id_customer);
            this.pnl_form_input_customer.Controls.Add(this.lbl_id_customer);
            this.pnl_form_input_customer.Location = new System.Drawing.Point(8, 43);
            this.pnl_form_input_customer.Name = "pnl_form_input_customer";
            this.pnl_form_input_customer.Size = new System.Drawing.Size(863, 132);
            this.pnl_form_input_customer.TabIndex = 5;
            this.pnl_form_input_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_form_input_customer_Paint);
            // 
            // note_password
            // 
            this.note_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.note_password.Location = new System.Drawing.Point(471, 103);
            this.note_password.Name = "note_password";
            this.note_password.Size = new System.Drawing.Size(342, 24);
            this.note_password.TabIndex = 36;
            this.note_password.Text = "* Nhân viên không có quyền sửa  mật khẩu của khách hàng";
            this.note_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Account_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_function);
            this.Controls.Add(this.table_account);
            this.Controls.Add(this.pnl_form_input_customer);
            this.Controls.Add(this.lbl_title);
            this.Name = "Account_GUI";
            this.Size = new System.Drawing.Size(885, 527);
            ((System.ComponentModel.ISupportInitialize)(this.table_account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnl_function.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.pnl_id_customer.ResumeLayout(false);
            this.pnl_id_customer.PerformLayout();
            this.pnl_id_account.ResumeLayout(false);
            this.pnl_id_account.PerformLayout();
            this.pnl_password.ResumeLayout(false);
            this.pnl_password.PerformLayout();
            this.pnl_email.ResumeLayout(false);
            this.pnl_email.PerformLayout();
            this.pnl_form_input_customer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private DevExpress.XtraGrid.GridControl table_account;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel pnl_function;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.TextBox txt_search;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel Button_exe_panel;
        private DevExpress.XtraEditors.LabelControl lbl_id_customer;
        private System.Windows.Forms.Panel pnl_id_customer;
        private System.Windows.Forms.TextBox txt_id_customer;
        private DevExpress.XtraEditors.LabelControl lbl_id_account;
        private System.Windows.Forms.Panel pnl_id_account;
        private System.Windows.Forms.TextBox txt_id_account;
        private DevExpress.XtraEditors.LabelControl lbl_password;
        private System.Windows.Forms.Panel pnl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_view_customer;
        private DevExpress.XtraEditors.LabelControl lbl_email;
        private System.Windows.Forms.Panel pnl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Panel pnl_form_input_customer;
        private System.Windows.Forms.Label note_password;
    }
}
