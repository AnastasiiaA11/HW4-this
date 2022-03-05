﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Methods
{
    internal class HomeworkCyclesOne
    {
        public static double SquaringNumber(int A, int B)
        {
            double C = 1;
            if (B >= 0)
            {
                for (int i = 0; i < B; i++)
                {
                    C = C * A;
                }
                return C;
            }
            else
            {
                for (int i = 0; i < Math.Abs(B); i++)

                {
                    C = C * A;
                }

                C = 1 / C;
                return  C;
            }

        }
    }
    internal class HomeworkCyclesTree
    {
        public static int FindTheNumberOfPositiveIntegers(int numberA)
        {
            int z = 0;
            for (int i = 1; i < Math.Sqrt(numberA); i++)
            {
                z = i;

            }
            return z;

        }
    }
    internal class HomeworkCyclesFour
    {
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
    }
    
    internal class HomeworkCyclesFive
    {
        public static int GetTheSumOfAllNumbersinaGroup(int numberOneA, int numberOneB)
        {
            int z = 0;

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
    }
    internal class HomeworkCyclesSix
    {
        public static int PrintTheNthNumberOfTheFibonacciSeries(int N)
        {
            int oneNumber = 1;
            int twoNumber = 1;
            int sum = 0;
            int tmp = 0;
            int i = 3;
            while (N >= i)
            {
                sum = oneNumber + twoNumber;
                oneNumber = twoNumber;
                twoNumber = sum;
                i++;
            }
            if (N == 1)
            {
                tmp = oneNumber;
            }
            else if (N == 2)
            {
                tmp = twoNumber;
            }
            else if (N >= 3)
            {
                tmp = sum;
            }
            return sum;
        }
    }

    internal class HomeworkCyclesSeven
    {
        public static int FindTheGreatestComminDivisor(int NumberM,int NumberQ)
        {
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
    }
    internal class HomeworkCyclesEight
    {
        public static int FindaNumberUsingTheHalfDivisionMethod(int enteredNumber)
        {
            int middle = 0;
            int numberRight = 0;
            int numberLeft = enteredNumber;

            do
            {
                middle = (numberRight + numberLeft) / 2;
                if (Math.Pow(middle, 3) < middle)
                {
                    numberRight = middle;
                }
                else
                {
                    numberLeft = middle;
                }
            }
            while (Math.Pow(middle, 3) != enteredNumber);
            return middle;
        }
    }
    internal class HomeworkCyclesNine
    {
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
    }
       internal class HomeworkCyclesTen
    {
        public static int FindaNumberThatIsaMirrorImageOfaSequencefDigitsOfaGivenNumber(int NumberEnteredUser)
        {
            int z = 0;
            int tmp;
            while (NumberEnteredUser != 0)
            {
                tmp = NumberEnteredUser % 10;
                z *= 10;
                z += tmp;
                NumberEnteredUser /= 10;


            }
            return z;
        }
    }
    internal class HomeworkCyclesTwelve
    {
        public static void TellMeIfThereAreTheSameDigitsInTheSpellingOfTwoNumbers(int NumberEnteredA, int NumberEnteredB)
        {
            bool check = false;

            while (NumberEnteredA != 0)
            {
                int tmp = NumberEnteredA % 10;
                while (NumberEnteredB != 0)
                {
                    int introducedVariable = NumberEnteredB % 10;
                    if (tmp == introducedVariable)
                    {
                        check = true;
                    }
                    NumberEnteredB = NumberEnteredB / 10;
                }
                NumberEnteredA = NumberEnteredA / 10;
            }
            if (check == true)
                
            {
                Console.WriteLine("");
            }
            
            else
            {
                Console.WriteLine("Нет");
            }


        }
    }
}