﻿namespace Chat_Bot_Super.Topics;

public class ConsoleInputHandler : IInputHandler
{
    public string GetUserInput()
    {
        Console.WriteLine("What can I do for you?");
        string input;
        do
        {
            input = Console.ReadLine();
        } while (string.IsNullOrEmpty(input));

        return input;
    }
}