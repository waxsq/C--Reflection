using System;
using System.Reflection;
using 反射.GetInstance;

namespace 反射
{
    class Program
    {
        static void Main(string[] args)
        {
            Instance instance = new Instance();
            //测试无参
            //instance.Test();
            //测试有参
            //instance.Test1();
            //测试私有构建函数
            //instance.Test2();
            //通过反射调用泛型构造方法
            //instance.Test3();
            //通过反射调用方法
            instance.Test4();
            //通过反射调用私有方法
            instance.Test5();
            //通过反射调用反射方法
            instance.Test6();
            //通过反射调用泛型类的泛型方法
            instance.Test7();
            //通过反射操作实体类字段
            instance.Test8();
        }
    }
}
