using System;

namespace Method
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program.even(30);
            Program p = new Program();
            int sum = p.add(20, 20);
            Console.WriteLine("sum: " + sum);
        }

        public int add(int fn,int sn)
        {
            return fn + sn;
        }
        public static void even(int target)
        {
            int start = 0;
             
            while(start<=target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
