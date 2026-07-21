using System;

namespace cmdtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 25);
            Console.CursorVisible = false;
            Console.SetCursorPosition(12, 5);
            Console.WriteLine("牛润泽拯救吴健扬小游戏");
            Console.SetCursorPosition(18, 6);
            Console.WriteLine("开始游戏");
            Console.SetCursorPosition(18, 7);
            Console.WriteLine("退出游戏");
            bool st = false;
            bool flag = false;
            while (st == false)

            {
                char choose = Console.ReadKey(true).KeyChar;
                switch (choose)
                {
                    case 'W':
                    case 'w':
                        Console.SetCursorPosition(18, 6);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("开始游戏");
                        Console.SetCursorPosition(18, 7);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("退出游戏");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            st = true;
                            flag = true;
                        }
                        break;
                    case 'S':
                    case 's':
                        Console.SetCursorPosition(18, 7);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("退出游戏");
                        Console.SetCursorPosition(18, 6);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("开始游戏");
                        ConsoleKeyInfo keyInfo1 = Console.ReadKey(true);
                        if (keyInfo1.Key == ConsoleKey.Enter)
                        {
                            st = true;
                            break;
                        }
                        break;



                }
            }

            if (flag == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

                for (int i = 1; i < 24; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("■                                              ■");
                }
                int x = 24, y = 12;
                Console.SetCursorPosition(0, 19);
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.SetCursorPosition(24, 16);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("●");
                Console.SetCursorPosition(x, y);
                Console.WriteLine("■");
                int circleX = 24, circleY = 16;
                Console.SetCursorPosition(2, 20);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("按j键攻击");
                int niuHp = 50, guaiHp = 50;
                Console.SetCursorPosition(2, 21);
                Console.WriteLine("牛润泽血量:"+niuHp);
                Console.SetCursorPosition(2, 22);
                Console.WriteLine("怪兽血量:"+guaiHp);
                

                while (niuHp>0 && guaiHp >0 )
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("■");
                    char c = Console.ReadKey(true).KeyChar;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("  ");
                    int oldx = x; int oldy = y;
                    bool isNearObstacle = false;
                    if (Math.Abs(x - circleX) <= 2 && Math.Abs(y - circleY) <= 1)
                    {
                        isNearObstacle = true;
                    }

                    switch (c)
                    {
                        case 'W':
                        case 'w':
                            y -= 1;
                            if (y < 1)
                            {
                                y = 1;
                            }
                            if (x == circleX && y == circleY)
                            {
                                x = oldx;
                                y = oldy;
                            }

                            break;
                        case 'A':
                        case 'a':
                            x -= 2;
                            if (x < 2)
                            {
                                x = 2;
                            }
                            if (x == circleX && y == circleY)
                            {
                                x = oldx;
                                y = oldy;
                            }

                            break;
                        case 'S':
                        case 's':
                            y += 1;
                            if (y > 18)
                            {
                                y = 18;
                            }
                            if (x == circleX && y == circleY)
                            {
                                x = oldx;
                                y = oldy;
                            }

                            break;
                        case 'D':
                        case 'd':
                            x += 2;
                            if (x > 46)
                            {
                                x = 46;
                            }
                            if (x == circleX && y == circleY)
                            {
                                x = oldx;
                                y = oldy;
                            }
                            break;
                        case 'J':
                        case 'j':
                            if (isNearObstacle)
                            {
                                Console.SetCursorPosition(2, 20);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("牛润泽发动攻击！为了拯救吴健扬！");
                                Random damage = new Random();
                                int i = damage.Next(5,15);
                                guaiHp -= i;
                                Console.SetCursorPosition(2, 22);
                                Console.WriteLine("怪兽血量:" + guaiHp +" ");
                                if (guaiHp<=0)
                                {
                                    break;
                                }
                                System.Threading.Thread.Sleep(1000);
                                Console.SetCursorPosition(2, 20);
                                Console.WriteLine("怪物发动攻击！牛润泽受到伤害！");
                                i = damage.Next(7, 17);
                                niuHp -= i;
                                Console.SetCursorPosition(2, 21);
                                Console.WriteLine("牛润泽血量:"+niuHp + " ");
                                if (niuHp <= 0)
                                {
                                    break;
                                }
                                System.Threading.Thread.Sleep(1000);
                                Console.SetCursorPosition(2, 20);
                                Console.WriteLine("按j键攻击                                     ");
                            }
                            else
                            {
                                Console.SetCursorPosition(2, 20);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("距离太远，无法攻击！");
                                System.Threading.Thread.Sleep(500);
                                Console.SetCursorPosition(2, 20);
                                Console.WriteLine("按j键攻击                   ");


                            }
                            break;
                    }

                }   Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                if (guaiHp <= 0)
                {
                    
                    Console.WriteLine("YOU WIN!!成功拯救出了吴健扬");

                }
                else
                {
                    Console.WriteLine("可惜了，你也被怪物抓走了");
                }
            }
            
        }
    }
}