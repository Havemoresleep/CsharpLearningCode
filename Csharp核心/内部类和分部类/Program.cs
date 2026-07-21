using System.Reflection;

namespace 内部类和分部类
{
    #region 内部类
    class Person
    {
        public int age;
        public string name;
        public Body body;

        public class Body
        {
            Arm leftArm;
            Arm rightArm;
            class Arm
            {

            }

        }
    }
    #endregion

    #region 分部类
    partial class Student 
    {
        public bool sex;
        public string name;

        partial void Speak();
    }
    partial class Student 
    {
        public int number;

        partial void Speak()
        {
            throw new NotImplementedException();
        }
        public void Speak(string str) 
        { 
        
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("内部类和分部类");
            Person p = new Person();
            Person.Body body = new Person.Body();

            Student s = new Student();
            
        }
    }
}
