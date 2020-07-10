using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
        //implement these methods. the throw methods are place holders.
        //make a note of the relationship between bool, if, and return
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else return false;
        }

        public double Subtract(double num1, double num2)
        {
            double subAnswer = num1 - num2;
            return subAnswer;
        }

        public int Add(int num1, int num2)
        {
            int addAnswer = num1 + num2;
            return addAnswer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else return number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            long multAnswer = factor1 * factor2;
            return multAnswer;
        }

        public string GetGreeting(string nameOfPerson)
        {
            
            return nameOfPerson;
            
        }

        public string GetHey()
        {
            return GetHey();
        }
       
            

              
        }
    }

