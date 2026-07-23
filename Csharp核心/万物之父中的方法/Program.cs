namespace 万物之父中的方法
{
    class Test 
    {
        public int i = 1;
        public Test2 t2 = new Test2();

        public Test Clone() 
        { 
            return MemberwiseClone() as Test;
        }

        public override string ToString()
        {
            return "原神牛逼";
        }
    }

    class Test2
    {
        public int i = 2;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父中的方法");

            #region object中的静态方法
            //静态方法Equals
            Console.WriteLine(Object.Equals(1, 1));
            Test t = new Test();
            Test t2 = t;
            Console.WriteLine(Object.Equals(t, t2)); //内存地址不相同

            //静态方法ReflectionEquals
            //比较两个对象是否是相同的引用，主要是用来比较引用类型的对象
            //值类型对象返回值始终是False
            Console.WriteLine(Object.ReferenceEquals(t, t2));
            Console.WriteLine(Object.ReferenceEquals(1, 1));
            #endregion

            #region object中的成员方法
            //普通方法GetType
            Test T = new Test();
            Type type = T.GetType();
            //普通方法MemberwiseClone
            //改方法用于获取对象的浅拷贝对象
            //但是新对象中的引用变量会和老对象中一致
            Test T2 = T.Clone();
            Console.WriteLine("克隆对象后");
            Console.WriteLine("T.i: " + T.i);
            Console.WriteLine("T.t2.i: " + T.t2.i);
            Console.WriteLine("T2.i: " + T2.i);
            Console.WriteLine("T2.t2.i: " + T2.t2.i);

            T2.i = 20;
            T2.t2.i = 21;
            Console.WriteLine("改变克隆体信息后");
            Console.WriteLine("T.i: " + T.i);
            Console.WriteLine("T.t2.i: " + T.t2.i);
            Console.WriteLine("T2.i: " + T2.i);
            Console.WriteLine("T2.t2.i: " + T2.t2.i);
            #endregion

            #region object中的虚方法
            //虚方法Equals
            //可以重写Equals方法来实现自定义的比较逻辑

            //虚方法GetHashCode
            //该方法是用于获取对象的哈希码，通常用于哈希表等数据结构中

            //虚方法ToString
            //该方法用于获取对象的字符串表示

            
            Console.WriteLine(t);//默认使用ToString()方法
            #endregion



        }
    }
}
