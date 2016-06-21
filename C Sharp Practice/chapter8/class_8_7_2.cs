using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace chapter8
{
    [TestClass]
  public  class Class872
    {
        /// <summary>
        /// 测试浅拷贝
        /// </summary>
         [TestMethod]
        public void Test02()
        {
            Student s1=new Student("wusong",22);
            //执行浅拷贝
            Student s2 = s1;
            s2.Age = 27;
            s1.ShowInfo();
        }
                /// <summary>
        /// 测试深拷贝
        /// </summary>
         [TestMethod]
        public void Test03()
        {
            Int32 i=100;
            Int32 j = i;
            j = 200;
            Console.WriteLine(i);
        }
    }
    }



    class Student
    {
        public string Name;
        public Int32 Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} age is {1}",Name,Age);
        }
    }
}
