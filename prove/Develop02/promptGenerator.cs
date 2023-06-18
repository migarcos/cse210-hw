using System;

class promptGenerator {
    List<string> _question;

    public promptGenerator(){
        _question = new List<string>
        {
            "What is a blessing that you saw this day? ",
            "Who helped you or who did you help today? ",
            "What is the task you finished today? ",
            "What was the news on this day? ",
            "What would you like to remember? ",
            "What scripture do you read? ",
            "What did you learn today? ",
            "What person's name came to your mind? "
        };
    }

    public string GetRandomPrompt()
    {
        Random randNumber = new Random();
        int index = randNumber.Next(_question.Count);  
        string promptQuestion = _question[index];

        Console.WriteLine($"{promptQuestion}");

        return promptQuestion;
    }
    
}