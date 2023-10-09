using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System;
using System.Linq;

namespace Practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Basics | 100 Coding Challenges
            // Challenges 1 -----------------------------------------------------------
            //Console.WriteLine("Hello World");

            // Challenges 2 -----------------------------------------------------------
            //Console.WriteLine("What Your Name ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Nice To Meet You " + name);

            // Challenges 3 -----------------------------------------------------------
            //Console.WriteLine("Enter First number");
            //string Number1 = Console.ReadLine();
            //Console.WriteLine("Enter Second number");
            //string Number2 = Console.ReadLine();
            //int X = Convert.ToInt32(Number1);
            //int Y = Convert.ToInt32(Number2);
            //int Sum = X + Y;
            //float AVG = (float) Sum / 2;
            //Console.WriteLine($"Sum Of To Number Is : {Sum} And  The AVG : {AVG} ");

            // Challenges 4 -----------------------------------------------------------
            //Console.WriteLine("Enter First number");
            //string Number1 = Console.ReadLine();
            //Console.WriteLine("Enter Second number");
            //string Number2 = Console.ReadLine();
            //int X = Convert.ToInt32(Number1);
            //int Y = Convert.ToInt32(Number2);
            //int Product = X * Y;

            //Console.WriteLine($"Product Of To Number Is : {Product} ");
            // Challenges 5 -----------------------------------------------------------
            // Console.WriteLine("Enter The Fahrenheit");
            // Double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            // double Centigrade = 5 * (Fahrenheit - 32) / 9;
            // double CentigradeToDecimale = Math.Round(Centigrade,2);

            //Console.WriteLine($"The Temperature Is : {CentigradeToDecimale} ");
            // Challenges 6 -----------------------------------------------------------
            //Console.WriteLine(" What Is Your Budget ");
            //decimal Budget = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(" How Muth was Spent on Food ");
            //decimal Food = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(" How Muth was Spent on Trips ");
            //decimal Trips = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(" How Muth was Spent on Presents ");
            //decimal Presents = Convert.ToDecimal(Console.ReadLine());
            //decimal Toutal = (Budget - Food - Trips - Presents);
            //Console.WriteLine("Left : " + Toutal + "$");
            //------------------------------------------------------------------------
            //Console.WriteLine(" What Is Your Budget ");
            //decimal MoneLeft = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(" How Muth was Spent on Food ");
            //MoneLeft -=  Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(" How Muth was Spent on Trips ");
            //MoneLeft -=   Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(" How Muth was Spent on Presents ");
            //MoneLeft -=  Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Left : " + MoneLeft + "$");

            // Challenges 7 -----------------------------------------------------------
            //Console.WriteLine("Enter Your Age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age > 16)
            //{
            //    Console.WriteLine("You are old enough to drive ");
            //}
            //else
            //{
            //    Console.WriteLine("You are NOT old enough to drive ");
            //}

            // Challenges 8 -----------------------------------------------------------
            //Console.WriteLine(" Wath Is Your Favourite subject  ");
            //string subject = Console.ReadLine();
            //if (subject == "Computer Science")
            //{
            //    Console.WriteLine("You must be very clever  ");
            //}
            //else
            //{
            //    Console.WriteLine("Boringgg");
            //}

            // Challenges 9 -----------------------------------------------------------
            //Console.WriteLine(" Wath Is Your Age ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age > 4 && age < 14)
            //{
            //    Console.WriteLine("You Are A Child");
            //}
            //else if (age > 14 && age < 21)
            //{
            //    Console.WriteLine("You Are A teenager");
            //}
            //else 
            //{
            //    Console.WriteLine("you Are A Adult");
            //}

            // Challenges 10 -----------------------------------------------------------
            //Console.WriteLine("Enter Your Password");
            //string password = Console.ReadLine();
            //Console.WriteLine("Confirm Your Password");
            //string confirmPassword = Console.ReadLine();
            //if (password != confirmPassword)
            //{
            //    Console.WriteLine("The two passwords did not match");
            //}
            //else
            //{
            //    Console.WriteLine("Password is accepted");
            //}

            // Challenges 11 -----------------------------------------------------------
            //Console.WriteLine("Number 1 ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 2");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 == num2)
            //{
            //    Console.WriteLine("The two Numbers are equal");
            //}
            //else
            //{
            //    Console.WriteLine("Numbers are NOT equal");
            //}

            // Challenges 12 -----------------------------------------------------------
            //Console.WriteLine("Number 1 ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 2");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 3");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine(num1);
            //}
            //else if (num2 > num3 && num2 > num1)
            //{
            //    Console.WriteLine(num2);
            //}
            //else if (num3 > num1 && num3 > num2)
            //{
            //    Console.WriteLine(num3);
            //}

            // Challenges 13 -----------------------------------------------------------
            //Console.WriteLine("Day in the week ");
            //int Day = Convert.ToInt32(Console.ReadLine());
            //switch (Day)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Not Day Of Week");
            //        break;
            //}


            // Challenges 14 -----------------------------------------------------------
            //while (true)
            //{
            //    Console.WriteLine("Enter You Age ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //switch (Age)
            //{
            //    case var n when n < 16 :
            //        Console.WriteLine("You are too young to drive");
            //        break;
            //    case var n when n == 16:
            //        Console.WriteLine("You can drive from this year");
            //        break;
            //    case var n when n > 17 && n < 65 :
            //        Console.WriteLine("You are old enough to drive");
            //        break;
            //    case var n when n > 66 && n < 75:
            //        Console.WriteLine("You need to renew you licence periodically");
            //        break;
            //    default:
            //        Console.WriteLine("You need to renew you licence annualiy");
            //        break;
            //} }

            // Challenges 15 -----------------------------------------------------------
            //Console.WriteLine("Months Number ");
            //int Months = Convert.ToInt32(Console.ReadLine());
            //switch (Months)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;
            //    default:
            //        Console.WriteLine("Non Months Found");
            //        break;
            //}

            // Challenges 16 -----------------------------------------------------------
            //Console.WriteLine("Months Number ");
            //int Months = Convert.ToInt32(Console.ReadLine());
            //switch (Months)
            //{
            //    case 1:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 2:
            //        Console.WriteLine("28 days (or 29 in a leap year)");
            //        break;
            //    case 3:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 4:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 5:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 6:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 7:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 8:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 9:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 10:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 11:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 12:
            //        Console.WriteLine("31 days");
            //        break;
            //    default:
            //        Console.WriteLine("Not Found");
            //        break;
            //    }
            //------------------------------------------------------------------------
            //while (true){
            //Console.WriteLine("Months Number ");
            //int Months = Convert.ToInt32(Console.ReadLine());
            //switch (Months)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 2:
            //        Console.WriteLine("28 days (or 29 in a leap year)");
            //        break;
            //    default:
            //        break;
            //}}


            // Challenges 17 -----------------------------------------------------------
            //while (true)
            //{
            //    Console.WriteLine("Enter a mark between 0 and 100 ");
            //    int Mark = Convert.ToInt32(Console.ReadLine());
            //    switch (Mark)
            //    {
            //        case var n when n < 40:
            //            Console.WriteLine("U");
            //            break;
            //        case var n when n >= 40 && n <= 49:
            //            Console.WriteLine("E");
            //            break;
            //        case var n when n >= 50 && n <= 59:
            //            Console.WriteLine("D");
            //            break;
            //        case var n when n >= 60 && n <= 69:
            //            Console.WriteLine("C");
            //            break;
            //        case var n when n >= 70 && n <= 79:
            //            Console.WriteLine("B");
            //            break;
            //        case var n when n >= 80 && n <= 100:
            //            Console.WriteLine("A");
            //            break;
            //        default:
            //            Console.WriteLine("between 0  and 100");
            //            break;
            //    }
            //}

            // Challenges 18 -----------------------------------------------------------
            //while (true)
            //{
            //    Console.WriteLine("Enter Comp1 ");
            //    double Comp1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Enter Comp2 ");
            //    double Comp2 = Convert.ToDouble(Console.ReadLine());
            //    var Totale = Comp1 + Comp2;
            //    double Percentage = (Totale / 160) * 100;
            //    string gard = "";
            //    switch (Percentage)
            //    {
            //        case var n when n < 40:
            //            gard = "U";
            //            break;
            //        case var n when n < 50:
            //            gard = "E";
            //            break;
            //        case var n when n < 60:
            //            gard = "D";
            //            break;
            //        case var n when n < 70:
            //            gard = "C";
            //            break;
            //        case var n when n < 80:
            //            gard = "B";
            //            break;
            //        case var n when n <= 100:
            //            gard = "A";
            //            break;
            //        default:
            //            Console.WriteLine("between 0  and 100");
            //            break;
            //    }
            //    Console.WriteLine($" With a total marks of {Totale}, you score {Percentage}% , which meands you got a {gard} ");
            //}

            // Challenges 19 -----------------------------------------------------------
            //Console.WriteLine("Enter Your Price Of Orders");
            //decimal originalPrice = Convert.ToDecimal(Console.ReadLine());
            //switch (originalPrice)
            //{
            //    case var n when n <= 1000:
            //        Console.WriteLine("You dont have a discount total price is : " + CalculateDiscountedPrice(originalPrice,0));
            //        break;
            //    case var n when n <= 2500:
            //        Console.WriteLine(" You have 5% discount the original Price is "+originalPrice + " and the price after discount is  : " + CalculateDiscountedPrice(originalPrice, 5));
            //        break;
            //    case var n when n <= 5000:
            //        Console.WriteLine("You have 10 % discount the original Price is "+originalPrice + " and the price after discount is  : " + CalculateDiscountedPrice(originalPrice, 10));
            //        break;
            //    case var n when n <= 10000:
            //        Console.WriteLine("You have 15 % discount the original Price is " + originalPrice + " and the price after discount is  : " + CalculateDiscountedPrice(originalPrice, 15));
            //        break;
            //    case var n when n > 10000:
            //        Console.WriteLine("You have 20 % discount the original Price is " + originalPrice + " and the price after discount is  : " + CalculateDiscountedPrice(originalPrice, 20));
            //        break;
            //    default:
            //        break;
            //}
            //static public decimal CalculateDiscountedPrice(decimal originalPrice, decimal discountPercentage)
            //{
            //    decimal discountAmount = (originalPrice * discountPercentage) / 100;
            //    decimal discountedPrice = originalPrice - discountAmount;
            //    return discountedPrice;
            //}

            // Challenges 20 -----------------------------------------------------------
            //Console.WriteLine("Enter Number");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //if (Number != 0)
            //{
            //    Console.WriteLine("This Number Not equal a 0");
            //}
            //else
            //{
            //    Console.WriteLine("why 0 why");
            //}

            // Challenges 21 -----------------------------------------------------------
            //Console.WriteLine("Enter Number Between 1 and 20");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //if (Number >= 0 && Number <= 20)
            //{
            //    Console.WriteLine("good Number ");
            //}
            //else
            //{
            //    Console.WriteLine("Not Good");
            //}

            // Challenges 22 -----------------------------------------------------------
            //while (true)
            //{
            //    Console.WriteLine("Enter Number Between 1 and 10 Or 100 and 120");
            //    int Number = Convert.ToInt32(Console.ReadLine());
            //    if (Number >= 0 && Number <= 20)
            //    {
            //        Console.WriteLine("good Number ");
            //    }
            //    else if (Number >= 100 && Number <= 120)
            //    {
            //        Console.WriteLine("good Number ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Good");
            //    }
            //}

            // Challenges 23 -----------------------------------------------------------
            //Console.WriteLine("Enter Your Age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age <= 16 || age >= 60)
            //{
            //    Console.WriteLine("You have a discount of 10$ You shoud pay 50$");
            //}
            //else
            //{
            //    Console.WriteLine("You dont  have a discount o shoud pay 60$");

            //}

            // Challenges 24 -----------------------------------------------------------
            //while (true)
            //{
            //    Console.WriteLine("Enter Your Age");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Are You pass Your Test Ple ansers Y Or N");
            //    string passed = Console.ReadLine();
            //    if (age > 21 && passed == "Y")
            //    {
            //        Console.WriteLine("You can drive");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" you cant drive");
            //    }
            //}

            // Challenges 25 -----------------------------------------------------------
            //while (true)
            //{
            //    Console.WriteLine("Enter Name Number 1 ");
            //    string name1 = Console.ReadLine();
            //    Console.WriteLine("Enter Name Number 2 ");
            //    string name2 = Console.ReadLine();
            //    Console.WriteLine("Enter Name Number 3 ");
            //    string name3 = Console.ReadLine();
            //    int outPut1 = name1.ToLower().CompareTo(name2.ToLower());
            //    int outPut2 = name1.ToLower().CompareTo(name3.ToLower());
            //    int outPut3 = name2.ToLower().CompareTo(name3.ToLower());
            //    if (outPut1 < 0)
            //    {
            //        if (outPut3 < 0)
            //        {
            //            Console.WriteLine("The order is: " + name1 + " And " + name2 + " And " + name3);
            //        }
            //        else
            //        {
            //            Console.WriteLine("The order is: " + name1 + " And " + name3 + " And " + name2);
            //        }
            //    }
            //    else
            //    {
            //        if (outPut2 < 0)
            //        {
            //            Console.WriteLine("The order is: " + name2 + " And " + name1 + " And " + name3);
            //        }
            //        else
            //        {
            //            Console.WriteLine("The order is: " + name2 + " And " + name3 + " And " + name1);
            //        }
            //    }
            //}

            // Challenges 26 -----------------------------------------------------------
            //while (true)
            //{
            //    Console.WriteLine("Give me a year");
            //    int Year = Convert.ToInt32(Console.ReadLine());

            //    if (Year % 4 != 0)
            //    {
            //        Console.WriteLine("it is Not a leap year");
            //    }
            //    else if (Year % 100 != 0)
            //    {
            //        Console.WriteLine("it is a leap year");
            //    }
            //    else if (Year % 400 != 0)
            //    {
            //        Console.WriteLine("it is Not a leap year");
            //    }
            //    else
            //    {
            //        Console.WriteLine("it is a leap year");
            //    }
            //}
            //------------------------------------------------------------------------
            //while (true)
            //{
            //    Console.WriteLine("Give me a year");
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    // Check if the year is a leap year
            //    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //    {
            //        Console.WriteLine(year + " is a leap year.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(year + " is not a leap year.");
            //    }
            //}

            // Challenges 27 -----------------------------------------------------------
            //try
            //{
            //    Console.WriteLine("Enter Your Price Of Orders");
            //    decimal originalPrice = Convert.ToDecimal(Console.ReadLine());
            //    if (originalPrice > 0 && originalPrice < 25000)
            //    {
            //        switch (originalPrice)
            //        {
            //            case var n when n <= 1000:
            //                Console.WriteLine("You dont have a discount total price is : " + CalculateDiscountedPrice(originalPrice, 0));
            //                break;
            //            case var n when n <= 2500:
            //                Console.WriteLine(" You have 5% discount the original Price is " + originalPrice + " and the price after discount is  : " + CalculateDiscountedPrice(originalPrice, 5));
            //                break;
            //            case var n when n <= 5000:
            //                Console.WriteLine("You have 10 % discount the original Price is " + originalPrice + " and the price after discount is  : " + CalculateDiscountedPrice(originalPrice, 10));
            //                break;
            //            case var n when n <= 10000:
            //                Console.WriteLine("You have 15 % discount the original Price is " + originalPrice + " and the price after discount is  : " + CalculateDiscountedPrice(originalPrice, 15));
            //                break;
            //            case var n when n > 10000:
            //                Console.WriteLine("You have 20 % discount the original Price is " + originalPrice + " and the price after discount is  : " + CalculateDiscountedPrice(originalPrice, 20));
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Plz Enter A price Betwee, 0 and 25000");
            //    }
            //}
            //catch (Exception x)
            //{
            //    Console.WriteLine(" Plz Enter A Number");
            //}
            //static public decimal CalculateDiscountedPrice(decimal originalPrice, decimal discountPercentage)
            //{
            //    decimal discountAmount = (originalPrice * discountPercentage) / 100;
            //    decimal discountedPrice = originalPrice - discountAmount;
            //    return discountedPrice;
            //}

            // Challenges 28 -----------------------------------------------------------
            //ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything
            //but exactly 4 digits or exactly 6 digits.Your task is to create a function that 
            //takes a string and returns true if the PIN is valid and false if it's not.
            //public static bool ValidatePIN(string pin)
            //{
            //    if (pin.Length == 4 || pin.Length == 6)
            //    {
            //        return pin.All(char.IsDigit);
            //    }
            //    return false;
            //
            //------------------------------------------------------------------------------
            // 1 zawji ola fardi 
            // ila kan fardi add"_" radi wali zawbji
            //change to char array boucliw   atbda mn 1  ++2
            // wast for var chaincar   item =  Chars[i-1] + char[i]
            // 9bl mn for arr of stri char of arry  9smha 3La 2

            // Challenges 28 -----------------------------------------------------------
            //Console.WriteLine("Months Number ");
            //int Months = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Give me a year");
            //int Year = Convert.ToInt32(Console.ReadLine());
            //int MonthsNumber = DaysOfMonth(Months,Year);
            //string YearisLeapYear = leapYear(Year);
            //Console.WriteLine($"Number of days in this month : {MonthsNumber} and the Year {YearisLeapYear}");
            //public static string leapYear(int year)
            //{
            //    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //    {
            //        return " is a  leapYear ";
            //    }
            //    else
            //    {
            //        return " is  not a  leapYear ";
            //    }


            //}
            //public static int DaysOfMonth(int months, int year)
            //{
            //    switch (months)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            return 31;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            return 30;
            //        case 2:
            //            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //            {
            //                return 29;
            //            }
            //            else
            //            {
            //                return 28;
            //            }
            //        default:
            //            throw new ArgumentException("Invalid month value. Month should be between 1 and 12.");
            //    }
            //}

            // Challenges 29 -----------------------------------------------------------
            //Console.WriteLine("Enter Number ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine($"{number} is even.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is odd.");
            //}

            // Challenges 30 -----------------------------------------------------------
            //Console.WriteLine("Number of the members travelling");
            //decimal Members = int.Parse(Console.ReadLine());
            //Console.WriteLine("Capacity of coatch");
            //decimal Capacity = int.Parse(Console.ReadLine());

            //int Calc = (int)(Members / Capacity);
            //Console.WriteLine("Number of full coatch : " + Calc);

            //if(Members % Capacity == 0)
            //{
            //    Console.WriteLine("Number of last passengers on the last coatch : " + Capacity);
            //}
            //else
            //{
            //    Console.WriteLine("Number of last passengers on the last coatch : " + Members % Capacity);

            //}
            //-------------------------------------------------------------------------------------------------
            //Console.WriteLine("Number of the members travelling");
            //decimal Members = int.Parse(Console.ReadLine());
            //Console.WriteLine("Capacity of coatch");
            //decimal Capacity = int.Parse(Console.ReadLine());
            //int Calc = (int)(Members / Capacity);
            //decimal NonCoatch = (Members / Capacity) - Calc;
            //decimal Lastplayer = (NonCoatch * Capacity);
            //int roundedNumber = (int)Math.Round(Lastplayer);
            //Console.WriteLine("Number of full coatch : " + Calc);
            //Console.WriteLine("Number of last passengers on the last coatch : " + roundedNumber);

            // Challenges 31 -----------------------------------------------------------







        }

    }



}

