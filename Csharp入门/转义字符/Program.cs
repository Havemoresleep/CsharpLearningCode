namespace 转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            #region MyRegion

	
            string str = "a s\"\n123132141\\";
            Console.WriteLine(str);
            str = @"你\t好";
            Console.WriteLine(str);
            str = "\a";
            Console.WriteLine(str);
            #endregion

            //大范围装小范围
            long l = 1;
            int i = 0;
            sbyte sb = 13;
            short s = 2;

            l = i;
            i = s;
            s = sb;
            Console.WriteLine(l);

            uint ui = 3;
            int i2 = 0;
            i2 = ui;
            Console.WriteLine(i2);




        }
    }
}
