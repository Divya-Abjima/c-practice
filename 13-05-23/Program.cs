namespace _13_05_23
{
    public class Program
    {

        public delegate void FunC(string name);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Example of operator overloading");
            Class1 cl1 = new Class1();
            cl1.num = 7392;
            cl1.str = "String";
            Console.WriteLine("Object 1 : " + cl1.num + ", "+cl1.str);
            Class1 cl2 = new Class1();
            cl2.num = 6474;
            cl2.str = "Concat";
            Console.WriteLine("Object 2 : " + cl2.num + ", " + cl2.str);
            Class1 cl3 = new Class1();
            cl3 = cl1 + cl2;
            Console.WriteLine("Object 3 : " + cl3.num + ", " + cl3.str);

            // Child childCl = new Child();
            // ((Class1)childCl).Func();
            Class1 c = new Child();
            //c.Func();
            for(int i=0; i<=3;i++)
            {
                c[i] = Console.ReadLine();
               // Console.WriteLine(c[i]);
            }
            //Console.WriteLine(c);
            FunC obj = new FunC(Program.PrintName);
            obj.Invoke("nina");
            Console.ReadLine();
        }
        public static void PrintName(string name)
        {
            
            Console.WriteLine(name);
        }
    } class Class1
    {
        public string? str;
        public int num;

        string[] names = new string[4];
        public string this[int index]
        {
            set
            {
                names[index] = value;
            }
            get {
                return names[index];
            }
            
        }
        public static Class1 operator +(Class1 cl1, Class1 cl2)
        {
            Class1 cl3 = new Class1();
            cl3.num = cl1.num + cl2.num;
            cl3.str = cl1.str + cl2.str;
            return cl3;
        }
        public static void Func()
        {
            Console.WriteLine("Parent class method is invoked");
        }
        public virtual void Print()
        {
            Console.WriteLine("Child class 2 method is invoked");
        }
      
    }
     sealed class Child : Class1
    {
        public new void Func()
        {
           // base.Func();
            Console.WriteLine("Child class method is invoked");
        } 
    }
    class Child2 : Class1
    {
        public sealed override void Print()
        {
            Console.WriteLine("Child class 2 method is invoked");
        }
    }
    //class Child2 : Child { }
    class Grandchild : Child2
    {
        //public override void Print()
        //{
        //    Console.WriteLine("Grandchild class method is invoked");
        //}
    }

}