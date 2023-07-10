public class ListingActivity : Activity
{
    private int _pTrack = 0;
    private List<string> _prompts = new List<string>() {
        " ----- Who are people that you appreciate?  ----- ",
        " ----- What are personal strengths of yours?  ----- ",
        " ----- Who are people that you have helped this week?  ----- ",
        " ----- When have you felt the Holy Ghost this month?  ----- ",
        " ----- Who are some of your personal heroes? -----  "
    };

    private List<string> rPrompts = new List<string>();
    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetActivityDescription(
            "This activity will help you reflect on the good things in your life " +
            "by having you list as many thing as you can in a certain area" +
            "Clear your mind and focus in your breathing");
        rPrompts = ReorderList(_prompts);
    }
    public void Run()
    {
        
        DisplayStartingMessage();
        int counter = 0;
        int duration = GetActivityDuration();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);
        // Console.WriteLine(currentTime);
        DisplayPrompt();
        while (currentTime < futureTime)
        {
            Console.ReadLine();
            currentTime = DateTime.Now;
            counter ++;
        }
        Console.WriteLine($"You listed {counter} items");
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
    public void DisplayPrompt() {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in :");
        ShowCountDown(5);  
    }
}