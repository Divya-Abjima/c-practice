namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name="Divya";
            Console.WriteLine("Hello " + name + "!");
            string[] tasks = {"Fibonacci","Prime number", "Palindrome number", "Factorial"};
            int index = 1;
            if (tasks.Length== 0)
            {
                Console.WriteLine("You don't have any tasks :(");
            }
            else
            {
                Console.WriteLine("Your tasks:");
                foreach(string task in tasks)
                {
                    
                    Console.WriteLine(index+"."+task);
                    index++;
                }
            }
            int idx = Convert.ToInt32(Console.ReadLine());
            //string tsk = Console.ReadLine();
            MyTasks(idx);
        }

        static void MyTasks(int i)
        {
            switch (i)
            {
                case 1 :
                    break;
                case 2 : PrimeNumber();
                    break;
                default: Console.WriteLine("Enter a valid number");
                    break;
            }
        }

        static void PrimeNumber()
        {
            Console.WriteLine("Enter the number you wish to check: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num<0 || num ==0|| num==1)
            {
                Console.WriteLine("Not a prime number");
            }
            else if (num > 1)
            {
                for(int i=2; i<= num/2; i++)
                {
                    var result = num % i;
                    if(result==0)
                    {
                        Console.WriteLine("Not a prime number");
                        break;
                    }
                }
                Console.WriteLine(num+" is a prime number");
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}
