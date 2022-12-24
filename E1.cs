namespace cs_exercises
{
    internal class E1
    {
        static void Main(string[] args)
        {
            //FindGreatestNumber();
            //CheckIfNumberIsEven();
            //LongestString();
            GetHypotenuseFromSides();
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
            //Create a method which return true if the number is even or false if it's not

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

        static void LongestString()
        {
            //Write a method which finds the longest between two strings entered by user

            Console.WriteLine("Enter a string");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter a second string:");
            string s2 = Console.ReadLine();

            Console.WriteLine($"The longest is: {ReturnLongestString(s1,s2)}");

            static string ReturnLongestString(string s1,string s2)
            {

                string result;

                if (s1.Length != s2.Length)
                {
                    result = s1.Length > s2.Length ? s1 : s2;
                }
                else
                {
                    result = "Both have the same length";
                }
                return result;
            }
        }

        static void GetHypotenuseFromSides()
        {
            try
            {
                Console.WriteLine("Enter one side");
                double c1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second side");
                double c2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"The hypotenuse is = {CalcHypotenuse(c1, c2)}");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You sure entered a text, very funny");
            }

            static double CalcHypotenuse(double c1, double c2)
            {
                return Math.Sqrt(c1*c1+c2*c2);
            }
        }
    }
}