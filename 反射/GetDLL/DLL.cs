using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射.GetDLL
{
    public class DLL
    {
        public void Test()
        {
            //获取dll文件
            //方式一，获取B的dll文件,仅能通过文件名称获取
            Assembly assembly = Assembly.Load("B");
            //打印方法名
            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine(type.Name);
                //获取该类所拥有的方法
                foreach (var method in type.GetMethods())
                {
                    Console.WriteLine(method.Name);
                }
                Console.WriteLine("分割线--------------");
            }


            //方式二，通过文件绝对路径方式获取dll文件
            Assembly absoluteAssembly = Assembly.LoadFile("D:\\code\\VS\\code\\反射\\C\\bin\\Debug\\C.DLL");
            foreach (var type in absoluteAssembly.GetTypes())
            {
                Console.WriteLine(type.Name);
                //获取该类所拥有的方法
                foreach (var method in type.GetMethods())
                {
                    Console.WriteLine(method.Name);
                }
                Console.WriteLine("分割线--------------");
            }


            //方式三，既可以通过全限名(文件名.后缀)获取，也可以通过绝对路径获取
            Assembly fullAssembly = Assembly.LoadFrom("IA.DLL");
            foreach (var type in fullAssembly.GetTypes())
            {
                Console.WriteLine(type.Name);
                //获取该类所拥有的方法
                foreach (var method in type.GetMethods())
                {
                    Console.WriteLine(method.Name);
                }
                Console.WriteLine("分割线--------------");
            }
        }
         
    }
}
