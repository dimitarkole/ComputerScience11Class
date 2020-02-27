using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public class RPN
    {
        public RPN(string expression)
        {
            this.Expression = expression;
        }

        public string Expression { get; set; }
    }
}
