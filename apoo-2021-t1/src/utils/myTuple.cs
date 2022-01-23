using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apoo_2021_t1.src.utils
{
    class myTuple<T1, T2>
    {
        public myTuple(T1 t1, T2 t2)
        {
            Item1 = t1;
            Item2 = t2;
        }
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
    }
}
