using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1:
            //Create a function to say whether a string is symmetric (a palindrome). For example, "RADAR" is a palindrome. Hint: try using recursion.

            Console.Write("Enter string: ");
            string Pali = Console.ReadLine();
            bool pal = Palindrome(Pali);
            if (pal == true)
            {
                Console.WriteLine($"The string {Pali} is Palindrome!\n");
            }
            else
            {
                Console.WriteLine($"The string {Pali} is not Palindrome!\n");
            }
            //Console.Read();


            //Task 2:
            //Create a function which returns the greatest value stored in an array
            //of real numbers which is specified as parameter.

            int[] RealNumArray = new int[] { -3, -2, 1, 0, 1, 2, 3 };
            Console.WriteLine($"The max value of the array is {maxValue(RealNumArray)}"); // Option 1 - Max;
            Console.WriteLine($"The min value of the array is {minValue(RealNumArray)}"); // Option 2 - Min;
            //Console.Read();


            //Task 3:
            //Create a two function that calculates the amount of numeric digits and vowels(samoglaski) 
            //that a text string contains.
            //It will accept one parameter parameter: the string that we want to search,
            //Function 1 should return the number of digits, Function 2 should return the number of vowels.
            //Do not name them function1 and 2 :)

            Console.Write("Input the string : ");
            string str = Console.ReadLine();
            Console.WriteLine($"The number of vowels in the string is {NumOfVowels(str)}.");
            Console.WriteLine($"The number of numberic digits in the string is {NumOfDigits(str)}.");
            Console.WriteLine($"The number of vowels in the string is {NumOfVowels(str)} and the number of numeric digits is {NumOfDigits(str)}.");
            //Console.Read();


            // Task 4:
            //Create a function to read a sentence and replace lowercase characters by uppercase 
            //and vice - versa.

            Console.Write("Please input a sentence : ");
            string sentence = Console.ReadLine();
            Console.WriteLine(ToUpper(sentence));
            Console.WriteLine(ToLower(sentence));
            //Console.Read();


            //Task 5:
            //Create a function to check whether a character is an alphabet and not and if so,
            //go to check for the case.

            Console.Write("Enter your char please: ");
            char word = (char)Console.Read();
            Console.WriteLine(AlphabetCheck(word));
            //Console.Read();


            //Task 6:
            //Create a function to find the number of times a substring appears in a given string.

            Console.Write("Enter your string: ");
            string text = Console.ReadLine();
            Console.Write("Enter your pattern(substring frequency): ");
            string pattern = Console.ReadLine();
            Console.WriteLine($"There are {CountFreq(pattern, text)} substring appearences in the string {text}.");
            //Console.Read();


            //Task 7:
            //Create a function that calculates the result of raising an integer to another integer
            //(eg 5 raised to 3 = 53 = 5 × 5 × 5 = 125). This function must be created recursively.

            Console.Write("Input the base number: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the raising number: ");
            int raisingNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number {baseNumber} raised by {raisingNumber} is total: {RaisingNumber(baseNumber, raisingNumber)}.");
            //Console.Read();


            //Task 8:
            //Create a function to take one parameter n and calculate what day of the week 
            //is n days from this moment.

            Console.Write("Enter the number of days: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:D}", CalculateDays(input));
            //Console.Read();


            //Task 9:
            //Create a function to take one parameter n to display the date of past n years from current date and to tell what day it was. 
            //The parameter should not be larger that 20.


            //Console.WriteLine("Enter your number");
            DateTime today = DateTime.Today;
            Console.Write("Enter your number (highest 20): ");
            int inputYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(YearEarlier(today, inputYear));
            //Console.Read();
        }

        // Task 1 Method(Function);
        public static bool Palindrome(string palindrome)
        {
            if (palindrome.Length <= 1)
            {
                return true;
            }
            else
            {
                if (palindrome[0] != palindrome[palindrome.Length - 1])
                    return false;
                else
                    return Palindrome(palindrome.Substring(1, palindrome.Length - 2));
            }

        }

        // Task 2 Method(Function) - Option 1 - Max;
        public static int maxValue(int[] numbers)
        {
            int maxNum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (maxNum < numbers[i])
                {
                    maxNum = numbers[i];

                }

            }
            return maxNum;
        }

        // Task 2 Method(Function) - Option 2 - Min;
        public static int minValue(int[] numbers)
        {
            int minNum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (minNum > numbers[i])
                {
                    minNum = numbers[i];

                }

            }
            return minNum;
        }

        // Task 3 Method(Function) - Vowels;
        public static int NumOfVowels(string str)
        {
            int vowels = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowels++;
                }
            }

            return vowels;
        }

        // Task 3 Method(Function) - Numeric Digits;
        public static int NumOfDigits(string str)
        {
            int digits = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    digits++;
                }
            }

            return digits;
        }

        // Task 4 Method(Function) - Uppercase;
        public static string ToUpper(string upper)
        {
            return upper.ToUpper();

        }

        //Task 4 Method(Function) - Lowercase;
        public static string ToLower(string lower)
        {
            return lower.ToLower();

        }



        // Task 5 Method(Function) - Char;
        public static char AlphabetCheck(char words)
        {
            if (Char.IsLetter(words))
            {
                Console.WriteLine($"The char {words} is an alphabetic character");
            }
            else
            {
                Console.WriteLine($"The char {words} is not an alphabetic character");
            }

            return words;
        }


        // Task 6 Method(Function) - Substring count;
        public static int CountFreq(string pat, string txt)
        {
            int Member = pat.Length;
            int Number = txt.Length;
            int res = 0;

            for (int i = 0; i <= Number - Member; i++)
            {
                int j;
                for (j = 0; j < Member; j++)
                {
                    if (txt[i + j] != pat[j])
                    {
                        break;
                    }
                }

                if (j == Member)
                {
                    res++;
                    j = 0;
                }
            }
            return res;
        }


        // Task 7 Method(Function) - Raising integer;
        public static int RaisingNumber(int number, int raise)
        {
            int value = 1;
            int i;
            for (i = 1; i <= raise; i++)
                value = value * number;
            return value;
        }


        // Task 8 Method(Function) - DateTime from now;
        public static DateTime CalculateDays(int input)
        {
            return DateTime.Today.AddDays(input);
        }


        // Task 9 Method(Function) - DateTime from now;

        public static DateTime YearEarlier(DateTime mydate, int input)
        {           
            for (int i = 0; i >= - input; i--)
            {
                Console.WriteLine("{0,2} year(s) ago: {1:D}",
                Math.Abs(i), mydate.AddYears(i));
            }
            return mydate;           
        }
    }
}
