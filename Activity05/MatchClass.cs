using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity05
{
    internal class MatchClass
    {
        String op;
        int firstValue,secondValue;
    
        public void setOperator(string op)
        {
            this.op = op;
        }
        public string  getOperator()
        {
            return this.op;
        }

        public void setFirstValue(int firstvalue)
        {
            this.firstValue = firstvalue;
        }
        public int getFirstValue()
        {
            return (this.firstValue);
        }

        public void setSecondValue(int Secondvalue)
        {
            this.secondValue = Secondvalue;
        }
        public int getSecondValue()
        {
            return (this.secondValue);
        }
    }
       
}
