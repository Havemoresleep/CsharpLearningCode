using System.Net.Http.Headers;

namespace 变长参数和参数默认值
{
    internal class Program
    {
        #region 变长参数
        static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //函数参数中只能最多出现一个params关键字 并且一定是在最后一组参数 前面可以有n个其他参数
        static void Eat(string name, ref int a, params string[] things)

        {
            a = 0;
        }
        #endregion
        static int[] SumAndAvg(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            int avg = sum / arr.Length;
            return [sum, avg];
        }

        static int[] OddAndEvenSum(params int[] arr) 
        {
            int oddSum = 0, evenSum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] % 2 == 0) 
                {
                    evenSum += arr[i];
                }
                else
                {
                    oddSum += arr[i];
                }
                
            }
            return [oddSum, evenSum];
        }
        #region 参数默认值
        static void Speak(string str = "我无话可说")//可选参数
        {
            Console.WriteLine(str);
        }
        //如果要混用 可选参数 必须写在 普通参数的后面

        
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            Speak();
            Speak("what can i say");
            int[] arr = SumAndAvg(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.WriteLine("{0},{1}", arr[0], arr[1]);
            int[] arr2 = OddAndEvenSum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Console.WriteLine("{0},{1}", arr2[0], arr2[1]);
        }
    }
}
