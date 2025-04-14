using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_58_Huy_50
{
    public class Class_58_Huy_50
    {
        private int a_58_Huy, b_58_Huy;
        public Class_58_Huy_50(int a_58_Huy, int b_58_Huy)
        {
            this.a_58_Huy = a_58_Huy;
            this.b_58_Huy = b_58_Huy;
        }

        public int Excute_58_Huy(string CalSymbol_58_Huy)
        {
            int result_58_Huy = 0;
            switch (CalSymbol_58_Huy)
            {
                case "+":
                    result_58_Huy = this.a_58_Huy + this.b_58_Huy;
                    break;
                case "-":
                    result_58_Huy = this.a_58_Huy - this.b_58_Huy;
                    break;
                case "*":
                    result_58_Huy = this.a_58_Huy * this.b_58_Huy;
                    break;
                case "/":
                    result_58_Huy = this.a_58_Huy / this.b_58_Huy;
                    break;
            }
            return result_58_Huy;
        }
    }
}
