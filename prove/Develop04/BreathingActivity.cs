using System;

public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void BreatheIn()
    {
        Console.WriteLine("Breathe in...");
        base.CountDownFrom(8);
        
    }

    public void BreatheOut()
    {
        Console.WriteLine("Breathe out...");
        base.CountDownFrom(12);
    }
}