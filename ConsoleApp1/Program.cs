
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name="Divya";
            Console.WriteLine("Hello " + name + "!");
            string[] tasks = {"Prime number", "New Task", "Palindrome", "Factorial"};
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
            Class1.MyTasks(idx);
        }

       

        
    }
}
