public class ReflectingActivity : Activity
{
    private List<string> qRandom = new List<string>();
    private List<string> rPrompts = new List<string>();
    private int _qTrack = 0;
    private int _pTrack = 0;
    private List<string> _prompts = new List<string> {
        "\n --- Think a time when you did something really dificult. ---",
        "\n --- Think the last time you do the best to press forward. ---",
        "\n --- Think of a time when you helped someone in need ---",
        "\n --- Remember the best adventure you have had in the past year ---",
        "\n --- Think of a time when you did something truly selfless. ---"
    };
    private List<string> _questions = new List<string> {
        "> How did you feel when it was complete? ",
        "> Why was this experience meaningful to you? ",
        "> Have you ever done anything like this before? ",
        "> How did you get started? ",
        "> How did you feel when it was complete? ",
        "> What made this time different than other times when you were not as successful? ",
        "> What is your favorite thing about this experience? ",
        "> What could you learn from this experience that applies to other situations? ",
        "> What did you learn about yourself through this experience? ",
        "> How can you keep this experience in mind in the future? "
    };
    public ReflectingActivity()
    {
        this.SetActivityName("Reflecting Activity");
        this.SetActivityDescription(
            "This activity help you reflect on times in your live " +
            "when you have show strength and resilience." +
            " This will help you recognize the power you have and " +
            " how you can use it in other aspects of your life.");       
        qRandom = ReorderList(_questions);
        rPrompts = ReorderList(_prompts); 
    }    
    public void Run()
    {
        // qRandom = ReorderQuestions();
        DisplayStartingMessage();
        int duration = GetActivityDuration();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);
        // Console.WriteLine(currentTime);
        DisplayPrompt();
        while (currentTime < futureTime)
        {
            DisplayQuestion();
            currentTime = DateTime.Now;
        }
        // Console.WriteLine(DateTime.Now);
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        
        // int promptSize = _prompts.Count();
        // Random r = new Random();
        // int i = r.Next(promptSize -1);
        // return rPrompts[i];
        int pTemp = _pTrack;
        _pTrack ++;
        return _prompts[pTemp];
    }
    public string GetRandomQuestion(){
        // Console.WriteLine();
        // int qSize = _questions.Count();
        // Random r = new Random();
        // int i = r.Next(qSize -1);
        // return _questions[i];

        // questions were reordered at the beginning
        int qTemp = _qTrack;
        _qTrack ++;
        return _questions[qTemp];
    }
    public void DisplayPrompt() {
        Console.Write("\nConsider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("\nWhen you have somthing in mind, press [ENTER] to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience \n");
        ShowCountDown(3);  
    }
    public void DisplayQuestion() {
        // Console.Clear();
        if (_qTrack < _questions.Count)
        {
            Console.Write(GetRandomQuestion());  
            ShowCountDown(5); 
        } else {
            Console.Write("All the questions was displayed!");
            _qTrack = 0;
        }
    }

    // public List<string> ReorderQuestions() {
    //     List<string> qRandom = new List<string>();
    //     qRandom = _questions;
    //     Random random = new Random();

    //     for (int i = qRandom.Count -1; i > 0; i--)
    //     {
    //         int j = random.Next(i + 1);
    //         string temp = qRandom[i];
    //         qRandom[i] = qRandom[j];
    //         qRandom[j] = temp;
    //     }
    //     return qRandom;
    // }
}