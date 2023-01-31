using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Exercise_2_Add_Multiply
    {
        public static int Add(int num1, int num2)
        {
            int numSum = num1 + num2;
            Console.WriteLine(numSum);
            return numSum;
        }

        public static int Multiply(int num3, int num4)
        {
            int numProd = num3 * num4;
            Console.WriteLine(numProd);
            return numProd;
        }

        public static int AddAdvanced(params int[] ListNumbers)
        {
            int totalSum = 0;

            foreach (int i in ListNumbers)
            {
                totalSum += i;
            }
            Console.WriteLine(totalSum);
            return totalSum;
        }

        public static int MultiplyAdvanced(params int[] ListNumbers)
        {
            int totalProduct = 1;

            foreach (int i in ListNumbers)
            {
                totalProduct *= i;
            }
            Console.WriteLine(totalProduct);
            return totalProduct;
        }
    }
}
