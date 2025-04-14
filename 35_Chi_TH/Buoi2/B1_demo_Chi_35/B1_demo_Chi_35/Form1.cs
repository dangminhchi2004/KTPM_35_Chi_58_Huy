using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1_demo_Chi_35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Cong_35_Chi_49_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_1_35_Chi_49.Text);
            b = int.Parse(txt_2_35_Chi_49.Text);
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a, b);
            ketqua = c.Execute("+");
            txt_3_35_Chi_49.Text = ketqua.ToString();

        }

        private void bt_Tru_35_Chi_49_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_1_35_Chi_49.Text);
            b = int.Parse(txt_2_35_Chi_49.Text);
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a, b);
            ketqua = c.Execute("-");
            txt_3_35_Chi_49.Text = ketqua.ToString();
        }

        private void bt_Nhan_35_Chi_49_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_1_35_Chi_49.Text);
            b = int.Parse(txt_2_35_Chi_49.Text);
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a, b);
            ketqua = c.Execute("*");
            txt_3_35_Chi_49.Text = ketqua.ToString();
        }

        private void bt_Chia_35_Chi_49_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_1_35_Chi_49.Text);
            b = int.Parse(txt_2_35_Chi_49.Text);
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a, b);
            ketqua = c.Execute("/");
            txt_3_35_Chi_49.Text = ketqua.ToString();
        }
    }
}
