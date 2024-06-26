﻿using System;

namespace Chat_Bot_Super.Topics
{
    /// <summary>
    /// The Weather class implements the ITopic interface and provides weather information for yesterday, today, and tomorrow.
    /// It contains private methods that take the string input and returns the corresponding weather information based on keywords "yesterday", "today", or "tomorrow".
    /// If the input doesn't contain these keywords, it returns a message indicating that the input is not understood.
    /// </summary>
    public class Weather : ITopic
    {
        private string GetWeatherYesterday()
        {
            return "Yesterday's weather was sunny with a high of 75°F and a low of 55°F.";
        }
        private string GetWeatherToday()
        {
            return "Today's weather is partly cloudy with a high of 78°F and a low of 60°F.";
        }
        private string GetWeatherTomorrow()
        {
            return "Tomorrow's weather will be rainy with a high of 70°F and a low of 50°F.";
        }

        public string GetAnswer(string input)
        {
            if (input.ToLower().Contains("yesterday"))
            {
                return GetWeatherYesterday();
            }
            else if (input.ToLower().Contains("today"))
            {
                return GetWeatherToday();
            }
            else if (input.ToLower().Contains("tomorrow"))
            {
                return GetWeatherTomorrow();
            }
            else
            {
                return "I don't understand your question about the weather, try asking again about the weather for yesterday, today or tomorrow.";
            }
        }
    }
}
