namespace 抽象类与抽象函数
{
    abstract class Thing 
    {
        public string name;


    }

    class water:Thing 
    { 
    
    }

    abstract class Fruits 
    {
        public string name;

        #region 抽象函数
        public abstract void Bad();
        //1.只能在抽象类中申明
        //2.不能是私有的
        //3.没有方法体

        #endregion

    }

    class Apple : Fruits 
    {
        //继承后必须实现 必须用override重写
        public override void Bad()
        {
            
        }
    }

    class SuperApple : Apple 
    { 
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽象类与抽象函数");

            //Thing t = new Thing(); 抽象类不能被实例化

            Thing t = new water(); //但是可以用里氏替换原则
        }
    }
}
