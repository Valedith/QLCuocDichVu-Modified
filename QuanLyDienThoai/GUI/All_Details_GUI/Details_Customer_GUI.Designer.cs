namespace QuanLyDienThoai.GUI.Sim_GUI
{
    partial class Details_Customer_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details_Customer_GUI));
            this.pnl_title_winform = new System.Windows.Forms.Panel();
            this.pnl_icon_logo = new System.Windows.Forms.Panel();
            this.exit_winform = new System.Windows.Forms.Panel();
            this.title_winform = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_id_customer = new DevExpress.XtraEditors.LabelControl();
            this.lbl_name = new DevExpress.XtraEditors.LabelControl();
            this.lbl_value_id_customer = new System.Windows.Forms.Label();
            this.lbl_value_iden = new System.Windows.Forms.Label();
            this.lbl_value_name = new System.Windows.Forms.Label();
            this.lbl_value_position = new System.Windows.Forms.Label();
            this.pnl_info_customer = new System.Windows.Forms.Panel();
            this.pnl_line = new System.Windows.Forms.Panel();
            this.lbl_address = new DevExpress.XtraEditors.LabelControl();
            this.lbl_value_address = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_value_job = new System.Windows.Forms.Label();
            this.pnl_title_winform.SuspendLayout();
            this.pnl_info_customer.SuspendLayout();
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
            this.title_winform.Size = new System.Drawing.Size(153, 25);
            this.title_winform.TabIndex = 0;
            this.title_winform.Text = "Chi tiết khách hàng";
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
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(292, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 33);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Chức vụ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(15, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 33);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "CMND:";
            // 
            // lbl_id_customer
            // 
            this.lbl_id_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_customer.Appearance.Options.UseFont = true;
            this.lbl_id_customer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_customer.Location = new System.Drawing.Point(15, 22);
            this.lbl_id_customer.Name = "lbl_id_customer";
            this.lbl_id_customer.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_customer.TabIndex = 18;
            this.lbl_id_customer.Text = "Mã khách hàng:";
            // 
            // lbl_name
            // 
            this.lbl_name.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_name.Appearance.Options.UseFont = true;
            this.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_name.Location = new System.Drawing.Point(292, 21);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(109, 33);
            this.lbl_name.TabIndex = 23;
            this.lbl_name.Text = "Tên khách hàng:";
            // 
            // lbl_value_id_customer
            // 
            this.lbl_value_id_customer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_value_id_customer.Location = new System.Drawing.Point(125, 22);
            this.lbl_value_id_customer.Name = "lbl_value_id_customer";
            this.lbl_value_id_customer.Size = new System.Drawing.Size(147, 33);
            this.lbl_value_id_customer.TabIndex = 24;
            this.lbl_value_id_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_value_iden
            // 
            this.lbl_value_iden.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_value_iden.Location = new System.Drawing.Point(125, 72);
            this.lbl_value_iden.Name = "lbl_value_iden";
            this.lbl_value_iden.Size = new System.Drawing.Size(147, 33);
            this.lbl_value_iden.TabIndex = 25;
            this.lbl_value_iden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_value_name
            // 
            this.lbl_value_name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_value_name.Location = new System.Drawing.Point(407, 23);
            this.lbl_value_name.Name = "lbl_value_name";
            this.lbl_value_name.Size = new System.Drawing.Size(147, 33);
            this.lbl_value_name.TabIndex = 27;
            this.lbl_value_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_value_position
            // 
            this.lbl_value_position.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_value_position.Location = new System.Drawing.Point(407, 73);
            this.lbl_value_position.Name = "lbl_value_position";
            this.lbl_value_position.Size = new System.Drawing.Size(147, 33);
            this.lbl_value_position.TabIndex = 28;
            this.lbl_value_position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_info_customer
            // 
            this.pnl_info_customer.Controls.Add(this.pnl_line);
            this.pnl_info_customer.Controls.Add(this.lbl_id_customer);
            this.pnl_info_customer.Controls.Add(this.lbl_value_address);
            this.pnl_info_customer.Controls.Add(this.labelControl1);
            this.pnl_info_customer.Controls.Add(this.lbl_value_position);
            this.pnl_info_customer.Controls.Add(this.labelControl2);
            this.pnl_info_customer.Controls.Add(this.lbl_value_name);
            this.pnl_info_customer.Controls.Add(this.labelControl3);
            this.pnl_info_customer.Controls.Add(this.lbl_value_job);
            this.pnl_info_customer.Controls.Add(this.lbl_address);
            this.pnl_info_customer.Controls.Add(this.lbl_value_iden);
            this.pnl_info_customer.Controls.Add(this.lbl_name);
            this.pnl_info_customer.Controls.Add(this.lbl_value_id_customer);
            this.pnl_info_customer.Location = new System.Drawing.Point(0, 35);
            this.pnl_info_customer.Name = "pnl_info_customer";
            this.pnl_info_customer.Size = new System.Drawing.Size(570, 189);
            this.pnl_info_customer.TabIndex = 30;
            this.pnl_info_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_customer_Paint);
            // 
            // pnl_line
            // 
            this.pnl_line.Location = new System.Drawing.Point(273, 18);
            this.pnl_line.Name = "pnl_line";
            this.pnl_line.Size = new System.Drawing.Size(2, 151);
            this.pnl_line.TabIndex = 30;
            this.pnl_line.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_line_Paint);
            // 
            // lbl_address
            // 
            this.lbl_address.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_address.Appearance.Options.UseFont = true;
            this.lbl_address.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_address.Location = new System.Drawing.Point(292, 121);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(77, 33);
            this.lbl_address.TabIndex = 19;
            this.lbl_address.Text = "Địa chỉ:";
            // 
            // lbl_value_address
            // 
            this.lbl_value_address.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_value_address.Location = new System.Drawing.Point(407, 122);
            this.lbl_value_address.Name = "lbl_value_address";
            this.lbl_value_address.Size = new System.Drawing.Size(147, 47);
            this.lbl_value_address.TabIndex = 29;
            this.lbl_value_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(15, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 33);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Nghề nghiệp:";
            // 
            // lbl_value_job
            // 
            this.lbl_value_job.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_value_job.Location = new System.Drawing.Point(125, 122);
            this.lbl_value_job.Name = "lbl_value_job";
            this.lbl_value_job.Size = new System.Drawing.Size(147, 33);
            this.lbl_value_job.TabIndex = 26;
            this.lbl_value_job.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Details_Customer_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 248);
            this.Controls.Add(this.pnl_info_customer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title_winform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details_Customer_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Details_Customer_GUI_Load);
            this.pnl_title_winform.ResumeLayout(false);
            this.pnl_info_customer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title_winform;
        private System.Windows.Forms.Panel pnl_icon_logo;
        private System.Windows.Forms.Panel exit_winform;
        private System.Windows.Forms.Label title_winform;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_id_customer;
        private DevExpress.XtraEditors.LabelControl lbl_name;
        private System.Windows.Forms.Label lbl_value_id_customer;
        private System.Windows.Forms.Label lbl_value_iden;
        private System.Windows.Forms.Label lbl_value_name;
        private System.Windows.Forms.Label lbl_value_position;
        private System.Windows.Forms.Panel pnl_info_customer;
        private System.Windows.Forms.Panel pnl_line;
        private System.Windows.Forms.Label lbl_value_address;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label lbl_value_job;
        private DevExpress.XtraEditors.LabelControl lbl_address;
    }
}