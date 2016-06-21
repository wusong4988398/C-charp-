using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace chapter8
{
     [TestClass]
    public class Class1
    {
         /// <summary>
         /// 测试泛型的约束
         /// </summary>
         [TestMethod]
         public void Test01()
         {
             BaseClass b=new DerivedClass();
             b.MyFunc<int>(100);
             b.MyFunc<char>('A');
            // b.MyFunc<string>("hello");//出现编译错误
             //原因是string类型没有公共的无参构造函数，可见在子类中已经默认继承来父类的约束。
         }
         /// <summary>
         /// 测试泛型方法的重载
         /// </summary>
         public void Test02()
         {
             BaseClass b = new DerivedClass();
             b.MyFunc<int>(100);
             b.MyFunc<char>('A');
             b.MyFunc("100");
             // b.MyFunc<string>("hello");//出现编译错误
             
         }
    }


    class BaseClass
    {
        public virtual void MyFunc<T>(T t) where T:new()
        {
            Console.WriteLine("{0} in Base",t.ToString());
        }

        public void MyFunc(string t)
        {
            Console.WriteLine(t);
        }
    }
    class DerivedClass:BaseClass
    {
        public override void MyFunc<T>(T t)
        {
            Console.WriteLine("{0} in Derived",t.ToString());
            
        }
    }
}
