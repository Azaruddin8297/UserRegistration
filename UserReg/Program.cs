namespace UserReg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The FirstName");
            string Name = Console.ReadLine();
            bool val = validation.Check(Name);
            if (val)
            {
                Console.WriteLine("FirstName is {0}", Name);
            }
            else
            {
                Console.WriteLine("Enter Valid Name");
            }
            Console.WriteLine("Enter The LastName");
            string LName = Console.ReadLine();
            bool val1 = validation.Check(LName);
            if (val1)
            {
                Console.WriteLine("FirstName is {0}", LName);
            }
            else
            {
                Console.WriteLine("Enter Valid Name");
            }
        }
    }
}