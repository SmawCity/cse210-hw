using System;

public class Activity
{
    public string _activityName;
    public string _description;
    public int _duration;

    public Activity()
    {
        _activityName = "";
        _description = "";
    }
    public void SetDurationFromInput()
    {
        Console.WriteLine("How long do you want to spend on the activity (in seconds)? ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }
    public void StartActivity(string _activityTitle, string _activityDescription, int _activityDuration)
    {
        Console.WriteLine("Activity: " + _activityTitle);
        Console.WriteLine("Description: " + _activityDescription);
        Console.WriteLine("Duration: " + _activityDuration);
        LoadingScreen(6);
    }
    public void CountDownFrom(int _countdown)
    {
        for (int i = 0; i < _countdown; i++)
        {
            Console.WriteLine(_countdown - i);
            Thread.Sleep(1000);
        }
    }
    public void LoadingScreen(int _loadingTime)
    {
        for (int j = 0; j < _loadingTime; j++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            if ((j+1) % 3 == 0)
            {
                Console.WriteLine("");
            }
        }
        Console.WriteLine("");
    }
    public void EndMessage()
    {
        Console.WriteLine($"Thank you for participating in the {_activityName} activity for {_duration} seconds.");
        LoadingScreen(6);
    }
}