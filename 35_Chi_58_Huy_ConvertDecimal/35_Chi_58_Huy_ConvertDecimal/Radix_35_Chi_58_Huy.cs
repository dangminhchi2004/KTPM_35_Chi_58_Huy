using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Chi_58_Huy_ConvertDecimal
{
    public class Radix_35_Chi_58_Huy
    {
        private int number_35_Chi_58_Huy;

        public Radix_35_Chi_58_Huy(int number_35_Chi_58_Huy)
        {
            if (number_35_Chi_58_Huy < 0)
            {
                throw new ArgumentException("Incorrect Value");
            }
            this.number_35_Chi_58_Huy = number_35_Chi_58_Huy;
        }

        public string ConvertDecimalToAnother_35_Chi_58_Huy(int radix_35_Chi_58_Huy = 2)
        {
            int n_35_Chi_58_Huy = this.number_35_Chi_58_Huy;

            if (radix_35_Chi_58_Huy < 2 || radix_35_Chi_58_Huy > 16)
            {
                throw new ArgumentException("Invalid Radix");
            }

            if (n_35_Chi_58_Huy == 0)
            {
                return "0";
            }

            List<string> result_35_Chi_58_Huy = new List<string>();

            while (n_35_Chi_58_Huy > 0)
            {
                int value = n_35_Chi_58_Huy % radix_35_Chi_58_Huy;

                if (value < 10)
                {
                    result_35_Chi_58_Huy.Add(value.ToString());
                }
                else
                {
                    switch (value)
                    {
                        case 10: result_35_Chi_58_Huy.Add("A"); break;
                        case 11: result_35_Chi_58_Huy.Add("B"); break;
                        case 12: result_35_Chi_58_Huy.Add("C"); break;
                        case 13: result_35_Chi_58_Huy.Add("D"); break;
                        case 14: result_35_Chi_58_Huy.Add("E"); break;
                        case 15: result_35_Chi_58_Huy.Add("F"); break;
                    }
                }

                n_35_Chi_58_Huy /= radix_35_Chi_58_Huy;
            }

            result_35_Chi_58_Huy.Reverse();
            return string.Join("", result_35_Chi_58_Huy.ToArray());
        }
    }
}
