namespace 逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符");
            #region 符号
            //逻辑与： &&
            //逻辑或：||
            //逻辑非：!
            #endregion

            #region 与非或
            bool luoJiYu = true && false;
            Console.WriteLine(luoJiYu);
            bool luoJiHuo = true || false;
            Console.WriteLine(luoJiHuo);
            bool luoJiFei = !true;
            Console.WriteLine(luoJiFei);
            #endregion

            #region 短路 
            //左侧满足条件右边就不重要
            int i = 1;
            bool result = i > 0 || ++i > 2;
            Console.WriteLine(result);
            Console.WriteLine(i);
            result = i > 0 && ++i > 2;
            Console.WriteLine(i);
            #endregion



        }
    }
}
