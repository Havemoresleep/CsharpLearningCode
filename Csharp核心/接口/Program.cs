namespace 接口
{
    #region 接口的概念
    //接口是行为的抽象规范
    //也是一种自定义类型
    //关键字： interface

    //接口申明的规范
    //1. 不包含成员变量
    //2. 只包含方法、属性、事件、索引器的申明
    //3. 成员不能被实现
    //4. 成员默认是public的，不能使用访问修饰符
    //5. 接口不能继承类，但是可以继承接口

    //接口的使用规范
    //1.类可以继承多个接口
    //2.类继承接口必须实现接口的所有成员

    //特点：
    //1.接口不能被实例化
    //2.接口可以被继承
    //3.它和类的申明相似

    #endregion

    interface IFly //命名规范 帕斯卡前面加个I
    {
        void Fly();

        string Name 
        { 
            get;
            set;
        }

        int this[int idex] 
        {
            get;
            set;
        }

        event Action doSomething;
    }

    class Animal
    {
        
    }

    class Person : Animal, IFly
    {
        public void Fly()
        { 
        
        }

        public string Name 
        {
            get;
            set;
        }

        public int this[int index]
        {
            get 
            {
                return 0;
            }
            set 
            { 
            
            }
        }

        public event Action doSomething;
    }

    interface IWalk 
    { 
        void Walk();
    }

    interface IMove : IFly, IWalk
    {
    }

    class Test : IMove
    {
        public void Fly()
        {
        }

        public void Walk()
        {
        }

        // 实现 IFly.Name
        public string Name { get; set; }

        // 实现 IFly 的索引器
        public int this[int index]
        {
            get { return 0; }
            set { }
        }

        // 实现 IFly 的事件
        public event Action doSomething;
    }

    #region 显示实现接口
    interface IAtk 
    {
        void Atk();
    }

    interface ISuperAtkP 
    { 
        void Atk();
    }

    class Player:IAtk, ISuperAtkP
    {
        //显示实现接口 就是用接口名.方法名的方式来实现接口的方法
        void IAtk.Atk()
        {
            Console.WriteLine("普通攻击");
        }
        void ISuperAtkP.Atk()
        {
            Console.WriteLine("大招");
        }
    }
    #endregion
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("接口");
            IFly f = new Person();

            IMove im = new Test();
            IFly ifly = new Test();
            IWalk iw = new Test();

            Player p = new Player();
            (p as IAtk).Atk();
            (p as ISuperAtkP).Atk();
        }
    }
}
