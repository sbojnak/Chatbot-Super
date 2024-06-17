using System;

namespace Chat_Bot_Super.Topics
{
    public class Movies : ITopic
    {
        public string GetAnswer(string input)
        {
            return "Here's a list of the top ten movies of all time:\n" +
                "1. The Godfather (1972)\n" +
                "2. The Shawshank Redemption (1994)\n" +
                "3. Schindler's List (1993)\n" +
                "4. Raging Bull (1980)\n" +
                "5. Casablanca (1942)\n" +
                "6. Citizen Kane (1941)\n" +
                "7. Gone with the Wind (1939)\n" +
                "8. The Wizard of Oz (1939)\n" +
                "9. One Flew Over the Cuckoo's Nest (1975)\n" +
                "10. Lawrence of Arabia (1962)";
        }
    }
}
