namespace 选择排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 7, 1, 5, 6, 2, 4, 3, 9 };
            
            for (int j = 0; j < arr.Length; j++) 
            {
                int index = 0;
                for (int i = 1; i < arr.Length-j; i++)
                {
                    if (arr[index] < arr[i])
                    {
                        index = i;
                    }

                }
                if (index != arr.Length - 1 - j)
                {
                    int temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - j];
                    arr[arr.Length - 1 - j] = temp;
                }

            }
            for (int i = 0; i < arr.Length; i++)
            { 
                Console.Write(arr[i]+" ");
            }
            
        }
    }
}
