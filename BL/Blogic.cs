using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydemirOto.DL;

namespace AydemirOto.BL
{
    internal class Blogic
    {
        public static bool Musteriekle(Musteri m )
        {
            int res = datalayer.Musteriekle(m);
            return (res > 0);
        }
    }
}
