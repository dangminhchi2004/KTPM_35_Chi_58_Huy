using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_Demo_Chi_35
{
    public class Class1_demo_Chi_35
    {
        private int a_35_Chi, b_35_Chi;
        public Class1_demo_Chi_35(int a_35_Chi, int b_35_Chi)
        {
            this.a_35_Chi = a_35_Chi;
            this.b_35_Chi = b_35_Chi;
        }
        public int Execute_35_Chi(String CalSymbol_35_Chi)
        {
            int result_35_Chi = 0;
            switch (CalSymbol_35_Chi)
            {
                case "+":
                    result_35_Chi = this.a_35_Chi + this.b_35_Chi;
                    break;
                case "-":
                    result_35_Chi = this.a_35_Chi - this.b_35_Chi;
                    break;
                case "*":
                    result_35_Chi = this.a_35_Chi * this.b_35_Chi;
                    break;
                case "/":
                    result_35_Chi = this.a_35_Chi / this.b_35_Chi;
                    break;
            }
            return result_35_Chi;
        }

    }
}
