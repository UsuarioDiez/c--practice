namespace cs_exercises
{
    internal class E1
    {
        static void Main(string[] args)
        {
            //FindGreatestNumber();
            CheckIfNumberIsEven();
        }

        static void FindGreatestNumber()
        {
            //Find biggest number

            Console.WriteLine("Enter first number");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double n2 = double.Parse(Console.ReadLine());

            if (n1 != n2)
            {
                Console.WriteLine($"the biggest number is  {(n2 > n1 ? n2 : n1)}");
            }
            else
            {
                Console.WriteLine("Same number");
            }
        }

        static void CheckIfNumberIsEven()
        {
            Console.WriteLine("Enter a number:");
            int num;

            try
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Is the number even? {CheckNumber(num)}");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            static bool CheckNumber(int n)
            {
                return (n % 2 == 0 ? true : false);
            }
        }
    }
}