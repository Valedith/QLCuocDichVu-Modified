using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using QuanLyDienThoai.BUS;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyDienThoai.GUI.Customer_GUI;
using QuanLyDienThoai.DAL;
using QuanLyDienThoai.Public;
using QuanLyDienThoaiEntity.Models;
using QuanLyDienThoai.GUI.Sim_GUI;

namespace QuanLyDienThoai.GUI.Account_GUI
{
    public partial class Account_GUI : UserControl
    {
        AccountBUS accountbus = new AccountBUS();
        CustomerBUS customerbus = new CustomerBUS();
        public Account_GUI()
        {
            InitializeComponent();
            txt_search.Text = "Tìm kiếm theo tên khách hàng...";

            txt_search.GotFocus += RemoveText;
            txt_search.LostFocus += AddText;
        }

        public void RemoveText(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
                txt_search.Text = "Tìm kiếm theo tên khách hàng...";
        }

        // Hàm tô màu viền cho panels
        private void setColorBorder(int r, int g, int b, PaintEventArgs e, Panel[] panels)
        {
            Color color = new Color();
            color = Color.FromArgb(r, g, b);
            for (int i = 0; i < panels.Length; i++)
            {
                ControlPaint.DrawBorder(e.Graphics, panels[i].ClientRectangle, color, ButtonBorderStyle.Solid);
            }
        }

        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Paint_lbl_form(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_id_customer, pnl_id_account, pnl_password, pnl_email });
        }

        private void pnl_form_input_customer_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(66, 134, 224, e, new Panel[] { pnl_form_input_customer });
        }

        // Hiển thị danh sách
        private void table_account_Load(object sender, EventArgs e)
        {
            table_account.DataSource = new BindingSource(accountbus.GetAll(), "");
            table_account.MainView.PopulateColumns();
            ((GridView)table_account.MainView).Columns[0].Caption = "Mã tài khoản";
            ((GridView)table_account.MainView).Columns[1].Caption = "Email";
            ((GridView)table_account.MainView).Columns[2].Visible = false;
            ((GridView)table_account.MainView).Columns[3].Caption = "Mã khách hàng";
            ((GridView)table_account.MainView).Columns[4].Caption = "Mật khẩu";
            ((GridView)table_account.MainView).Columns[5].Visible = false;
            ((GridView)table_account.MainView).Columns[6].Visible = false;
            ((GridView)table_account.MainView).Columns[7].Visible = false;
            ((GridView)table_account.MainView).Columns[8].Visible = false;
            ((GridView)table_account.MainView).Columns[9].Visible = false;
            ((GridView)table_account.MainView).Columns[10].Visible = false;

        }

        // Function thực hiện các thao tác button 
        private void Button_exe_panel_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag != null && btn.Tag.Equals("add"))
            {
                popup_add();
            }            
            else if (btn.Tag != null && btn.Tag.Equals("delete"))
            {
                delete();
            }
            else if (btn.Tag != null && btn.Tag.Equals("refresh"))
            {
                refresh();
            }
        }

        // Function get Data khi selected dòng đó
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID_ACCOUNT") != null)
            {
                txt_id_account.Text = gridView1.GetFocusedRowCellValue("ID_ACCOUNT").ToString();
                txt_id_customer.Text = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
                txt_email.Text = gridView1.GetFocusedRowCellValue("EMAIL").ToString();                
                txt_password.Text = gridView1.GetFocusedRowCellValue("PASSWORD").ToString();
            }    
        }

        // Function Load database to grid wiew
        private void loadDataTable()
        {
            table_account.DataSource = new BindingSource(accountbus.GetAll(), "");            
        }

        private void clear()
        {
            txt_id_customer.Text = txt_id_account.Text = txt_email.Text = txt_search.Text = txt_password.Text = "";            
            btn_view_customer.Enabled = false;
        }

        // Function làm tươi danh sách
        private void refresh()
        {
            clear();
            loadDataTable();
        }
       
        // Xem chi tiết của 1 khách hàng
        private void btn_view_customer_Click(object sender, EventArgs e)
        {
            if (customerbus.SearchById_Customer(txt_id_customer.Text) != null)
            {
                List<CUSTOMER> result = customerbus.SearchById_Customer(txt_id_customer.Text);
                Details_Customer_GUI details_customer = new Details_Customer_GUI(result[0].ID_CUSTOMER, result[0].NAME, result[0].IDENTIFY.ToString(), result[0].JOB, result[0].POSITION, result[0].ADDRESS);
                details_customer.ShowDialog();
            }
            else
                Print_MessageBox("Không có thông tin này !!!", "Lỗi");
        }
        
        // Function Popup Bảng thêm row
        private void popup_add()
        {            
            AddAccount_GUI addaccount = new AddAccount_GUI();
            addaccount.ShowDialog();
        }        

        // Function delete row
        private void delete()
        {
            DialogResult Dialogresult = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(Dialogresult == DialogResult.Yes)
            {
                string result = accountbus.Delete(txt_id_account.Text);
                Print_MessageBox(result, "Thông báo xóa");
                loadDataTable();
            }            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        } 

        // Function Tìm Tên KH
        private void search()
        {
            if (accountbus.SearchBy_CustomerName(txt_search.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                table_account.DataSource = new BindingSource(accountbus.SearchBy_CustomerName(txt_search.Text), "");
                txt_id_account.Text = gridView1.GetFocusedRowCellValue("ID_ACCOUNT").ToString();
                txt_id_customer.Text = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
                txt_email.Text = gridView1.GetFocusedRowCellValue("EMAIL").ToString();
                txt_password.Text = gridView1.GetFocusedRowCellValue("PASSWORD").ToString();
            }
        }
    }
}
