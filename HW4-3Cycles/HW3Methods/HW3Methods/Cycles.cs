using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Methods
{
    public static class HomeworkCycles
    {
        public static int SquaringNumber(int A, int B)
        {
            if (A < 0 && B < 0)
            {
                throw new Exception("");
            }
            int C = 1;
                      
                for (int i = 0; i < Math.Abs(B); i++)

                {
                    C = C * A;
                }
             
                return  C;
        }
    
    
    
        public static string OutputAllNumbers(int A)
        {
            string result = "";
            if (A <= 0)
            {
                throw new Exception("");
            }

            for (int i = 1; i <= 1000; i++)
            {
                if (i % A == 0)
                {
                    result=result+i+" ";
                    
                }
            }
           return result;
        }
    
    
    
        public static int FindTheNumberOfPositiveIntegers(int numberA)
        {
            int z = 0;
            for (int i = 1; i < Math.Sqrt(numberA); i++)
            {
                z = i;

            }
            return z;
        }
    
  
    
        public static int OutputTheLargestDivisor(int numberOne)
        {
            int maximumDivisor = 0;
            for (int i = 1; i < numberOne; i++)

            { 
                if (numberOne % i == 0)
                {

                    maximumDivisor = i;
                }  
            }
           return maximumDivisor;
        }
    
    
    
    
        public static int GetTheSumOfAllNumbersinaGroup(int numberOneA, int numberOneB)
        {
            int z = 0;

            if (numberOneA > numberOneB)
            {
                throw new Exception("");
            }

            if (numberOneA < numberOneB)
            {
                for (int i = numberOneA; i <= numberOneB; i++)
                {
                    if (i % 7 == 0)
                    {
                        z = z + i;
                    }
                }
            }
            else
            {
                for (int i = numberOneB; i < numberOneA; i++)
                {
                    if (i % 7 == 0)
                    {
                        z = z + i;

                    }
                }
            }
            return z;
        }
    
    
    
        public static int PrintTheNthNumberOfTheFibonacciSeries(int N)
        {
            int oneNumber = 1;
            int twoNumber = 1;
            int sum = 1;
            
            int i = 3;

            if (N<=0)
            {
                throw new Exception("");
            }
            while (N >= i)
            {
                sum = oneNumber + twoNumber;
                oneNumber = twoNumber;
                twoNumber = sum;
                i++;
            }
            if (N == 1)
            {
                int tmp = oneNumber;
            }
            else if (N == 2)
            {
                int tmp = twoNumber;
            }
            else if (N >= 3)
            {
                int tmp = sum;
            }
            return sum;
        }
    

    
    
        public static int FindTheGreatestComminDivisor(int NumberM,int NumberQ)
        {
            if (NumberM<0 && NumberQ<0)
            {
                throw new Exception("");
            }
            if (NumberM == 0 && NumberQ == 0)
            {
                throw new Exception("");
            }
                while (NumberM != NumberQ)
            {
                if (NumberM > NumberQ)
                {
                    NumberM = NumberM - NumberQ;
                }
                else
                {
                    NumberQ = NumberQ - NumberM;
                }
            }

            int nod = NumberQ;
            return nod;
        }
           
        public static int FindaNumberUsingTheHalfDivisionMethod(int enteredNumber) //тут ошибка//
        {
            int middle = 0;
            int numberRight = enteredNumber;
            int numberLeft = 0;
            
            if(enteredNumber <= 0)
            {
                throw new Exception("");
            }

            while (Math.Pow(middle, 3) != enteredNumber)
            {
                middle = (numberRight + numberLeft) / 2;
                if (Math.Pow(middle, 3) < enteredNumber)
                {
                    numberRight = middle;
                }
                else
                {
                    numberLeft = middle;
                }

            }
            
            return middle;
        }
    
    
    
        public static int FindNumberOfOddDigits(int NumberEntered)
        {
            int numberOdd = 0;
           
            for (int i = 1; i <= NumberEntered; i++)
            {
                if (i % 2 == 1)
                {
                    numberOdd++;
                }
            }
            return numberOdd; 
        }
    
       
    
        public static int FindaNumberThatIsaMirrorImageOfaSequencefDigitsOfaGivenNumber(int NumberEnteredUser)
        {
            int z = 0;
            int tmp;
            if (NumberEnteredUser <= 0)
            {
                throw new Exception("");
            }
            while (NumberEnteredUser != 0)
            {
                tmp = NumberEnteredUser % 10;
                z *= 10;
                z += tmp;
                NumberEnteredUser /= 10;
            }
            return z;
        }

        public static int[] OutputNumbersInTheRange(int N)
        {
            if (N <= 0)
            {
                throw new Exception("");
            }

            int sumOdd = 0;
            int sumEven = 0;
            int length = 0;

            for (int i = 1; i <= N; i++)
            {
                int j = i;

                while (j != 0)
                {
                    int tmp = j % 10;
                    if (tmp % 2 == 1)
                    {
                        sumOdd += tmp;
                    }
                    else
                    {
                        sumEven += tmp;
                    }
                    j = j / 10;
                }
                if (sumEven > sumOdd)
                {
                    length++;
                }
                sumOdd = 0;
                sumEven = 0;
            }
            int[] result = new int[length];
            int ind = 0;
            for (int i = 1; i <= N; i++)
            {
                int j = i;

                while (j != 0)
                {
                    int tmp = j % 10;
                    if (tmp % 2 == 1)
                    {
                        sumOdd += tmp;
                    }
                    else
                    {
                        sumEven += tmp;
                    }
                    j /= 10;
                }
                if (sumEven > sumOdd)
                {
                    result[ind] = i;
                    ind++;
                }
                sumOdd = 0;
                sumEven = 0;
            }

            return result;
        }

        public static bool TellMeIfThereAreTheSameDigitsInTheSpellingOfTwoNumbers(int NumberEnteredA, int NumberEnteredB)
        {

            bool res = false;

            if (NumberEnteredA < 0 || NumberEnteredB<0)
            {
                throw new Exception("");
            }

            while (NumberEnteredA != 0)
            {
                int figureA = NumberEnteredA % 10;
                int tmpB = NumberEnteredB;
                while (tmpB != 0)
                {
                    int figureB = tmpB % 10;
                    if (figureA == figureB)
                    {
                        res = true;
                        break;
                    }
                    tmpB /= 10;
                }
                NumberEnteredA /= 10;
            }
            return res;
        }
        public static void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
