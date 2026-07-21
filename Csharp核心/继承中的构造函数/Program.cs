namespace 继承中的构造函数
{
    class GameObject 
    {
        public GameObject() 
        {
            Console.WriteLine("GameObject的构造函数");
        }
    }

    class Player : GameObject 
    {
        public Player()
        { 
            Console.WriteLine("Player的构造函数");
        }
    }

    class MainPlayer : Player 
    {
        public MainPlayer() 
        {
            Console.WriteLine("MainPlayer的构造函数");
        }
    }

    class Father 
    {
        //public Father()
        //{

        //}

        public Father(int i) 
        {
            Console.WriteLine("父类的构造函数");
        }
    }

    class Son : Father 
    {
        public Son(int i) : base(i)
        { 
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MainPlayer mp = new MainPlayer();

        }
    }
}
