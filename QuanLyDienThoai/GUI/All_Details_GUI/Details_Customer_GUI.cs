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
    public partial class Details_Customer_GUI : Form
    {
        string id_customer, name, iden, job, position, address;
       
        private void exit_winform_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
               
        public Details_Customer_GUI()
        {
            InitializeComponent();
        }

        public Details_Customer_GUI(string _id_customer, string _name, string _iden, string _job, string _position, string _address)
        {
            id_customer = _id_customer;
            name = _name;
            iden = _iden;
            job = _job;
            position = _position;
            address = _address;
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

        private void Details_Customer_GUI_Load(object sender, EventArgs e)
        {
            lbl_value_id_customer.Text = id_customer;
            lbl_value_name.Text = name;
            lbl_value_iden.Text = iden;
            lbl_value_job.Text = job;
            lbl_value_position.Text = position;
            lbl_value_address.Text = address;
        }
        private void pnl_info_customer_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_info_customer });
        }
        private void pnl_line_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(66, 134, 244, e, new Panel[] { pnl_info_customer });
        }


    }
}
