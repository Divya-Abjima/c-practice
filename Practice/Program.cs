using System.Xml;

namespace Practice
{
    class Program
    {
        string name;
        int id;
        string userType;
        public Program() //default constructor
        {
            Console.WriteLine("This is some text inside a constructor");
        }

        //parametrized constructor
        public Program(string name) 
        {
            this.name = name;
            Console.WriteLine(this.name);

        }
        
        public Program(int id)
        {
           this.id = id;
           Console.WriteLine("ID - " + this.id);
       }
        public Program(string name, int id, string userType)
        {
            this.name = name;
            this.id = id;
            this.userType = userType;
        }
        public string getName()
        {
            return this.name;
        }
        public int getId()
        {
            return this.id;
        }
        public string getUserType()
        {
            return this.userType;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");
            Program user1 = new Program("Divya", 1, "Admin");
            Console.WriteLine(user1.name + "\n" + user1.id + "\n"+ user1.userType);
            Console.WriteLine(user1.getId() + "\n"+ user1.getName()+"\n"+ user1.getUserType());

            //using encapsulation
            Encap user2 = new Encap();
            user2.setInfo("", 0.0, "divyauday23@gmail.com");
            user2.getInfo();

            //using set and get properties
            Class1 c = new Class1();
            c.UserId = -101;
            Console.WriteLine(c.UserId);
        }
    }
}