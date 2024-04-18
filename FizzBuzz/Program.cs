namespace FizzBuzz
{
    internal class Program
    {
        ///*
        // when the number is divisible by 3 return the word fizz

        // when the number is divisible by 5 return the word buzz

        // when the number is divisible by both, return the word fizzbuzz
        //*/
        //public static string FizzBuzz (int num)
        //{
        //    if (num % 3 == 0 && num % 5 == 0)
        //    {
        //        return "FizzBuzz";
        //    } 
        //    else if (num % 3 == 0)
        //    {
        //        return "Fizz";
        //    } 
        //    else if (num % 5 == 0)
        //    {
        //        return "Buzz";
        //    }
        //    else
        //    {
        //        return "Not divisible by 3 and/or 5";
        //    }
        //}

        // First, we create a public static method outside of Main with a return type string that takes in a parameter type integer.

        // If the number is divisible by 3, which means the remainder will be zero when divided by 3, it will enter the first if statement. The string answer will take the value of "Fizz".

        // If the number is ONLY divisible by 3 and NOT divisible by 5, it will skip the second if statement which checks if the number is divisible by 5, and the function returns the string answer with "Fizz".
        
        // If the number is divisible BOTH by 3 and 5, after entering the first if statement, it will also enter the second if statement to check if the number is divisible by 5. The string answer will concatenate "Fizz" with "Buzz" to make "FizzBuzz" due to both the conditions are statisfied. The function returns the string answer with "FizzBuzz".

        // If the number is NOT divisible by 3 and is ONLY divisible by 5, it will skip the first if statement, enter the second if statement. The string answer will only take the value of "Buzz". The function returns the string answer with "Buzz".

        // If both the conditions are NOT statisfied, which means the number is neither divisible by 3 or 5, the function returns the string answer with "Neither divisible by 3 nor 5".


        public static string FizzBuzz(int num)
        {
            string answer = string.Empty;
            if (num % 3 == 0)
            {
                answer = "Fizz";
            }
            if (num % 5 == 0)
            {
                answer += "Buzz";
            }
            if (num % 3 != 0 && num % 5 != 0)
            {
                answer = "Neither divisible by 3 nor 5";
            }
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"{FizzBuzz(15)}"); // FizzBuzz
            Console.WriteLine($"{FizzBuzz(9)}");  // Fizz
            Console.WriteLine($"{FizzBuzz(10)}"); // Buzz
            Console.WriteLine($"{FizzBuzz(4)}");  // Neither divisible by 3 nor 5
        }
    }
}
