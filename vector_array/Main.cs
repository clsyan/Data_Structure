using System;

namespace vector_array
{
    class Program{
        public static void Main(string[] args)
        {
            Vector vetor = new Vector(5);
            vetor.insertAtRank(0, 8);
            vetor.insertAtRank(0, 2);
            //vetor.removeAtRank(0);
            
            Console.WriteLine(vetor.elementAtRank(0));
            Console.WriteLine(vetor.elementAtRank(1));
            //Console.WriteLine(vetor.elementAtRank(7));


        }
    }
}