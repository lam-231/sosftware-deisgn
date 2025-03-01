using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class USD : Money
    {
        public USD(int wholePart, int coin) : base(wholePart, coin) { }
    }
    public class EUR : Money
    {
        public EUR(int wholePart, int coin) : base(wholePart, coin) { }
    }
    public class UAH : Money
    {
        public UAH(int wholePart, int coin) : base(wholePart, coin) { }
    }

}
