using System;

namespace vector_array
{
    class Program{
        public static void Main(string[] args)
        {
            Vector vetor = new Vector(5);
            vetor.insertAtRank(0, 8);
            Console.WriteLine(vetor.elementAtRank(0));
        }
    }
}