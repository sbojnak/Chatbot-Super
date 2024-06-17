using System;
namespace Chat_Bot_Super.Topics
{
    public class DayOfTheWeek : ITopic
	{
        public string GetAnswer(string input)
        {
            
            if (!string.IsNullOrEmpty(input))
            {
                var question = input.ToLower();

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
    }
}