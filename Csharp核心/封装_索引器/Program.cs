namespace 封装_索引器
{
    class Person
    {
        private string name;
        private int age;
        private Person[] friends;

        private int[,] array;
        public int this[int i,int j] 
        {
            get 
            { 
                return array[i,j];
            }
        }

        public string this[string str]
        {
            get 
            {
                switch (str) 
                {
                    case "name":
                        return name;
                    case "age":
                        return age.ToString();

                }
                return "";
            }
        }
        public Person this[int index]
        {
            get 
            {
                if (friends == null || friends.Length - 1 <index) 
                {
                    return null;
                }

                return friends[index];
            }
            set 
            {
                if (friends == null)
                {
                    friends = new Person[] { value };
                }
                else if (index > friends.Length - 1) 
                {
                    friends[friends.Length-1]=value;
                }
                friends[index] = value;
            }
        }

    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("索引器");
            Person p= new Person();
            p[0] = new Person();
            Console.WriteLine(p[0]);

            p[0, 0] = 10;
        }
    }
}
