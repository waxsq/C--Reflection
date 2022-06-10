using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BLL;



namespace 反射.GetInstance
{
    public class Instance
    {
        /// <summary>
        /// 通过反射获取实例(无参)
        /// </summary>
        public void Test()
        {


            //1、获取相对的DLL文件
            Assembly assembly = Assembly.LoadFrom("B.DLL");
            //2、通过全类名(命名空间.类名)来获取相对的类型
            Type type = assembly.GetType("BLL.B");

            //3、创建实例
            object v = Activator.CreateInstance(type);

            //类型转换,as转换类型不保存，但是会返回null类型
            B b = v as B;
            Console.Write(v is B);
        }


        /// <summary>
        /// 通过反射创建对象（有参）
        /// </summary>
        public void Test1()
        {
            //获取到dll文件
            Assembly assembly = Assembly.LoadFrom("C.dll");
            Type type = assembly.GetType("CLL.C");
            //获取到所有构造方法
            foreach (ConstructorInfo info in type.GetConstructors())
            {
                Console.WriteLine(info.Name);
                foreach (var  item in info.GetParameters())
                {
                    Console.WriteLine(item.ParameterType);
                }
            }

            //构建无参构建函数
            object v = Activator.CreateInstance(type);
            //构建有参构建函数
            object v1 = Activator.CreateInstance(type,1);
            //可以用Object类型的数组存放构造参数
            object v2 = Activator.CreateInstance(type, new Object[] {1,"张三" });
        }



        /// <summary>
        /// 通过反射调用私有构造方法创建实例
        /// </summary>
        public void Test2()
        {
            //获取到DLL文件
            Assembly assembly = Assembly.LoadFrom("DLL.dll");
            //获取类型
            Type type = assembly.GetType("DLL.D");
            //通过私有方法构建实例
            object v = Activator.CreateInstance(type, true);
        }


        /// <summary>
        /// 通过反射调用泛型构造方法
        /// </summary>
        public void Test3()
        {
            //获取到DLL文件
            Assembly assembly = Assembly.LoadFrom("ELL.Dll");
            //获取到类型,泛型在编译的时候需要写出泛型的数目，并且用 ` 接在后面
            Type type = assembly.GetType("ELL.E`2");
            //添加具体泛类的类型
            Type type1 = type.MakeGenericType(new Type[] { typeof(int), typeof(string) });
            //通过构建方法创建实例
            object v = Activator.CreateInstance(type1);

        }


        /// <summary>
        /// 通过反射调用方法
        /// </summary>
        public void Test4()
        {
            //1、获取相对的DLL文件
            Assembly assembly = Assembly.LoadFrom("B.DLL");
            //2、通过全类名(命名空间.类名)来获取相对的类型
            Type type = assembly.GetType("BLL.B");

            //3、创建实例
            object v = Activator.CreateInstance(type);

            //打印出来所有方法
            foreach (var item in type.GetMethods())
            {
                Console.WriteLine(item.Name);
                //查看有什么参数
                foreach (var paramter in item.GetParameters())
                {
                    Console.WriteLine(paramter.ParameterType);
                }
            }
            //获取方法
            MethodInfo methodInfo = type.GetMethod("Say");
            //调用方法
            methodInfo.Invoke(v,null);
        }
    }
}
