using SystemInformationTracker;

const int countdownTime = 60;
const int delayBetweenRepeats = 5;

while (true)
{
    Console.Clear();
    Countdown(countdownTime);
    SystemInformation.GetSystemInformation();
    Console.WriteLine($"Waiting {delayBetweenRepeats} seconds before the next repetition...\n\n");
    Thread.Sleep(delayBetweenRepeats * 1000);
}

static void Countdown(int seconds)
{
    for (int i = seconds; i >= 0; i--)
    {
        Console.Clear();
        Console.WriteLine($"Time remaining: {i} seconds");
        Thread.Sleep(1000);
    }

    Console.WriteLine("Countdown finished!\n\n");
}
