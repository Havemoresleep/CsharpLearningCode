namespace yichangbuhuo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //int i = int.Parse(str);
            try
            {
                string str = Console.ReadLine();
                int i = int.Parse(str);
                Console.WriteLine(i);



            }
            catch
            {
                Console.WriteLine("请输入合法数字");
            
            }
            finally
            {
                Console.WriteLine("滚");
            }





        }
    }
}
