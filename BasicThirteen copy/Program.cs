using System;
// using System.Collections.Generic;

namespace BasicThirteen
{
    class Program
    { 
        static void Main(string[] args)
        {
            PrintNumbers(1, 255);
            PrintOdds(1, 255);
            PrintSum(0, 255);
        }
        public static void PrintNumbers(int start, int end)
        {
            for(int i=start; i<=end; i++){
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds(int start, int end)
        {
            for(int i=start; i<=end; i++){
                if(i%2!=0){
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum(int start, int end)
        {
            int sum = 0;
            for(int i=start; i<=end; i++){
                sum = i+sum;
                Console.WriteLine(i + " " + sum );
            }
        }
        public static void LoopArray(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int max = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                if(max < numbers[i])
                max = numbers[i];
            }
            Console.WriteLine(max);
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            int avg = 0; 
            for(int i=0; i<numbers.Length; i++)
            {
                sum = numbers[i] + sum;
            }
            avg = sum/numbers.Length;
            Console.WriteLine(avg);
        }
        public static int[] OddArray()
        {
            int count = 0;
            int[] newArr = new int[256/2];
            for(int i=1; i<=256; i++){
                if(i%2!=0){
                    newArr[count] = i;
                    count = count + 1;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(newArr);
            return newArr;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i]>y)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine(count);
            return count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            
            for(int i=0; i<numbers.Length; i++)
            {
                int product = numbers[i] * numbers[i];
                numbers[i] = product;
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            if(numbers.Length != 0){
                int min = numbers[0];
                int max = numbers[0];
                int sum = 0;
                int avg = 0;
                for(int i=0; i<numbers.Length; i++)
                {
                    sum = numbers[i] + sum;
                    if(numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    if(numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                avg = sum/numbers.Length;
                Console.WriteLine(min + " " + max + " " + avg);
            }
        }
        public static void ShiftValues(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length-1] = 0;
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] newArr = new object [numbers.Length];
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    newArr[i] = "Dojo";
                }
            }
            return newArr;
        }
    }
}

