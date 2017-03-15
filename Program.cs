using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_.NET_PracticeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create vector1...");
            Vector vector1 = new Vector(new int[] { 30,40,50,60,70,80});
            Console.WriteLine("Output vector1: " + vector1.ToString());
            Console.WriteLine("Element at index=3 in vector1: " + vector1[3]) ;
            Console.WriteLine("Create vector2...");
            Vector vector2 = new Vector(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3, 8);
            Console.WriteLine("Output vector2: " + vector2.ToString());
            Console.WriteLine("Adding vector2 to vector1...");
            vector1.AddVector(vector2);
            Console.WriteLine("Output vector1: " + vector1.ToString());

            Console.WriteLine("Create vector3...");
            Vector vector3 = new Vector(new int[] {5,5,5,5,5,5 });
            Console.WriteLine("Output vector3: " + vector3.ToString());
            Console.WriteLine("Subtracting vector3 from vector1...  vector1 = vector1 - vector3");
            vector1.SubtractVector(vector3);
            Console.WriteLine("Output vector1: " + vector1.ToString());
            
            double coefficient = 5;
            Console.WriteLine("Multipleing vector3 by coeff = " + coefficient);
            vector3.MultiplyByCoefficient(coefficient);
            Console.WriteLine("Output vector3: " + vector3.ToString());

            Console.WriteLine("Compare vector1 and vector2... Is there equals? " + vector1.CompareWithVectors(vector2));
           

           
            Console.Read();
        }
    }
}
