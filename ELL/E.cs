using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELL
{
    public class E<T, I>
    {
        public E()
        {
            Console.WriteLine($"{typeof(T)}和{typeof(I)}");
        }

        public void Test<W,K>(W t,K i)
        {
            Console.WriteLine($"{t.GetType().Name}+{i.GetType().Name}");
        }


    }


}
