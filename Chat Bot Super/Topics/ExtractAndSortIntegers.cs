using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Chat_Bot_Super.Topics
{
    public class ExtractAndSortIntegers : ITopic
    {
        public string GetAnswer(string input)
        {           
            string pattern = @"[,\s;]+";
            string[] parts = Regex.Split(input, pattern);
            List<int> numbers = new List<int>();

            foreach (string part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    numbers.Add(number);
                }
            }

            if (!numbers.Any()) Console.WriteLine("There are no whole numbers to sort, please try again.");
            numbers.Sort();

            var sb = new StringBuilder();
            sb.AppendLine("Ordered integers:");
            foreach (int number in numbers)
            {
                sb.AppendLine(number.ToString());
            }

            return sb.ToString();           
        }
    }
}

