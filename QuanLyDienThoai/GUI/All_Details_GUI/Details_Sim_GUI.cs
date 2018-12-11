using QuanLyDienThoai.BUS;
using QuanLyDienThoai.DAL;
using QuanLyDienThoaiEntity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai.GUI.Sim_GUI
{
    public partial class Details_Sim_GUI : Form
    {
        CustomerBUS customerbus = new CustomerBUS();
        string id_sim, id_customer, numphone;
        bool? status;
       
        private void exit_winform_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
               
        public Details_Sim_GUI()
        {
            InitializeComponent();
        }

        public Details_Sim_GUI(string _id_sim, string _id_customer, string _numphone, bool? _status)
        {
            id_sim = _id_sim;
            id_customer = _id_customer;
            numphone = _numphone;
            status = _status;            
            InitializeComponent();
        }
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Details_Customer_GUI_Load(object sender, EventArgs e)
        {
            lbl_value_id_sim.Text = id_sim;
            lbl_value_id_customer.Text = id_customer;
            lbl_value_numphone.Text = numphone;
            if(status == false)
                group_rad_status.SelectedIndex = 0;
            else
                group_rad_status.SelectedIndex = 1;

        }       

        private void pnl_info_customer_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_info_customer });
        }
        private void pnl_line_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(66, 134, 244, e, new Panel[] { pnl_info_customer });
        }

        private void btn_view_customer_Click(object sender, EventArgs e)
        {
            if (customerbus.SearchById_Customer(lbl_value_id_customer.Text) != null)
            {
                List<CUSTOMER> result = customerbus.SearchById_Customer(lbl_value_id_customer.Text);
                Details_Customer_GUI details_customer = new Details_Customer_GUI(result[0].ID_CUSTOMER, result[0].NAME, result[0].IDENTIFY.ToString(), result[0].JOB, result[0].POSITION, result[0].ADDRESS);
                details_customer.ShowDialog();
            }
            else
                Print_MessageBox("Không có thông tin này !!!", "Lỗi");
        }
    }
}
