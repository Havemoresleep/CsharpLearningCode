namespace 数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1;
            //int[] arr2 = new int[5];
            //int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] arr4 = new int[] { 1, 2, 3, 4};
            //int[] arr5 = {10,9,41,42156,521};
            //....................................................
            int[] array = { 1, 2, 3, 4, 5 };
            //1.数组的长度
            Console.WriteLine(array.Length);
            //2.数组元素
            Console.WriteLine(array[0]);//与python不同-1不是倒取
            //3.修改元素
            array[1] = 2;
            //4.遍历
            for (int i = 0; i < array.Length ; i++)
            {

            }
            //5.添加新元素
            //数组初始化后，不能直接添加（区别于python的append）
            int[] array2 = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i]=array[i];
            }
            array=array2;
            array[5] = 6;
            //6.删除元素
            //数组初始化后，不能直接删除
            //同上





        }
    }
}
