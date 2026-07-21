namespace 字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串拼接");

            string str = string.Format("迎面走来的{0}让{1}如此蠢蠢欲动,这种感觉{2}曾未有","你","我","我");
            Console.WriteLine(str);
            Console.WriteLine("迎面走来的{0}让{1}如此蠢蠢欲动,这种感觉{2}曾未有", "你", "我", "我");




        }
    }
}
