using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Mark
    {
        public string Subject { set; get; }
        public int SMark { set; get; }
        
        public Mark(string s, int n)
        {
            Subject = s;
            if (n < 0 || n > 10)
                throw new ArgumentOutOfRangeException("SMark", "The mark must be not more than 10 and not less than 0");  
            else
                SMark = n;
        }
    }
}
