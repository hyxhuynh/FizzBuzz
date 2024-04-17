namespace FizzBuzz
{
    internal class Program
    {
        /*
         when the number is divisible by 3 return the word fizz

         when the number is divisible by 5 return the word buzz

         when the number is divisible by both, return the word fizzbuzz
        */
        public static string FizzBuzz (int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            } 
            else if (num % 3 == 0)
            {
                return "Fizz";
            } 
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return "Not divisible by 3 and/or 5";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"{FizzBuzz(15)}"); // FizzBuzz
            Console.WriteLine($"{FizzBuzz(9)}");  // Fizz
            Console.WriteLine($"{FizzBuzz(10)}"); // Buzz
            Console.WriteLine($"{FizzBuzz(4)}");  // Not divisible by 3 and/or 5
        }
    }
}
