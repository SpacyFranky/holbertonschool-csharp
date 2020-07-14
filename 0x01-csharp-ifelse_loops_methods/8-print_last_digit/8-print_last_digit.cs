using System;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)
        {
            if (number < 0)
                number = -number;
            Console.Write(number % 10);
            return(number % 10);
        }
    }
}
