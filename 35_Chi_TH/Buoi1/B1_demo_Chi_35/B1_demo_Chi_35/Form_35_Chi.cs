using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1_Demo_Chi_35
{
    public partial class Form_35_Chi : Form
    {
        public Form_35_Chi()
        {
            InitializeComponent();
        }

        private void bt_Cong_35_Chi_49_Click(object sender, EventArgs e)
        {
            int a_35_Chi, b_35_Chi, ketqua_35_Chi;
            a_35_Chi = int.Parse(txt_1_35_Chi_49.Text);
            b_35_Chi = int.Parse(txt_2_35_Chi_49.Text);
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a_35_Chi, b_35_Chi);
            ketqua_35_Chi = c.Execute_35_Chi("+");
            txt_3_35_Chi_49.Text = ketqua_35_Chi.ToString();

        }

        private void bt_Tru_35_Chi_49_Click(object sender, EventArgs e)
        {
            int a_35_Chi, b_35_Chi, ketqua_35_Chi;
            a_35_Chi = int.Parse(txt_1_35_Chi_49.Text);
            b_35_Chi = int.Parse(txt_2_35_Chi_49.Text);
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a_35_Chi, b_35_Chi);
            ketqua_35_Chi = c.Execute_35_Chi("-");
            txt_3_35_Chi_49.Text = ketqua_35_Chi.ToString();

        }

        private void bt_Nhan_35_Chi_49_Click(object sender, EventArgs e)
        {
            int a_35_Chi, b_35_Chi, ketqua_35_Chi;
            a_35_Chi = int.Parse(txt_1_35_Chi_49.Text);
            b_35_Chi = int.Parse(txt_2_35_Chi_49.Text);
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a_35_Chi, b_35_Chi);
            ketqua_35_Chi = c.Execute_35_Chi("*");
            txt_3_35_Chi_49.Text = ketqua_35_Chi.ToString();

        }

        private void bt_Chia_35_Chi_49_Click(object sender, EventArgs e)
        {
            int a_35_Chi, b_35_Chi, ketqua_35_Chi;
            a_35_Chi = int.Parse(txt_1_35_Chi_49.Text);
            b_35_Chi = int.Parse(txt_2_35_Chi_49.Text);
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a_35_Chi, b_35_Chi);
            ketqua_35_Chi = c.Execute_35_Chi("/");
            txt_3_35_Chi_49.Text = ketqua_35_Chi.ToString();

        }
    }
}
