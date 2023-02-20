using System;

namespace HelloWorld
{
    class Projects
    {
        public static int binary_search(int K)
        {
           int[] binArray ={2,4,6,8,10,12,14};
           int minNum = 0;
           int maxNum = binArray.Length-1;

           while (minNum <= maxNum)
           {
                // Console.WriteLine(binArray[minNum]);
                int mid = (minNum + maxNum)/2;
                if (K == binArray[mid])
                {
                    return mid;
                }
                else if (K < binArray[mid])
                {
                    maxNum = mid-1;
                }
                else
                {
                    minNum = mid + 1;
                }
                // minNum++;
           }
           return 0;

           
        }

        public static int array_sum()
        {
            int[] array = {1,2,3,4,5,6,7};
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
        
        public static int array_max()
        {
            int[] arr = {1,2,3,4,5,6,7};
            int max = 0;
            for (int i = arr[0]; i <= arr.Length; i++)
            {
                if (max < i)
                {
                    max++;
                } 
                if (max == i)
                {
                    return max;
                }
            }
            return max;
        }

        public static int array_average()
        {
            int[] avgArr = {1,2,3,4,5,6,7,8,9};
            int sum = 0;
            // int average;
            foreach (var item in avgArr)
            {
                sum += item;
            }
            // average = sum/avgArr.Length;
            return sum/(avgArr.Length-1);
            
        }

        public static void printIntArr(int[] arr)
        {
            Console.WriteLine(String.Join(",", arr));
        }
        public static int[] RmvElement(int[] arr, int item)
        {
            arr = arr.Where(e => e != item).ToArray();
            return arr;
        }

        public static int array_min()
        {
            print_array();
            int[] list = { 5, 3, 2, 7, 9, 10};
            int[] newlist = new int[list.Length];
            int counter = list.Length - 1;
            int count = 0;
            for (int i = 0; i < list.Length; count++)
            {
                int biggest = 0;
                if (list.Length == 1)
                {
                    newlist[counter] = list[0];
                }
                else
                {
                    for (int j = i + 1; j < list.Length - i; j++)
                    {
                        if (list[i] > list[j] || biggest > list[j])
                        {
                            if (biggest <= list[i])
                            {
                                biggest = list[i];
                            }
                        }
                        else
                        {
                            biggest = list[j];
                        }
                    }
                    newlist[counter] = biggest;
                    list = RmvElement(list, biggest);
                }
                counter--;
                if (counter < 0)
                {
                    break;
                }

            }
            return newlist[0];
        }

        public static void print_array()


        {
            int[,] multiArray = { {1,3,5,7},{2,4,6,8} };
            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    Console.WriteLine(multiArray[i,j]);
                }
            }
        }
        // Create  three methods that depend on each other to run
        // double income = 300000;
        public static double all_taxes()
        {
            double income = 300000;
            double govt_tax = ((2/100)* income);
            double town_dues = ((0.9/100)*income);
            double tithe = ((10/100)* income);
            double others = ((5/100)*income);

            double takehome = ((income)-(govt_tax + town_dues + tithe + others));
            return takehome;
        }

        public static double responsibility()
        {
            double income = 300000;
            double food = 30/100 *(income);
            double health = 10/100 *(income);
            double clothing = 10/100*(income);
            double relatives = 20/100*(income);
            double emergencies = 12.4/100*(income);
            double savings = (all_taxes())-(food + health + clothing + relatives + emergencies);
            return savings;
        }

        public static double after_service()
        {
            double income = 300000;
            double years = 35;
            double spent = ((income)-(responsibility()))*years;
            double total_income = (income)*years;
            double pension = total_income - spent;
            return pension;
        }
    }
}