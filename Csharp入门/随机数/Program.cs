namespace 随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int i = r.Next(20);
            Console.WriteLine(i);
            int a = 10;
            a = a - i; 
            Console.WriteLine(a);
        }
    }
}
