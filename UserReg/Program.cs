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
                Console.WriteLine("LastName is {0}", LName);
            }
            else
            {
                Console.WriteLine("Enter Valid Name");
            }
            Console.WriteLine("FullName is {0} {1}", Name, LName);
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Valid Email ID");
            validation v = new validation();
            string EN = Console.ReadLine();
            v.ValidateEmail(EN);
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Valid Phone Number");
            validation v1 = new validation();
            string PH = Console.ReadLine();
            v1.ValidatePhone(PH);
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Valid Password");
            validation p1 = new validation();
            string Pass = Console.ReadLine();
            p1.ValidatePassword(Pass);
        }
    }
}