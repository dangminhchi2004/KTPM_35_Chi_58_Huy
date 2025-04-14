using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_Chi_58_Huy_ConvertDecimal
{
    public partial class Form1_35_Chi_58_Huy: Form
    {
        public Form1_35_Chi_58_Huy()
        {
            InitializeComponent();
        }

        private void btnConvert_35_Chi_58_Huy_Click(object sender, EventArgs e)
        {
            int number_35_Chi_58_Huy = int.Parse(txtSo_35_Chi_58_Huy.Text);
            int radix_35_Chi_58_Huy = int.Parse(box_CoSo_35_Chi_58_Huy.SelectedItem.ToString());
            Radix_35_Chi_58_Huy r_35_Chi_58_Huy = new Radix_35_Chi_58_Huy(number_35_Chi_58_Huy);
            string result_35_Chi_58_Huy = r_35_Chi_58_Huy.ConvertDecimalToAnother_35_Chi_58_Huy(radix_35_Chi_58_Huy);
            txtKQ_35_Chi_58_Huy.Text = result_35_Chi_58_Huy;
        }
    }
}
