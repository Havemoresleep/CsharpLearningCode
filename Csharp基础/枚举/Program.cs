namespace 枚举
{
    //枚举名称由E或E_开头
    //1.枚举申明在namespace当中(常用)
    //2.申明在class语句块中 struct语句块中
    //3.枚举不能在函数语句块中

    enum E_MonsterType
    {
        Normal,//0

        Boss,//1
    }

    enum E_PlayerType
    {
        Main,//0
        Other,//1
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            E_PlayerType playerType = E_PlayerType.Main;
            E_MonsterType monsterType= E_MonsterType.Normal;
            switch (monsterType)
            {
                case E_MonsterType.Normal:
                    Console.WriteLine("普通怪物");
                    break;
                case E_MonsterType.Boss:
                    break;
                default:
                    break;
            }
            #region 枚举的类型转换
            // 1.枚举和int互相转换
            
            int i = (int)playerType;
            Console.WriteLine(i);

            // 2.枚举和string互相转换
            string str = playerType.ToString();
            Console.WriteLine(str);

            #endregion

        }
    }
}
