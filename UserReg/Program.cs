namespace UserReg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The FirstName");
            string Name = Console.ReadLine();
           bool val = validation.Check(Name);
            //Console.WriteLine(val);
            if (val)
            {
                Console.WriteLine("FirstName is {0}", Name);
            }
            else
            {
                Console.WriteLine("Enter Valid Name");
            }
        }
    }
}