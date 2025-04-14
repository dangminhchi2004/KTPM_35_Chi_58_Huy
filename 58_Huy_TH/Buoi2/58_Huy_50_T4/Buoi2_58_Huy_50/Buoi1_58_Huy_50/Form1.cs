using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi1_58_Huy_50
{
    public partial class Form1_58_Huy : Form
    {
        public Form1_58_Huy()
        {
            InitializeComponent();
        }

        private void btn_Cong_58_Huy_Click(object sender, EventArgs e)
        {
            int a_58_huy, b_58_Huy, kq_58_Huy;
            a_58_huy = int.Parse(txt_1_58_Huy.Text);
            b_58_Huy = int.Parse(txt_2_58_Huy.Text);
            Class_58_Huy_50 c_58_Huy_50 = new Class_58_Huy_50(a_58_huy, b_58_Huy);
            kq_58_Huy = c_58_Huy_50.Excute_58_Huy("+");
            txt_kq_58_Huy.Text = kq_58_Huy.ToString();
        }

        private void btn_Tru_58_Huy_Click(object sender, EventArgs e)
        {
            int a_58_huy, b_58_Huy, kq_58_Huy;
            a_58_huy = int.Parse(txt_1_58_Huy.Text);
            b_58_Huy = int.Parse(txt_2_58_Huy.Text);
            Class_58_Huy_50 c_58_Huy_50 = new Class_58_Huy_50(a_58_huy, b_58_Huy);
            kq_58_Huy = c_58_Huy_50.Excute_58_Huy("-");
            txt_kq_58_Huy.Text = kq_58_Huy.ToString();
        }

        private void btn_Nhan_58_Huy_Click(object sender, EventArgs e)
        {
            int a_58_huy, b_58_Huy, kq_58_Huy;
            a_58_huy = int.Parse(txt_1_58_Huy.Text);
            b_58_Huy = int.Parse(txt_2_58_Huy.Text);
            Class_58_Huy_50 c_58_Huy_50 = new Class_58_Huy_50(a_58_huy, b_58_Huy);
            kq_58_Huy = c_58_Huy_50.Excute_58_Huy("*");
            txt_kq_58_Huy.Text = kq_58_Huy.ToString();
        }

        private void btn_Chia_58_Huy_Click(object sender, EventArgs e)
        {
            int a_58_huy, b_58_Huy, kq_58_Huy;
            a_58_huy = int.Parse(txt_1_58_Huy.Text);
            b_58_Huy = int.Parse(txt_2_58_Huy.Text);
            Class_58_Huy_50 c_58_Huy_50 = new Class_58_Huy_50(a_58_huy, b_58_Huy);
            kq_58_Huy = c_58_Huy_50.Excute_58_Huy("/");
            txt_kq_58_Huy.Text = kq_58_Huy.ToString();
        }
    }
}
