namespace 递归函数
{
    internal class Program
    {
        static void Fun(int n)
        {
            if (n > 10){ return; }
            Console.WriteLine(n);
            n++;
            Fun(n);
        }
        static int Factorial(int n) 
        {
            if (n == 0) { return 1; }
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            Fun(0);
            Console.WriteLine("xxxxxxxxxxxxxx");
            Console.WriteLine(Factorial(5));
            
        }
    }
}
