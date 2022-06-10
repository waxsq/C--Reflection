using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IA;

namespace CLL
{
    public class C : A
    {

        public int Age { get; set; }
        public string Name { get; set; }

        public C()
        {
            Console.WriteLine("无参构造函数");
        }

        public C(int age)
        {
            Age = age;
            Console.WriteLine("有一个参数构造函数");
        }

        public C(int age, string name)
        {
            Age = age;
            Name = name;
            Console.WriteLine($"有两个参数构造函数{Age}和{Name}");
        }

        public void Say()
        {
            Console.WriteLine("C再跑");
        }
    }
}
