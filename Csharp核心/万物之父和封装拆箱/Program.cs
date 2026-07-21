using System.Net.Http.Headers;

namespace 万物之父和封装拆箱
{
    class Father
    {
    
    }
    class Son : Father 
    {
        public void Speak() 
        {
        
        }
    }
    #region 万物之父

    // 1. 可以利用里氏替换原则，用object容器装所有对象
    // 2. 可以用来表示不确定类型，作为函数参数类型
    #endregion

    
    


    class Program
    {
        static void Main(string[] args)
        {
            Father f = new Son();
            if (f is Son) 
            {
                (f as Son).Speak();
            }

            //引用类型
            object o = new Son();
            //用is和as
            if (o is Son) 
            {
                (o as Son).Speak();
            }

            //值类型
            object o2 = 1f;
            //用强转
            float fl = (float)o2;

            //string
            object str = "123123";
            string str2 = str as string;
            string str3 = str.ToString();

            //数组
            object arr = new int[10];
            int[] ar = arr as int[];

            #region 封装拆箱
            //装箱：用object存值类型
            //拆箱：把object转为值类型

            //装箱
            //把值类型用引用类型储存
            //栈内存会迁移到堆内存中

            //拆箱
            //把引用类型储存的值类型取出来
            //堆内存会迁移到栈内存
            #endregion

            object v = 3;
            int intValue = (int)v;

            TestFun(1, 2, 3, 4f, 34.5, "12345", new Son());
        }


        static void TestFun(params object[] array) 
        { 
            //好处：不确定类型时可以方便参数的储存和传递
            //坏处：增加性能消耗
        }
    }
}
