public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        this.SetActivityName("Breathing Activity");
        this.SetActivityDescription("This activity help you relax by walking you " +
            "throuught breathing in and out slowly (You need 9 seconds per round) " +
            "Clear your mind and focus in your breathing");
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetActivityDuration();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);
        while (currentTime < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breth in ...");
            ShowCountDown(3, 250);
            Console.Write("Breth out slow ...");
            ShowCountDown(6);
            currentTime = DateTime.Now;
        }
        this.DisplayEndingMessage();
    }
}