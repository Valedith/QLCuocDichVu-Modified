using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDienThoai.BUS;
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;
using DevExpress.XtraBars.Docking2010;
using QuanLyDienThoai.GUI.Customer_GUI;
using QuanLyDienThoai.DAL;
using QuanLyDienThoai.GUI.Sim_GUI;
using QuanLyDienThoaiEntity.Models;

namespace QuanLyDienThoai.GUI.Contract_GUI
{
    public partial class Contract_GUI : UserControl
    {
        ContractBUS contractbus = new ContractBUS();
        SimBUS simbus = new SimBUS();
        public Contract_GUI()
        {
            InitializeComponent();
            Loadinfo_input();
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

        // Tạo sẵn giá trị trong input như sau
        private void Loadinfo_input()
        {
            DateTime d = DateTime.Now;
            picker_dateregister.Value = d;
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
        private void pnl_contract_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_id_sim, pnl_dateregister, pnl_fee, pnl_id_contract });
        }

        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridView1.GetFocusedRowCellValue("ID_CONTRACT") != null)
            {
                txt_id_contract.Text = gridView1.GetFocusedRowCellValue("ID_CONTRACT").ToString();
                txt_id_sim.Text = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();

                DateTime date = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("DATEREGISTER").ToString());
                picker_dateregister.Value = date;
                txt_fee.Text = gridView1.GetFocusedRowCellValue("FEE").ToString();
                string status =  gridView1.GetFocusedRowCellValue("STATUS").ToString();
                if (status == "True")
                    group_rad_status.SelectedIndex = 1;
                else
                    group_rad_status.SelectedIndex = 0;
            }
        }

        // Function Load database to grid wiew
        private void table_contract_Load(object sender, EventArgs e)
        {            
            table_contract.DataSource = new BindingSource(contractbus.GetAll(), "");
            table_contract.MainView.PopulateColumns();
            ((GridView)table_contract.MainView).Columns[0].Caption = "Mã hợp đồng";
            ((GridView)table_contract.MainView).Columns[1].Caption = "Mã Sim";
            ((GridView)table_contract.MainView).Columns[2].Caption = "Ngày đăng kí";
            ((GridView)table_contract.MainView).Columns[3].Caption = "Phí";
            ((GridView)table_contract.MainView).Columns[4].Caption = "Tình trạng";
            ((GridView)table_contract.MainView).Columns[5].Visible = false;              
        }

        // Function xem chi tiết sim
        private void btn_view_sim_Click(object sender, EventArgs e)
        {
            if (simbus.SearchById_Sim(txt_id_sim.Text) != null)
            {
                List<SIM> result = simbus.SearchById_Sim(txt_id_sim.Text);
                Details_Sim_GUI details_sim = new Details_Sim_GUI(result[0].ID_SIM, result[0].ID_CUSTOMER, result[0].PHONENUMBER.ToString(), result[0].STATUS);
                details_sim.ShowDialog();
            }
            else
                Print_MessageBox("Không có thông tin này !!!", "Lỗi");
        }

        private void clear()
        {
            Loadinfo_input();
            txt_id_contract.Text = txt_id_sim.Text = txt_fee.Text = txt_search.Text = "";
            picker_dateregister.Value = DateTime.Now;
        }

        // Function làm tươi danh sách
        private void refresh()
        {
            clear();
            gridView1.RefreshData();
            table_contract.DataSource = new BindingSource(contractbus.GetAll(), "");
        }

        // Function Popup Bảng thêm row
        private void popup_add()
        {
            AddContract_GUI addcontract_gui = new AddContract_GUI();
            addcontract_gui.ShowDialog();
        }

        // Functio sửa row
        private void edit()
        {
            bool status = true;
            string id_customer = simbus.getIDcustomer_in_Sim(txt_id_sim.Text);
            simbus.Update_ID_Customer(txt_id_sim.Text, id_customer, true);
            if (group_rad_status.SelectedIndex == 0)
            {
                status = false;                
                simbus.Update_ID_Customer(txt_id_sim.Text, id_customer, false);
            }
            if(picker_dateregister.Value.Date>DateTime.Now.Date)
            {
                Print_MessageBox("Ngày đăng ký không hợp lệ !", "Kết quả");
            }
            else
            {
                contractbus.Update(txt_id_contract.Text, txt_id_sim.Text, picker_dateregister.Value, Convert.ToInt32(txt_fee.Text), status);
                Print_MessageBox("Sửa thông tin khách hàng thành công", "Thông báo sửa");
                table_contract.DataSource = new BindingSource(contractbus.GetAll(), "");
            }                       
        }

        // Function delete row
        private void delete()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                contractbus.Delete(txt_id_contract.Text);
                simbus.Update_ID_Customer(txt_id_sim.Text,null,false);
                Print_MessageBox("Xóa thành công", "Thông báo xóa");
                table_contract.DataSource = new BindingSource(contractbus.GetAll(), "");
            }
        }

        private void txt_fee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            if (contractbus.SearchBy_CustomerName(txt_search.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                table_contract.DataSource = new BindingSource(contractbus.SearchBy_CustomerName(txt_search.Text), "");
                txt_id_contract.Text = gridView1.GetFocusedRowCellValue("ID_CONTRACT").ToString();
                txt_id_sim.Text = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();

                DateTime date = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("DATEREGISTER").ToString());
                picker_dateregister.Value = date;
                txt_fee.Text = gridView1.GetFocusedRowCellValue("FEE").ToString();
                string status = gridView1.GetFocusedRowCellValue("STATUS").ToString();
                if (status == "True")
                    group_rad_status.SelectedIndex = 1;
                else
                    group_rad_status.SelectedIndex = 0;
            }
        }
    }
}
