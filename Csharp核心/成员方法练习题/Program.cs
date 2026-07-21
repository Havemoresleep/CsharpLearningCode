using System.Xml.Linq;

namespace 成员方法练习题
{
    internal class Program
    {
        class Person 
        {
            public void Speak(string str) 
            { 
                Console.WriteLine(str);
            }
            public bool IsWalk;
            public bool IsEat;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
