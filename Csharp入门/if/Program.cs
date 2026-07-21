using System.Security.AccessControl;

namespace if语句;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("你喜欢的说唱歌手是谁");
        string str =Console.ReadLine();
        if (str != null && str.Equals("Asen", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("阿里嘎多摆锤子");

        }
        else
        {
            Console.WriteLine("感觉不如kiZz");
        }





    }
}
