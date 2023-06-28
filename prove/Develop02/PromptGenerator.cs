using System.Collections.Generic;
public class PromptGenerator
{
    public string _prompt ;
    

public PromptGenerator(string prompt)
{
    _prompt= prompt;
    //_prompt.Add("Who was the most interesting person I interacted with today?");
    //_prompt.Add("What was the best part of my day?");
    //_prompt.Add("How did I see the hand of the Lord in my life today?");
    //_prompt.Add("What was the strongest emotion I felt today?");
    //_prompt.Add("If I had one thing I could do over today, what would it be?");
    //_prompt.Add("How was the day, good or not?");
}
public void DisplayGeneratePrompt()
{
    Console.WriteLine(_prompt);
}

}
