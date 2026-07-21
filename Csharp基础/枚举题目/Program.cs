namespace 枚举题目
{
    //enum E_QQStatus
    //{
    //    OnLine,
    //    Leave,
    //    Busy,
    //    Invisible,
    //}

    //enum E_Starbucks
    //{
    //    medium,
    //    large,
    //    super,

    //}

    enum E_Sex
    {
        male,
        female,
    }

    enum E_Occupation
    {
        Warrior,
        Hunter,
        Master,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("请输入QQ的在线状态（在线：0，离开：1，忙碌：2，隐身：3）");
            //    int status = int.Parse(Console.ReadLine());
            //    E_QQStatus qQStatus = (E_QQStatus)status;
            //    Console.WriteLine(qQStatus);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}

            //try
            //{
            //    Console.WriteLine("请输入咖啡类型(中杯:0 大杯:1，超大杯:2)");
            //    int starbucks = int.Parse(Console.ReadLine());
            //    E_Starbucks e_Starbucks = (E_Starbucks)starbucks;
            //    switch (e_Starbucks)
            //    {
            //        case E_Starbucks.medium:
            //            Console.WriteLine("你购买了中杯咖啡，花费35元");
            //            break;
            //        case E_Starbucks.large:
            //            Console.WriteLine("你购买了大杯咖啡，花费40元");
            //            break;
            //        case E_Starbucks.super:
            //            Console.WriteLine("你购买了超大杯咖啡，花费43元");
            //            break;
            //        default:
            //            Console.WriteLine("请输入正确的类型");
            //            break;
            //    }
            //}
            //catch
            //{

            //    Console.WriteLine("请输入数字");
            //}
            int atk = 0;
            int def = 0;
            string sextype = "";
            string str = "";
            string occupationType = "";
            try
            {
                Console.WriteLine("请输入性别(男:0,女:1)");
                int sex = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入职业(战士:0,猎人:1，法师:2)");
                int occupation = int.Parse(Console.ReadLine());
                E_Sex e_Sex = (E_Sex)sex;
                E_Occupation e_occupation = (E_Occupation)occupation;
                switch (e_Sex)
                {
                    case E_Sex.male:
                        atk = 50;
                        def = 100;
                        sextype = "男性";
                        break;
                    case E_Sex.female:
                        atk = 150;
                        def = 20;
                        sextype = "女性";
                        break;
                    default:
                        Console.WriteLine("请输入正确的类型");
                        break;
                }
                switch (e_occupation)
                {
                    case E_Occupation.Warrior:
                        atk += 20;
                        def += 100;
                        str = "冲锋";
                        occupationType = "战士";
                        break;
                    case E_Occupation.Hunter:
                        atk += 120;
                        def += 30;
                        str = "假死";
                        occupationType = "猎人";
                        break;
                    case E_Occupation.Master:
                        atk += 200;
                        def += 10;
                        str = "奥术冲击";
                        occupationType = "法师";
                        break;
                    default:
                        Console.WriteLine("请输入正确的类型");
                        break;
                }
                Console.WriteLine("你选择了“" + sextype + occupationType + "”，攻击力：" + atk + "，防御力：" + def + "，职业技能：" + str);

            }
            catch
            {

                Console.WriteLine("请输入正确的类型");
            }
        }
    }
}
