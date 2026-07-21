using System;
using System.Runtime.CompilerServices;

namespace 算数运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("算数运算符");
            //int a2 = 2;
            //Console.WriteLine(a2++);
            //Console.WriteLine(++a2);

            #region 作业1
            int Age = 18;
            Console.WriteLine(Age + 10);
            #endregion
            Console.WriteLine("*****************");
            #region 作业2
            int r = 5;
            float pi = 3.1415926f;
            Console.WriteLine(r*r*pi);
            Console.WriteLine(2*r*pi);
            #endregion
            Console.WriteLine("*****************");
            #region 作业3
            int tShirtsPrice = 258;
            int pantsPrice = 720;
            Console.WriteLine(2 * tShirtsPrice + 3 * pantsPrice);
            int p = 2 * tShirtsPrice + 3 * pantsPrice;
            Console.WriteLine(p * 0.38);
            #endregion
            Console.WriteLine("*****************");
            #region 作业4\
            //number1=31 number2=30 number3=42
            int a = 10, b = 20;
            int number1 = ++a + b;
            a = 10;
            b = 20;
            int number2 = a + b++;
            a = 10;
            b = 20;
            int number3 = a++ + ++b + a++;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            #endregion
            Console.WriteLine("*****************");
            #region 作业5
            //法1
            int a5 = 99, b5 = 87;
            int t = a5;
            a5 = b5;
            b5 = t;
            Console.WriteLine(a5);
            Console.WriteLine(b5);
            //法2
            a5 = 99;
            b5 = 87;
            a5 = a5+ b5;
            b5 = a5 - b5;
            a5 = a5 - b5;
            Console.WriteLine(a5);
            Console.WriteLine(b5);
            #endregion
            Console.WriteLine("*****************");
            #region 作业6
            int s = 987652;
            int day = s / (60 * 60 * 24);
            int hour = (s % (60 * 60 * 24)) / (60 * 60);
            int min = ((s % (60 * 60 * 24)) % (60 * 60)) / 60;
            int sec =((s % (60 * 60 * 24)) % (60 * 60)) % 60;
            Console.WriteLine("987652秒是" + day + "天" + hour + "小时" + min + "分" + sec + "秒");
            #endregion



        }

    }

}
