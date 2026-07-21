namespace 静态成员
{
    class Test
    {
        public const float G = 9.8f;//必须初始化 且不能修改

        public static float PI = 3.1415926f;

        public int testInt = 100;

        public static float CalcCircle(float r)
        {
            #region 静态函数中不能使用非静态成员
            //成员变量只能将对象实例化出来后 才能点出来使用 不能无中生有
            //不能直接使用 非静态成员 否则会报错
            #endregion

            return (PI * r * r);
        }
        public void TestFun()
        {
            Console.WriteLine("123");
            #region 非静态函数可以使用静态成员
            Console.Write(PI);
            #endregion
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Test.PI);
            Console.WriteLine(Test.G);
            Console.WriteLine(Test.CalcCircle(2));

            Test t = new Test();
            Console.WriteLine(t.testInt);
            t.TestFun();
        }
    }
}
