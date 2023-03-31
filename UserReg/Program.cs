namespace UserReg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The FirstName");
            string name = Console.ReadLine();
            bool val = validation.Check(name);
            if (val)
            {
                Console.WriteLine("FirstName is {0}", name);
            }
            else
            {
                Console.WriteLine("Enter Valid Name");
            }
            Console.WriteLine("Enter The LastName");
            string lName = Console.ReadLine();
            bool val1 = validation.Check(lName);
            if (val1)
            {
                Console.WriteLine("LastName is {0}", lName);
            }
            else
            {
                Console.WriteLine("Enter Valid Name");
            }
            Console.WriteLine("FullName is {0} {1}", name, lName);
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Valid Email ID");
            validation v = new validation();
            string email = Console.ReadLine();
            v.ValidateEmail(email);
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Valid Phone Number");
            validation v1 = new validation();
            string phone = Console.ReadLine();
            v1.ValidatePhone(phone);
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Valid Password");
            validation p1 = new validation();
            string pass = Console.ReadLine();
            p1.ValidatePassword(pass);
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Valid Password with atleast 1 upperCase ");
            validation p2 = new validation();
            string pass1 = Console.ReadLine();
            p2.ValidatePassword1(pass1);
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Valid Password with atleast 1 number");
            validation p3 = new validation();
            string pass2 = Console.ReadLine();
            p3.ValidatePassword2(pass2);
        }
    }
}