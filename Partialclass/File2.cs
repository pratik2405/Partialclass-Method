using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    public partial class calculator
    {
        public int Sub(int x,int y)
        {
            //Divide(x,y);
            return x + y;
        }

        public void Invoke(int x,int y)
        {
            Divide(x,y);
        }

        partial void Divide(int x, int y)
        {
            Console.WriteLine(x/y);
        }
    }
}
