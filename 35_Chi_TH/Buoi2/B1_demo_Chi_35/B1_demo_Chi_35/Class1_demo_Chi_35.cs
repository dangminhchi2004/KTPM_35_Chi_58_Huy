using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_demo_Chi_35
{
    public class Class1_demo_Chi_35
    {
        private int a_Chi_35, b_Chi_35;
        public Class1_demo_Chi_35(int a_Chi_35, int b_Chi_35)
        {
            this.a_Chi_35 = a_Chi_35;
            this.b_Chi_35 = b_Chi_35;
        }
        public int Execute(String CalSymbol)
        {
            int result = 0;
            switch (CalSymbol)
            {
                case "+":
                    result = this.a_Chi_35 + this.b_Chi_35;
                    break;
                case "-":
                    result = this.a_Chi_35 - this.b_Chi_35;
                    break;
                case "*":
                    result = this.a_Chi_35 * this.b_Chi_35;
                    break;
                case "/":
                    result = this.a_Chi_35 / this.b_Chi_35;
                    break;
            }
            return result;
        }

    }
}
