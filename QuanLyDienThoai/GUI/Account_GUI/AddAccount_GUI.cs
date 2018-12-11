using QuanLyDienThoai.BUS;
using DevExpress.XtraBars.Docking2010;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyDienThoai.Public;

namespace QuanLyDienThoai.GUI.Account_GUI
{
    public partial class AddAccount_GUI : Form
    {
        CustomerBUS customer = new CustomerBUS();
        AccountBUS accountbus = new AccountBUS();
        public AddAccount_GUI()
        {
            InitializeComponent();
        }

        // Load bảng khách hàng để chọn
        private void table_customer_Load(object sender, EventArgs e)
        {
            table_customer.DataSource = new BindingSource(customer.GetAll(), "");
            table_customer.MainView.PopulateColumns();
            ((GridView)table_customer.MainView).Columns[0].Caption = "Mã khách hàng";
            ((GridView)table_customer.MainView).Columns[1].Caption = "Tên khách hàng";
            ((GridView)table_customer.MainView).Columns[2].Caption = "Số CMND";
            ((GridView)table_customer.MainView).Columns[3].Caption = "Nghề nghiệp";
            ((GridView)table_customer.MainView).Columns[4].Visible = false;
            ((GridView)table_customer.MainView).Columns[5].Visible = false;
            ((GridView)table_customer.MainView).Columns[6].Visible = false;
            ((GridView)table_customer.MainView).Columns[7].Visible = false;
        }

        // Chọn dòng khách hàng để thêm sim
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID_CUSTOMER") != null)
            {
                txt_id_customer.Text = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();                
            }                     
        }               

        // Function click các nút button để thực hiện các thao tác
        private void function_panel_btn_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if(btn.Tag != null && btn.Tag.Equals("save"))
            {
                Add();
            }
            else if (btn.Tag != null && btn.Tag.Equals("save_new"))
            {
                Add_New();
            }
            else if (btn.Tag != null && btn.Tag.Equals("save_close"))
            {
                Add_Close();   
            }
            else if(btn.Tag != null && btn.Tag.Equals("refresh"))
            {
                Refresh_All();
            }
            else if(btn.Tag != null && btn.Tag.Equals("close"))
            {
                close();
            }
        }

        // Function click exit
        private void exit_winform_Click(object sender, EventArgs e)
        {
            close();
        }

        // Hàm tô màu viền cho panels
        private void setColorBorder(int r, int g, int b, PaintEventArgs e, Panel[] panels)
        {
            Color color = new Color();
            color = Color.FromArgb(r, g, b);
            for(int i = 0; i < panels.Length; i++) {
                ControlPaint.DrawBorder(e.Graphics, panels[i].ClientRectangle, color, ButtonBorderStyle.Solid);
            }
            
        }        
        private void form_info_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(66, 134, 224, e, new Panel[] { form_info });
        }
        private void pnl_window_add_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_window_add });
        }        

        private void pnl_info_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_id_customer, pnl_email, pnl_password, panel_conPass});
        }

        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {            
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Function Thêm khách hàng
        private void Add()
        {
            DialogResult Dialogresult = MessageBox.Show("Chú ý: Password khi tạo sẽ bị mã hóa", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Dialogresult == DialogResult.Yes)
            {
                string passwordhash = MD5Hash.CreateMD5(txt_password.Text);
                string confirmpass_hash = MD5Hash.CreateMD5(txt_confirmPass.Text);
                string result = accountbus.Create(txt_email.Text, txt_id_customer.Text, passwordhash,confirmpass_hash);
                Print_MessageBox(result, "Thông báo thêm");
                
            }            
        }

        // Function Thêm khách hàng ==> refresh
        private void Add_New()
        {
            Add();
            Refresh_All();
        }

        // Function Thêm khách hàng ==> close
        private void Add_Close()
        {
            Add();
            Close();
        }

        // Function làm lại, refresh
        private void Refresh_All()
        {
            TextBox[] textboxs = new TextBox[] { txt_id_customer, txt_email};
            for (int i = 0; i < textboxs.Length; i++)
            {
                textboxs[i].Text = "";
            }
        }

        // Function Đóng bảng
        private void close()
        {
            this.Dispose();
        }

        
    }
}
