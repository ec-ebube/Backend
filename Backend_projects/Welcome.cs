using System;

namespace HelloWorld
{
    class Welcome
    {
        static void Main(string[] args)
        {
            //This is used for single line comment
            Console.WriteLine("Hello, World");
            /*This is used for multiline comments*/
            Console.WriteLine("Welcome to C#");
            // int age;
            // age = (12 + 4);
            // double amount = 125.4;
            // char gender = "M";
            // string name = "Emmanuel";
            // bool isActive = true;

            // Console.WriteLine(age);
            // Console.WriteLine(gender);
            // Console.WriteLine(amount);
            // Console.WriteLine(name);
            // Console.WriteLine(isActive);

            /*
            Calculate the Area of a trapezium whose heigth is 14cm, and the top width = 7cm
            while the second width = 10cm
            */
            //Let heigth = H, top width = A, second width = B
            //formular = ((A + B)*H)/2
            // int H, B, A;
            // H = 14;
            // A = 7;
            // B = 10;
            // int Area = ((A + B)*H)/2;
            // double Area2 = ((A + B)*H)/2;
            // Console.WriteLine(Area);
            // Console.WriteLine(Area2);

            // Console.WriteLine("Enter username");
            // string username = Console.ReadLine();

            // Console.WriteLine("Welcome " + username);

            // Console.WriteLine("Enter your year of birth");
            // int age = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Your age is " + (2023 - age));
            // Console.WriteLine($"Your name is {username} and you are {(2023-age)} yrs old");
            // =========Math Functons======================
            // int x = 100 + 50;
            // int y = 100;
            // Console.WriteLine(Math.Max(x, y));
            // Console.WriteLine(Math.Min(x, y));
            // Console.WriteLine(Math.Abs(-4.7));
            // Console.WriteLine(Math.Round(10.7));
            // Console.WriteLine(Math.Round(Math.Sqrt(x)));
            // Console.WriteLine(Math.Sqrt(x));

            //==========String Function===============
            // string txt = "This is still a beginner class in c#";
            // Console.WriteLine(txt);
            // Console.WriteLine($"The length of the string above is {txt.Length}");
            // Console.WriteLine(txt.ToUpper());
            // Console.WriteLine(txt.ToLower());

            // string firstname = "Emmanuel";
            // string secondname = "Chimdiebube";
            // string name = string.Concat(firstname +" "+ secondname);
            // Console.WriteLine(name);

            // Console.WriteLine(firstname[4]);
            // Console.WriteLine(firstname.IndexOf(E));

            /*A programme to calculate the area of a triangle but also accepts user input*/
            //     int a, c;
            //     Console.WriteLine("Put in the sides of  a triangle in the spaces below to calculate the Area");
            //     Console.WriteLine("What is the heigth A");
            //     a = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("What is the Length of the base C");
            //     c = Convert.ToInt32(Console.ReadLine());

            //     int Area;
            //     Area = ((c/2)*a);
            //     Console.WriteLine($"The area of the Triangle with heigth {a}, and base {c}, is {Area}");
            // }

            // string firstname, lastname, state;
            // int yob, age;

            // Console.Write("Hello, Please Enter your firstname? ");
            // firstname = Console.ReadLine();
            // Console.Write("Enter your Lastname? ");
            // lastname = Console.ReadLine();
            // Console.Write("Enter your year of birth ");
            // yob = Convert.ToInt32(Console.ReadLine());
            // Console.Write("What is your state of residence ");
            // state = Console.ReadLine();

            // age = 2023 - yob;

            // if (age >= 18) {
            //     Console.WriteLine($"Dear {firstname} {lastname}");
            //     Console.WriteLine($"Congratulations on your registratin as a Nigerian voter, below are your voting detailes ");
            //     Console.WriteLine($"Card no: 101{yob}990");
            //     Console.WriteLine($"Voting center: {state}");
            // } else {
            //     Console.WriteLine($"Sorry {firstname} {lastname}, You"re not eligible to vote.");
            // }

            // int A, B, C;
            // Console.WriteLine("Hello, let"s play a game.");
            // Console.WriteLine("You will have to put in three different numbers and I will tell you the highest");

            // Console.Write("Input the first number ");
            // A = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Input the second number ");
            // B = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Input the Third number ");
            // C = Convert.ToInt32(Console.ReadLine());

            // if (A > B && A > C) {
            //     Console.WriteLine($"A: {A} is the Greatess");
            // } else if (B > C && B > A) {
            //     Console.WriteLine($"B: {B} is the Greatess");
            // } else {
            //     Console.WriteLine($"C: {C} is the Greatess");

            // if (B < A > C) {
            //     Console.WriteLine($"A: {A} is the Greatess");
            // }else if (A < B > C) {
            //     Console.WriteLine($"B: {B} is the Greatess");
            // } else {
            //     Console.WriteLine($"C: {C} is the Greatess");
            // }
            //     int biggest = A;
            //     if(B > A) {
            //         biggest = B;
            //     }
            //     if(C > B){
            //         biggest = C;
            //     }
            //     Console.WriteLine("The biggest is: " +biggest);
            // }

            // An app that calculates the amount of money spent per minute, hour or day of parking in a particular garage.
            // it charges 1 dollar for the first 15 minute and then $0.5 till the next 24hrs. After the next 24hrs 
            //charge reduces to $15.

            // double totalamount, first15, minutes;
            // // daily = 15;

            // Console.WriteLine("For how many minutes has the car been parked?");
            // minutes = Convert.ToInt32(Console.ReadLine());

            // first15 = 1 * minutes;

            // if (minutes <= 15){
            //     Console.WriteLine($"Your charge is ${first15}");
            // } else if (minutes > 15 && minutes < 1440) {
            //     double above15min, charge15;
            //     above15min = minutes - 15;
            //     charge15 = above15min * 0.5;
            //     first15 = 1 * 15;
            //     totalamount = first15 + charge15;
            //     Console.Write($" Your charge is {totalamount}");
            // } else if(minutes >= 1440) {
            //     double for24 = minutes / 1440;
            //     double mode24 = minutes % 1440;
            //     double deci24 = mode24 / 1440;
            //     double real424 = for24 - deci24;
            //     double dailyamount = real424 * 15;
            //     double lessdaily = mode24 * 0.5;
            //     totalamount = dailyamount + lessdaily;

            //     Console.WriteLine($"Your charge is ${totalamount}");
            // }

            // int day = 5;
            // if (day == 1)
            // {
            //     Console.WriteLine("Today is monday");
            // } else if (day == 2)
            // {
            //     Console.WriteLine("Today is Tuesday");
            // } else if (day == 3)
            // {
            //     Console.WriteLine("Today is Wednesday");
            // } else if (day is not 4)
            // {
            //     Console.WriteLine("Today is Thursday");
            // } else if (day == 5)
            // {
            //     Console.WriteLine("Today is Friday");
            // } else if (day is 6)
            // {
            //     Console.WriteLine("Today is Saturday");
            // } else if (day is 7)
            // {
            //     Console.WriteLine("Today is Sunday");
            // }
            // ===========================Switch in C#=============================//
            // int day = 5;
            // switch (day)
            // {
            //     case 1:
            //     Console.WriteLine("Today is Monday");
            //     break;

            //     case 2:
            //     Console.WriteLine("Today is Tuesday");
            //     break;

            //     case 3:
            //     Console.WriteLine("Today is Wednesday");
            //     break;

            //     case 4:
            //     Console.WriteLine("Today is Thursday");
            //     break;

            //     case 5:
            //     Console.WriteLine("Today is Friday");
            //     break;

            //     case 6:
            //     Console.WriteLine("Today is Saturday");
            //     break;

            //     case 7:
            //     Console.WriteLine("Today is Sunday");
            //     break;

            //     default:
            //         Console.WriteLine("Invalid Day");
            //         break;
            // }

            //-==============================Loops in C#=========================//
            //---------------------------While loop-----------------------------
            // int day = 7;
            // while (day > 0)
            // {
            //     switch (day)
            // {
            //     case 1:
            //     Console.WriteLine($"Day {day} is Monday");
            //     break;

            //     case 2:
            //     Console.WriteLine($"Day {day} is Tuesday");
            //     break;

            //     case 3:
            //     Console.WriteLine($"Day {day} is Wednesday");
            //     break;

            //     case 4:
            //     Console.WriteLine($"Day {day} is Thursday");
            //     break;

            //     case 5:
            //     Console.WriteLine($"Day {day} is Friday");
            //     break;

            //     case 6:
            //     Console.WriteLine($"Day {day} is Saturday");
            //     break;

            //     case 7:
            //     Console.WriteLine($"Day {day} is Sunday");
            //     break;

            //     default:
            //         Console.WriteLine("Invalid Day");
            //         break;
            // }
            // day --;
            // }

            // Console.WriteLine("Enter a number that is greater than 0");
            // int number = Convert.ToInt32(Console.ReadLine());
            // int sum = 0;
            // sum = sum + number;
            // while (number >= 0)
            // {
            //     Console.WriteLine("Enter a number that is greater than 0");
            //     number = Convert.ToInt32(Console.ReadLine());
            //     sum = sum + number;
            // }

            // Console.WriteLine(sum);

            // int num = 4;
            // do 
            // {
            //   Console.WriteLine(num);
            //   num--;  
            // } while (num > 5);

            // Console.WriteLine("Enter a number that is greater than 0");
            // int number = Convert.ToInt32(Console.ReadLine());
            // int sum = 0;
            // sum = sum + number;
            // while(number > 0)
            // {
            //     number--;
            //     sum = number + sum;
            //     Console.WriteLine(sum); 
            // }

            // int digit = 4;
            // for (int i = 0; i <= digit; i++){
            //     Console.WriteLine(i);
            // }

            // Console.WriteLine("This is a software that helps the uneducated to convert their mobile numbers to international format");
            // Console.WriteLine("Input your phone Number in local format");
            // string PhoneNo = Console.ReadLine();
            // Console.WriteLine($"+234{PhoneNo[1]}{PhoneNo[2]}{PhoneNo[3]}{PhoneNo[4]}{PhoneNo[5]}{PhoneNo[6]}{PhoneNo[7]}{PhoneNo[8]}{PhoneNo[9]}{PhoneNo[10]}");
            // Console.WriteLine("Enter your country code ");
            // string countrycode = Console.ReadLine()!;

            // int[] num = new int[] {2, 6, 20, 5, 8, 9, 4};
            // Array.Sort(num);
            // Console.WriteLine("Assending: ");
            //     foreach (int value in num)
            //     {
            //         Console.WriteLine(value + " ");
            //     }

            // Array.Sort<int>(num, new Comparison<int>(
            //     (i1, i2) => i2.CompareTo(i1)));
            // Console.WriteLine("Desending: ");
            //     foreach (int value in num)
            //     {
            //         Console.WriteLine(value + " ");
            //     }

            // Console.Write("Enter your phone number ");
            // string phoneNumber = Console.ReadLine()!;
            // numberCCode(phoneNumber, countrycode);
            // my_sort_func();
            // calculator();
            // finding();
            // binary_search();

        }
        // public static void numberCCode(string phoneNumber, string countrycode)
        // {

        // int len = phoneNumber!.Length;
        // if (phoneNumber![0] == "0")
        // {
        //     for (int i = 1; i < len; i++)
        //     {
        //         countrycode = countrycode + (phoneNumber[i].ToString());
        //         // Console.WriteLine(numwithcode);
        //     }
        // } else
        // {
        //     Console.WriteLine(phoneNumber);
        // }
        //     Console.WriteLine(countrycode);
        // }

        public static void printIntArr(int[] arr)
        {
            Console.WriteLine(String.Join(",", arr));
        }
        public static int[] RmvElement(int[] arr, int item)
        {
            arr = arr.Where(e => e != item).ToArray();
            return arr;
        }
        public static void my_sort_func()
        {
            int[] list = { 5, 3, 2, 7, 9, 10};
            int[] newlist = new int[list.Length];
            int counter = list.Length - 1;
            int count = 0;
            Console.WriteLine("Before sorting");
            printIntArr(list);

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
            Console.WriteLine("___________________________");
            Console.WriteLine("After sorting");
            printIntArr(newlist);

        //     //Make  a calculator as an assignment

        //     int num = 2+5;
        //     Console.WriteLine(num);
        //     int input = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine(input);
        // }

        // public static void calculator()
        // {
        //     Console.Write("Enter first number: ");
        //      int num1 = Convert.ToInt32(Console.ReadLine());
        //     
        // Console.Write("Enter a (/,+,*,-, %)");
        //     string symbol = Console.ReadLine()!;
        //     Console.Write("Enter second num: ");
        //     int num2 = Convert.ToInt32(Console.ReadLine());
        //     int ans;

        //     switch (symbol)
        //     {
        //         case "+":
        //         ans = num1 + num2;
        //         Console.Write($" Answer = {ans}");
        //         break;

        //         case "-":
        //         ans = num1 - num2;
        //         Console.Write($" Answer = {ans}");
        //         break;

        //         case "/":
        //         ans = num1/num2;
        //         Console.Write($" Answer = {ans}");
        //         break;

        //         case "*":
        //         ans = num1 * num2;
        //         Console.Write($" Answer = {ans}");
        //         break;

        //         case "%":
        //         ans = num1 % num2;
        //         Console.Write($" Answer = {ans}");
        //         break;

        //         default:
        //         Console.WriteLine("Wrong Input");
        //         break;
        //     }
        // }

        // public static void finding()
        // {
        //     int[] array = {0,5,7,10,12,15};
        //     Console.WriteLine("Which number do you want to find in the array?");
        //     int x = Convert.ToInt32(Console.ReadLine());

        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         if (x == array[i])
        //         {
        //            Console.WriteLine(i);
        //            break;
        //         }else
        //         {
        //             Console.WriteLine("Input not found or Wrong Input");
        //         }
        // }}

        
    }
}}