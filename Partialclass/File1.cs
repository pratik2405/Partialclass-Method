using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    public partial class calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        partial void Divide(int x, int y);
    }
}
