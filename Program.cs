namespace testProj4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //first value enter
            Console.WriteLine("Enter value a:");
            int a = Convert.ToInt32(Console.ReadLine());
            //second value enter
            Console.WriteLine("Enter value b:");
            int b = Convert.ToInt32(Console.ReadLine());

            //value c = a + b 
            int c = a + b;
            Console.WriteLine(c);
            //user need to choice operation from 0 to 3
            Console.WriteLine("Choose operation:");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 0:
                    Console.WriteLine("Case 0");
                    break;
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
            }
        }
    }
}