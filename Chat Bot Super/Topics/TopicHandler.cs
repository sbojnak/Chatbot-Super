using System.Text;
using System.Text.RegularExpressions;

public static class TopicHandler
{
    public static readonly Dictionary<SupportedTopic, List<string>> ThemeStrings = new()
    {
        {
            SupportedTopic.DayInWeek, new List<string>
                { "day" }
        },
        {
            SupportedTopic.Weather, new List<string>
                { "weather" }
        },
        {
            SupportedTopic.Movies, new List<string>
                { "movie", "movies" }
        },
        {
            SupportedTopic.NumberSort, new List<string>
                { "sort", "numbers" }
        }
    };

    public static SupportedTopic? RecognizeTheme(string input)
    {
        var matchingEntries = ThemeStrings.Where(kvp => kvp.Value.Contains(input.ToLower())).ToList();
        return matchingEntries.FirstOrDefault().Key;
    }
    
    public static string GetTopTenMovies()
    {
        return "Here's a list of the top ten movies of all time: 1. The Godfather (1972), 2. The Shawmovieshank Redemption (1994), 3. Schindler's List(1993), 4. Raging Bull (1980), 5. Casablanca (1942), 6. Citizen Kane (1941), 7. Gone with the Wind(1939), 8. The Wizard of Oz (1939), 9. One Flew Over the Cuckoo's Nest (1975), 10. Lawrence of Arabia (1962)";
    }
    public static string ExtractAndSortIntegers(string input)
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
    
    public static string TalkDayInWeek(string? question)
    {
        if (!string.IsNullOrEmpty(question))
        {
            question = question.ToLower();
 
            if (question.Contains("today") && question.Contains("day"))
            {
                return "Chatbot: Today is " + DateTime.Now.ToString("dddd");
            }
            else if (question.Contains("yesterday") && question.Contains("day"))
            {
                return "Chatbot: Yesterday was " + DateTime.Now.AddDays(-1).ToString("dddd");
            }
            else if (question.Contains("tomorrow") && question.Contains("day"))
            {
                return "Chatbot: Tomorrow will be " + DateTime.Now.AddDays(1).ToString("dddd");
            }
            else
            {
                return "Chatbot: I'm sorry, I don't understand your question.";
            }
        }
        return "Chatbot: No input received.";
    }
    public static string GetDayFromQuestion(string question)
    {
        if (question.ToLower().Contains("yesterday"))
        {
            return GetWeatherYesterday();
        }
        else if (question.ToLower().Contains("today"))
        {
            return GetWeatherToday();
        }
        else if (question.ToLower().Contains("tomorrow"))
        {
            return GetWeatherTomorrow();
        }
        else
        {
            return "I don't understand your question about weather, please try asking again.";
        }
    }
 
    private static string GetWeatherYesterday()
    {
        return "Yesterday's weather was sunny with a high of 75°F and a low of 55°F.";
    }
    private static string GetWeatherToday()
    {
        return "Today's weather is partly cloudy with a high of 78°F and a low of 60°F.";
    }
    private static string GetWeatherTomorrow()
    {
        return "Tomorrow's weather will be rainy with a high of 70°F and a low of 50°F.";
    }
}

public enum SupportedTopic
{
    DayInWeek,
    Weather,
    Movies,
    NumberSort
}

