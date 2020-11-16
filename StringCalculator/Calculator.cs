using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
   public static class Calculator
    {
        public static int Add(string numbers)
        {
            int number = 0;

            if (String.IsNullOrEmpty(numbers))
            {
                return number;
            }

            string[] split_numbers = numbers.Split(",");
            if (split_numbers.Length > 1)
            {
                foreach (string numb in split_numbers)
                {
                    number += Int32.Parse(numb);
                }
            }
            else
            {

                try
                {
                    number = Int32.Parse(numbers);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            return number;
        }
    }
}
