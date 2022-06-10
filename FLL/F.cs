using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLL
{
    /// <summary>
    /// 包含泛型方法
    /// </summary>
    public class F
    {
        public void Test<T>(T t)
        {
            Console.WriteLine($"输出类型{t.GetType().Name}");
        }

    }
}
