namespace 使用和存储上的区别
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            int a = 0;
            int b = a;
            int[] arr2 = arr;
            Console.WriteLine("a={0},b={1}",a,b);
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            b = 999;
            arr2[0] = 999;//堆空间直接改
            Console.WriteLine("a={0},b={1}", a, b);//值储存在栈空间
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            arr2 = new int [] { 1, 2,3, 4 };//新建
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);




        }
    }
}
