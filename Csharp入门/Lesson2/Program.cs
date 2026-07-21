using System.Data;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量");
            #region MyRegion 1
            int i = 0;
            Console.WriteLine("i的值是" + i);
            byte bt = 25;
            float f = 3.1415926535897932384626f;
            Console.WriteLine(f);
            bool flag = true;
            char c = '1';//char 只能装下一个值
            string str = "富国说是区";
            Console.WriteLine(str);
            str = "这是真的";
            Console.WriteLine(str);


            #endregion

            #region MyRegion 2
            int a1 = 1, a2 = 2, a3 = 3;
            Console.WriteLine(a1 - a2 * a3);





            #endregion


        }
    }
}
