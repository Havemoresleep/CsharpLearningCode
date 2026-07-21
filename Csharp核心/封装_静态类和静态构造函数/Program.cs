namespace 封装_静态类和静态构造函数
{
    static class StaticClass 
    { 
        public static int testInt = 100;
        public static int testInt2 = 100;

        static StaticClass() 
        { 
            Console.WriteLine("只会自动调用一次");
        }
        
    
    }

    class Test 
    {
        public static int testInt = 200;
        static Test() 
        {
            Console.WriteLine("静态构造");
        }
        public Test() 
        {
            Console.WriteLine("普通构造");
        
        }
    }
    static class TestStatic 
    {
        public static int testIndex = 0;

        public static void TestFun() 
        { 
        
        }

        public static int TestIndex 
        {
            get;
            set;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StaticClass.testInt);
            Console.WriteLine(StaticClass.testInt);
            Console.WriteLine(StaticClass.testInt2);

            Test t = new Test();
            Test t2 = new Test();
        }
    }
}
