using System.Text;

namespace 面向对象相关StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder");

            StringBuilder str = new StringBuilder("123123123");
            Console.WriteLine(str);
            StringBuilder testStr = new StringBuilder("123123123",100); // 指定容量为 100
            #region 容量
            //stringBuilder 的容量是指它在不需要重新分配内存的情况下可以容纳的字符数。初始容量为 16 个字符，当超过这个容量时，StringBuilder 会自动增加容量。
            Console.WriteLine(str.Capacity); // 输出 16，表示当前容量为 16 个字符
            #endregion

            #region 增删查改替换
            //增
            str.Append("456"); // 在末尾追加字符串
            Console.WriteLine(str);
            Console.WriteLine(str.Capacity);
            
            str.AppendFormat("{0}{1}",100,999);
            Console.WriteLine(str);
            Console.WriteLine(str.Capacity);// 输出 32，容量增加到 32 个字符
            //插入
            str.Insert(3, "插入的内容"); // 在索引 3 处插入字符串
            Console.WriteLine(str);
            //删
            str.Remove(3, 5); // 从索引 3 开始移除 5 个字符
            Console.WriteLine(str);
            //查
            Console.WriteLine(str[0]); // 获取索引 0 处的字符
            //改
            str[0] = 'X'; // 将索引 0 处的字符改为 'X'
            Console.WriteLine(str);
            //替换
            str.Replace("123", "ABC"); // 将所有的 "123" 替换
            Console.WriteLine(str);
            //清空
            str.Clear(); // 清空 StringBuilder 的内容
            Console.WriteLine(str);
            Console.WriteLine("================");

            //重新赋值
            str.Clear();
            str.Append("123123");
            //比较
            if (str.Equals("123123"))
            {
                Console.WriteLine("字符串相等");
            }
            #endregion


        }
    }
}
