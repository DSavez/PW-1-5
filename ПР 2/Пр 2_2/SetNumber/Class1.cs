using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNumber
{
    class Seth
    {
        private int n = 0;
        private int number;
        public Seth(int number)
        {
            this.number = number;
        }
       public bool SetNumber(int number)     
        {
            if (number == n + 1)
            {
                n++;
                return true;
            }
            else { number = 0; return false; }
        }
    }
}
