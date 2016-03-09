using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_5_static
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosen_exersise = -1;

            while (chosen_exersise != 0)
            {
                Console.WriteLine("\tISD Course. Task 4. Homework by Fedor Voloshyn.\n");
                Console.WriteLine("Enter number of exercise or '0' to exit: ");
                chosen_exersise = ImputFilter.ImputIntNumber(Console.ReadLine());
                Console.Clear();

                switch (chosen_exersise)
                {
                    case 0: Console.WriteLine("Have a nice day!");
                        break;
                    case 1: ExerciseOne();
                        break;
                    case 2: ExerciseTwo();
                        break;
                    case 3: ExerciseThree();
                        break;
                    case 4: ExerciseFour();
                        break;
                    default: Console.WriteLine("Looks like you entered wrong number! Try again ;)");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void ExerciseOne()
        {
            Console.WriteLine("Enter A: ");
            double a = ImputFilter.ImputDoubleNumber(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            double b = ImputFilter.ImputDoubleNumber(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, Calculator.Add(a, b));
            Console.WriteLine("{0} - {1} = {2}", a, b, Calculator.Minus(a, b));
            Console.WriteLine("{0} / {1} = {2}", a, b, Calculator.Devide(a, b));
            Console.WriteLine("{0} * {1} = {2}", a, b, Calculator.Multiply(a, b));
        }
        public static void ExerciseTwo()
        {
            Random rand = new Random();
            int[] mas = new int[5];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-100, 101);
            }
            Console.WriteLine("\n=====Unsorted array=====");
            foreach(int elem in mas)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("\n=====Sorted array=====");
            mas.SortArray();
            foreach (int elem in mas)
            {
                Console.WriteLine(elem);
            }
        }
        public static void ExerciseThree()
        {
            Random rand = new Random();
            int[] mas = new int[5];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-100, 101);
            }

            Console.WriteLine("\n=====Unsorted array=====");
            foreach (int elem in mas)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("\n=====Sorted array=====");
            mas.SortArray(false);
            foreach (int elem in mas)
            {
                Console.WriteLine(elem);
            }
        }
        public static void ExerciseFour()
        {
            Console.WriteLine("Enter main string: ");
            string mainString = Console.ReadLine();
            Console.WriteLine("Enter substring: ");
            string subString = Console.ReadLine();
            int index = mainString.IndexOf_My(subString);
            Console.WriteLine("Index: {0}", index);
        }
    }
}
