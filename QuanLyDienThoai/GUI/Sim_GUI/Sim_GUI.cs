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

namespace QuanLyDienThoai.GUI.Sim_GUI
{
    public partial class Sim_GUI : UserControl
    {
        SimBUS simbus = new SimBUS();
        CustomerBUS customerbus = new CustomerBUS();
        public Sim_GUI()
        {
            InitializeComponent();
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
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_id_customer,pnl_id_sim,pnl_numphone});
        }

        private void pnl_form_input_customer_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(66, 134, 224, e, new Panel[] { pnl_form_input_customer });
        }

        // Hiển thị danh sách
        private void table_sim_Load(object sender, EventArgs e)
        {
            table_sim.DataSource = new BindingSource(simbus.GetAll(), "");
            table_sim.MainView.PopulateColumns();
            ((GridView)table_sim.MainView).Columns[0].Caption = "Mã Sim";
            ((GridView)table_sim.MainView).Columns[1].Caption = "Mã khách hàng";
            ((GridView)table_sim.MainView).Columns[2].Caption = "Số điện thoại";
            ((GridView)table_sim.MainView).Columns[3].Caption = "Tình trạng";
            ((GridView)table_sim.MainView).Columns[4].Visible = false;
            ((GridView)table_sim.MainView).Columns[5].Visible = false;
            ((GridView)table_sim.MainView).Columns[6].Visible = false;
            ((GridView)table_sim.MainView).Columns[7].Visible = false;
        }

        // Function thực hiện các thao tác button 
        private void Button_exe_panel_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag != null && btn.Tag.Equals("add"))
            {
                popup_add();
            }
            else if (btn.Tag != null && btn.Tag.Equals("edit"))
            {
                edit();
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
            if (gridView1.GetFocusedRowCellValue("ID_SIM") != null)
            {
                btn_view_customer.Enabled = true;
                txt_id_sim.Text = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
                if (gridView1.GetFocusedRowCellValue("ID_CUSTOMER") == null)
                {
                    txt_id_customer.Text = "";
                }
                else
                    txt_id_customer.Text = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
                txt_numphone.Text = gridView1.GetFocusedRowCellValue("PHONENUMBER").ToString();
                string status = gridView1.GetFocusedRowCellValue("STATUS").ToString();
                if (status == "True")
                    group_rad_status.SelectedIndex = 1;
                else
                    group_rad_status.SelectedIndex = 0;
            }               
        }

        // Function Load database to grid wiew
        private void loadDataTable()
        {
            table_sim.DataSource = new BindingSource(simbus.GetAll(), "");            
        }

        private void clear()
        {
            txt_id_customer.Text = txt_id_sim.Text = txt_numphone.Text = txt_search.Text = "";
            group_rad_status.SelectedIndex = 0;
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

        // Function Tìm Tên KH
        private void search()
        {
           
        }

        // Function Popup Bảng thêm row
        private void popup_add()
        {
            AddSim_GUI addsim = new AddSim_GUI();
            addsim.ShowDialog();
        }

        // Functio sửa row
        private void edit()
        {
            bool status = true;
            if (group_rad_status.SelectedIndex == 0)
                status = false;
            else
                status = true;            
            string result = simbus.Update(txt_id_sim.Text, txt_id_customer.Text, Convert.ToInt32(txt_numphone.Text), status);
            Print_MessageBox(result, "Thông báo sửa");
        }

        // Function delete row
        private void delete()
        {
            DialogResult Dialogresult = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(Dialogresult == DialogResult.Yes)
            {
                string result = simbus.Delete(txt_id_sim.Text);
                Print_MessageBox(result, "Thông báo xóa");
                loadDataTable();
            }            
        }

        private void txt_numphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
