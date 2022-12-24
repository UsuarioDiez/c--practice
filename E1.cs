namespace cs_exercises
{
    internal class E1
    {
        static void Main(string[] args)
        {
            //FindGreatestNumber();
            //CheckIfNumberIsEven();
            //LongestString();
            //GetHypotenuseFromSides();
            //CountTo100();
            //CelsiusToFarenheit();
            //ProductOfListElements();
            //Factorial();
            ListAverage();
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
            //Write a method that returns the hypotenuse given two sides of the triangle
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

        static void CountTo100()
        {
            //Write a method that goes from 0 to 100 in a two series
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static void CelsiusToFarenheit()
        {
            //Write a method that takes a temperature as Celsius and transformes it to Farenheit
            try
            {
                Console.WriteLine("Enter temp in Celsius");
                double temp = double.Parse(Console.ReadLine());
                Console.WriteLine($"The temp in Celsius is = {ToFarenheit(temp)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("haha, nice try");
            }


            static double ToFarenheit(double temp)
            {
                return (1.8 * temp + 32);
            }
        }

        static void ProductOfListElements()
        {
            
            List<double> myList = new List<double> { };
            try
            {
                Console.WriteLine("Enter size of list");
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the values:");
                while (myList.Count < size)
                {
                    myList.Add(double.Parse(Console.ReadLine()));
                }
                Console.WriteLine($"The product of the items is = {ListProduct(myList)}");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("take care of your values");
            }

            static double ListProduct(List<double> myList)
            {
                double result = 1;
                foreach (double item in myList)
                {
                    result = item * result;
                }
                return result;
            }
        }

        static void Factorial()
        {
            //Write a method that takes an int and returns the factorial (!)
            Console.WriteLine("Enter an integer");
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"{n}! = {GetFactorial(n)}");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Take care of your values, again");
            }
            static int GetFactorial(int n)
            {
                int result=1;
                while (n > 0)
                {
                    result = result * n;
                    n--;
                }
                return result;
            }
        }

        static void ListAverage()
        {
            //Write a method that takes a list and returns the average of the numbers
            List<double> myList = new List<double> { };
            try
            {
                Console.WriteLine("Enter size of list");
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the values:");
                while (myList.Count < size)
                {
                    myList.Add(double.Parse(Console.ReadLine()));
                }
                Console.WriteLine($"The average of the items is = {GetAverage(myList)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("take care of your values");
            }

            static double GetAverage(List<double> myList)
            {
                double sum = 0;
                foreach(double item in myList)
                {
                    sum = sum + item;
                }
                return sum / myList.Count;
            }
        }
    }
}