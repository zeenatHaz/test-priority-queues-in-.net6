using System.Collections.Generic;



namespace PriorityQueue
{
    public class Program
    {
        public static void Main(String[] args)
        {
            PriorityQueue<string, priorityLevel> pQueue = new PriorityQueue<string, priorityLevel>();

            PriorityQueue<string, priorityLevel> superheroes
                = new(new customComparer());
            pQueue.Enqueue("p1", priorityLevel.b);
            pQueue.Enqueue("p2", priorityLevel.a);
            pQueue.Enqueue("p3", priorityLevel.c);
            pQueue.Enqueue("p4", priorityLevel.f);
            pQueue.Enqueue("p5", priorityLevel.a);

            //try to deqeue.
            while (pQueue.TryDequeue(out string ele,out priorityLevel p))
            {
                Console.WriteLine("process removed is: " + ele + " priority is :"+ p);
            }




        }
    }
    public class customComparer : IComparer<priorityLevel>
    {
        // highest to lowest
        public int Compare(priorityLevel x, priorityLevel y) => y - x;
    }

    public  enum priorityLevel
    {
        a,b,c,d,e,f,g
    }
}
