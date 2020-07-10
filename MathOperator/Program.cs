using System;
using System.Collections.Generic;

//Write different methods that use each math operator, but allows you to plug in different integers. 
//Calling the different methods would look like: 

//    Sum(2,4) would return 6
//	Multiply(10,2) would return 20
//Change the functions to use the params keyword to support a range of arguments.
//Sum(2,4) would return 6
//Sum(2,4,6) would return 12.
//Sum(1,1,1,1,1) would return 5. 

//This way we could plug in multiple different values, and the method we write will still calculate it correctly, we could add, subtract, etc - as many values as we want

namespace MathOperator
{

    class Program
    {

        public static int Sum(int num1, int num2)
        {
            var sumAnswer = num1 + num2;
            return sumAnswer;
        }

        public static int Multiply(int num1, int num2)
        {
            var multAnswer = num1 * num2;
            return multAnswer;
        }

        public static int Divide(int num1, int num2)
        {
            var divAnswer = num1 / num2;
            return divAnswer;
        }
        public static int Subtract(int num1, int num2)
        {
            var subAnswer = num1 - num2;
            return subAnswer;
            
        }


    static void Main(string[] args)
    {

         var pocketDollars = Sum(100, 25);
         Console.WriteLine(pocketDollars);

            var allStars = Multiply(100, 25);
            Console.WriteLine(allStars);

            var lilDiv = Divide(100, 25);
            Console.WriteLine(lilDiv);

            var lilSub = Subtract(100, 25);
            Console.WriteLine(lilSub);
    }


}
}


