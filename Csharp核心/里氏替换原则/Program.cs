using System.Net.Http.Headers;

namespace 里氏替换原则
{
    class GameObject 
    { 
    
    }

    class Player : GameObject 
    {
        public void PlayerAtk() 
        {
            Console.WriteLine("玩家攻击");
        }
    }
    class Monster : GameObject 
    {
        public void MonsterAtk()
        {
            Console.WriteLine("怪物攻击");
        }
    }

    class Boss : GameObject 
    {
        public void BossAtk()
        {
            Console.WriteLine("Boss攻击");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            //里氏替换原则 用父类容器 装载子类对象
            GameObject player = new Player();
            GameObject monster = new Monster();
            GameObject boss = new Boss();

            GameObject[] objects = new GameObject[] { new Player(), new Monster(), new Boss() };

            if (player is Player)
            {
                //Player p = player as Player;
                //p.PlayerAtk();

                (player as Player).PlayerAtk();
            }

            


        }
    }
}
