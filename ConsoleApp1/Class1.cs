using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Class1
    {
        public static void MyTasks(int i)
        {
            switch (i)
            {
                case 1:
                    PrimeNumber();
                    break;
                case 2:
                    NewTask();
                    break;
                case 3:
                    PalindromeNumber();
                    break;
                default:
                    Console.WriteLine("Enter a valid number");
                    break;
            }
        }
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter the number you wish to check: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = false;
            if (num == 0 || num == 1)
            {
                Console.WriteLine("Not a prime number");
            }
            else if (num == 2)
            {
                Console.WriteLine(num + " is a prime number.");
            }
            else if (num > 2)
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("Not a prime number");
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(num + " is a prime number.");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }
        }
 
        public static void NewTask()
        {
            string greeting = "Hello";
            for(int i = 0;i<=greeting.Length;i++)
            {
                string newGreeting = "";
                for(int j=i;j<=greeting.Length-1;j++)
                {
                    newGreeting += greeting.Substring(j,1);
                    Console.Write(newGreeting + ", ");
                }
                Console.WriteLine();
            }
        }
        public static void PalindromeNumber()
        {
            Console.WriteLine("Enter a string");
            var palindrome = Console.ReadLine();
            string newString="";
            if (palindrome!=null)
            {
                int length = palindrome.Length;
                for (int i = length - 1; i <= 0; i--)
                {
                    newString += palindrome[i];
                    Console.Write(palindrome[i]);
                  /*  if (newString == palindrome)
                    {
                        Console.WriteLine("Palindrome");
                        break;
                    }*/
                }
            }
           
        }
    }
}
