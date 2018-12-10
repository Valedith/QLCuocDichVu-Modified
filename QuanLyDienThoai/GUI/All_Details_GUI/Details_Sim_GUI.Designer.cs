namespace QuanLyDienThoai.GUI.Sim_GUI
{
    partial class Details_Sim_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details_Sim_GUI));
            this.pnl_title_winform = new System.Windows.Forms.Panel();
            this.pnl_icon_logo = new System.Windows.Forms.Panel();
            this.exit_winform = new System.Windows.Forms.Panel();
            this.title_winform = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_status = new DevExpress.XtraEditors.LabelControl();
            this.lbl_id_customer = new DevExpress.XtraEditors.LabelControl();
            this.lbl_id_sim = new DevExpress.XtraEditors.LabelControl();
            this.lbl_numphone = new DevExpress.XtraEditors.LabelControl();
            this.lbl_value_id_sim = new System.Windows.Forms.Label();
            this.lbl_value_id_customer = new System.Windows.Forms.Label();
            this.lbl_value_numphone = new System.Windows.Forms.Label();
            this.pnl_info_customer = new System.Windows.Forms.Panel();
            this.btn_view_customer = new System.Windows.Forms.Button();
            this.group_rad_status = new DevExpress.XtraEditors.RadioGroup();
            this.pnl_line = new System.Windows.Forms.Panel();
            this.pnl_title_winform.SuspendLayout();
            this.pnl_info_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_rad_status.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_title_winform
            // 
            this.pnl_title_winform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.pnl_title_winform.Controls.Add(this.pnl_icon_logo);
            this.pnl_title_winform.Controls.Add(this.exit_winform);
            this.pnl_title_winform.Controls.Add(this.title_winform);
            this.pnl_title_winform.Location = new System.Drawing.Point(0, 0);
            this.pnl_title_winform.Name = "pnl_title_winform";
            this.pnl_title_winform.Size = new System.Drawing.Size(570, 35);
            this.pnl_title_winform.TabIndex = 13;
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
            this.exit_winform.Location = new System.Drawing.Point(537, 6);
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
            this.title_winform.Size = new System.Drawing.Size(93, 25);
            this.title_winform.TabIndex = 0;
            this.title_winform.Text = "Chi tiết sim";
            this.title_winform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 26);
            this.panel1.TabIndex = 14;
            // 
            // lbl_status
            // 
            this.lbl_status.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_status.Appearance.Options.UseFont = true;
            this.lbl_status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_status.Location = new System.Drawing.Point(292, 71);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(67, 33);
            this.lbl_status.TabIndex = 20;
            this.lbl_status.Text = "Tình trạng:";
            // 
            // lbl_id_customer
            // 
            this.lbl_id_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_customer.Appearance.Options.UseFont = true;
            this.lbl_id_customer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_customer.Location = new System.Drawing.Point(15, 72);
            this.lbl_id_customer.Name = "lbl_id_customer";
            this.lbl_id_customer.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_customer.TabIndex = 22;
            this.lbl_id_customer.Text = "Mã khách hàng";
            // 
            // lbl_id_sim
            // 
            this.lbl_id_sim.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_sim.Appearance.Options.UseFont = true;
            this.lbl_id_sim.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_sim.Location = new System.Drawing.Point(15, 22);
            this.lbl_id_sim.Name = "lbl_id_sim";
            this.lbl_id_sim.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_sim.TabIndex = 18;
            this.lbl_id_sim.Text = "Mã Sim:";
            // 
            // lbl_numphone
            // 
            this.lbl_numphone.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_numphone.Appearance.Options.UseFont = true;
            this.lbl_numphone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_numphone.Location = new System.Drawing.Point(292, 21);
            this.lbl_numphone.Name = "lbl_numphone";
            this.lbl_numphone.Size = new System.Drawing.Size(109, 33);
            this.lbl_numphone.TabIndex = 23;
            this.lbl_numphone.Text = "Số điện thoại:";
            // 
            // lbl_value_id_sim
            // 
            this.lbl_value_id_sim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_value_id_sim.Location = new System.Drawing.Point(125, 22);
            this.lbl_value_id_sim.Name = "lbl_value_id_sim";
            this.lbl_value_id_sim.Size = new System.Drawing.Size(96, 33);
            this.lbl_value_id_sim.TabIndex = 24;
            this.lbl_value_id_sim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_value_id_customer
            // 
            this.lbl_value_id_customer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_value_id_customer.Location = new System.Drawing.Point(125, 72);
            this.lbl_value_id_customer.Name = "lbl_value_id_customer";
            this.lbl_value_id_customer.Size = new System.Drawing.Size(96, 33);
            this.lbl_value_id_customer.TabIndex = 25;
            this.lbl_value_id_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_value_numphone
            // 
            this.lbl_value_numphone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_value_numphone.Location = new System.Drawing.Point(390, 23);
            this.lbl_value_numphone.Name = "lbl_value_numphone";
            this.lbl_value_numphone.Size = new System.Drawing.Size(164, 33);
            this.lbl_value_numphone.TabIndex = 27;
            this.lbl_value_numphone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_info_customer
            // 
            this.pnl_info_customer.Controls.Add(this.btn_view_customer);
            this.pnl_info_customer.Controls.Add(this.group_rad_status);
            this.pnl_info_customer.Controls.Add(this.pnl_line);
            this.pnl_info_customer.Controls.Add(this.lbl_id_sim);
            this.pnl_info_customer.Controls.Add(this.lbl_id_customer);
            this.pnl_info_customer.Controls.Add(this.lbl_value_numphone);
            this.pnl_info_customer.Controls.Add(this.lbl_status);
            this.pnl_info_customer.Controls.Add(this.lbl_value_id_customer);
            this.pnl_info_customer.Controls.Add(this.lbl_numphone);
            this.pnl_info_customer.Controls.Add(this.lbl_value_id_sim);
            this.pnl_info_customer.Location = new System.Drawing.Point(0, 35);
            this.pnl_info_customer.Name = "pnl_info_customer";
            this.pnl_info_customer.Size = new System.Drawing.Size(570, 189);
            this.pnl_info_customer.TabIndex = 30;
            this.pnl_info_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_customer_Paint);
            // 
            // btn_view_customer
            // 
            this.btn_view_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btn_view_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_customer.ForeColor = System.Drawing.Color.White;
            this.btn_view_customer.Location = new System.Drawing.Point(227, 70);
            this.btn_view_customer.Name = "btn_view_customer";
            this.btn_view_customer.Size = new System.Drawing.Size(38, 35);
            this.btn_view_customer.TabIndex = 36;
            this.btn_view_customer.Text = "Xem";
            this.btn_view_customer.UseVisualStyleBackColor = false;
            this.btn_view_customer.Click += new System.EventHandler(this.btn_view_customer_Click);
            // 
            // group_rad_status
            // 
            this.group_rad_status.Enabled = false;
            this.group_rad_status.Location = new System.Drawing.Point(365, 73);
            this.group_rad_status.Name = "group_rad_status";
            this.group_rad_status.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chưa sử dụng", true, "0"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Đã sử dụng", true, "1")});
            this.group_rad_status.Size = new System.Drawing.Size(195, 34);
            this.group_rad_status.TabIndex = 34;
            // 
            // pnl_line
            // 
            this.pnl_line.Location = new System.Drawing.Point(273, 11);
            this.pnl_line.Name = "pnl_line";
            this.pnl_line.Size = new System.Drawing.Size(2, 100);
            this.pnl_line.TabIndex = 30;
            this.pnl_line.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_line_Paint);
            // 
            // Details_Sim_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 248);
            this.Controls.Add(this.pnl_info_customer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title_winform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details_Sim_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Details_Customer_GUI_Load);
            this.pnl_title_winform.ResumeLayout(false);
            this.pnl_info_customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group_rad_status.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title_winform;
        private System.Windows.Forms.Panel pnl_icon_logo;
        private System.Windows.Forms.Panel exit_winform;
        private System.Windows.Forms.Label title_winform;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lbl_status;
        private DevExpress.XtraEditors.LabelControl lbl_id_customer;
        private DevExpress.XtraEditors.LabelControl lbl_id_sim;
        private DevExpress.XtraEditors.LabelControl lbl_numphone;
        private System.Windows.Forms.Label lbl_value_id_sim;
        private System.Windows.Forms.Label lbl_value_id_customer;
        private System.Windows.Forms.Label lbl_value_numphone;
        private System.Windows.Forms.Panel pnl_info_customer;
        private System.Windows.Forms.Panel pnl_line;
        private DevExpress.XtraEditors.RadioGroup group_rad_status;
        private System.Windows.Forms.Button btn_view_customer;
    }
}