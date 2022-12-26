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
            //ListAverage();
            //FindBiggestNumber();
            //GetPersonsAge();
            //FizzBuzz();
            //ReverseList();
            //OrderListBySize();
            FirstStringLetter();
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
            }
            catch (Exception ex)
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

            Console.WriteLine($"The longest is: {ReturnLongestString(s1, s2)}");

            static string ReturnLongestString(string s1, string s2)
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You sure entered a text, very funny");
            }

            static double CalcHypotenuse(double c1, double c2)
            {
                return Math.Sqrt(c1 * c1 + c2 * c2);
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

            //Write a method that returns the product of the items inside a double List

            List<double> myList = ListToDouble(CreateList());

            if (myList.Count > 0) Console.WriteLine($"The product of the items is = {ListProduct(myList)}");

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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Take care of your values, again");
            }
            static int GetFactorial(int n)
            {
                int result = 1;
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
            List<double> myList = ListToDouble(CreateList());

            if (myList.Count > 0) Console.WriteLine($"The average of the items is = {GetAverage(myList)}");

            static double GetAverage(List<double> myList)
            {
                double sum = 0;
                foreach (double item in myList)
                {
                    sum = sum + item;
                }
                return sum / myList.Count;
            }
        }

        static void FindBiggestNumber()
        {
            //Write a method that takes a list of numbers and returns the biggest of them
            List<double> myList = ListToDouble(CreateList());

            if (myList.Count > 0) Console.WriteLine($"The biggest number of the list is = {GetBiggestNumber(myList)}");

            static double GetBiggestNumber(List<double> myList)
            {
                double max = myList[0];
                foreach (double item in myList)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }

        static void GetPersonsAge()
        {
            //Write a method that receives a Datetime with the birthday of a person and returns its age

            try
            {
                Console.WriteLine("Enter year");
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter month");
                int m = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter day");
                int d = int.Parse(Console.ReadLine());

                Console.WriteLine($"You are {GetAge(new DateTime(y, m, d))} years old");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Take care of your values");
            }

            static int GetAge(DateTime birthday)
            {
                int time_diff = DateTime.Now.Year - birthday.Year;
                return time_diff;
            }
        }

        static void FizzBuzz()
        {
            //Write a fizzbuzz (print Fizz every 3 multiple and Buzz every 5 multiple)
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
            }
        }

        static void ReverseList()
        {
            //Write a method that takes a list and returns it reversed
            List<string> myList = CreateList();

            if (myList.Count > 0) Console.WriteLine(String.Join(",", GetListReversed(myList)));

            static List<string> GetListReversed(List<string> myList)
            {
                string tmp;
                for (int i = 0; i <= (myList.Count - 1) / 2; i++)
                {
                    tmp = myList[myList.Count - 1 - i];
                    myList[myList.Count - 1 - i] = myList[i];
                    myList[i] = tmp;
                }
                return myList;
            }
        }

        static void OrderListBySize()
        {
            //Create a method that takes a list of numbers and returns a list with the same numbers but from the smallest to the greatest
            List<double> myList = ListToDouble(CreateList());

            if (myList.Count > 0) Console.WriteLine(String.Join(",", GetSortedListByHand(myList)));

            //static List<double> GetSortedList(List<double> myList)
            //{
            //    myList.Sort();
            //    return myList;
            //}

            static List<double> GetSortedListByHand(List<double> myList)
            {
                List<double> myListSorted = new List<double> { };
                int size = myList.Count;
                double min;
                for (int i = 0; i < size; i++)
                {
                    min = myList[0];
                    foreach (double item in myList)
                    {
                        if (item < min)
                        {
                            min = item;
                        }
                    }
                    myListSorted.Add(min);
                    myList.Remove(min);
                }
                return myListSorted;
            }
        }

        static void FirstStringLetter()
        {
            Console.WriteLine("Write something");
            string str = Console.ReadLine();
            Console.WriteLine($"The first letter of {str} is {str.Substring(0,1)}");
        }

        //Method for creating List from input and convert it to double List
        static List<string> CreateList()
        {
            List<string> myList = new List<string> { };
            try
            {
                int size;
                do
                {
                    Console.WriteLine("Enter size of list");
                    size = int.Parse(Console.ReadLine());
                } while (size < 0);
                Console.WriteLine("Enter the values:");
                while (myList.Count < size)
                {
                    myList.Add(Console.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("take care of your values");
            }
            return myList;
        }

        static List<double> ListToDouble(List<string> myList)
        {
            List<double> myDoubleList = new List<double> { };
            try
            {
                myList.ForEach(delegate (string item)
                {
                    myDoubleList.Add(double.Parse(item));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Not all the items can be converted to double");
            }
            return myDoubleList;
        }

        //static List<int> ListToInt(List<string> myList)
        //{
        //    List<int> myIntList = new List<int> { };
        //    try
        //    {
        //        myList.ForEach(delegate (string item)
        //        {
        //            myIntList.Add(int.Parse(item));
        //        });
        //    }catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("Not all items could be converted to int");
        //    }

        //    return myIntList;
        //}
    }
}