namespace 密封方法
{
    abstract class Animal 
    {
        public string name;

        public abstract void Eat();

        public virtual void Speak()
        {
            Console.WriteLine("叫");
        }

    }

    class Person : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("吃饭");
        }
        public override void Speak()
        {
            Console.WriteLine("人叫");
        }
    }

    class WhitePerson : Person
    {
        public sealed override void Eat()
        {
            base.Eat();
        }
        public sealed override void Speak()
        {
            base.Speak();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

}
