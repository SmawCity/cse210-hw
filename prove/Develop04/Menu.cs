using System;

public class Menu
{
    public void GetActivity()
    {
        int choice = 0;
        Console.WriteLine("Hello! Welcome to the Mindfulness Activities Program. Which activity would you like to do?");
        Console.WriteLine("0. Quit Program");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.Write("Your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            BreathingActivity activity = new BreathingActivity();
            activity.SetDurationFromInput();
            activity.StartActivity(activity._activityName, activity._description, activity._duration);
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(activity._duration);
            
            while(startTime < futureTime)
            {
                activity.BreatheIn();
                activity.BreatheOut();
                startTime = DateTime.Now;
            }
            activity.EndMessage();
        }
        if (choice == 2)
        {
            ReflectingActivity activity = new ReflectingActivity();
            activity.SetDurationFromInput();
            activity.StartActivity(activity._activityName, activity._description, activity._duration);
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(activity._duration);
            activity.GetRandomPrompt();

            while(startTime < futureTime)
            {
                activity.GetRandomQuestion();
                Thread.Sleep(10000);
                startTime = DateTime.Now;
            }
            activity.EndMessage();
        }
        if (choice == 3)
        {
            ListingActivity activity = new ListingActivity();
            activity.SetDurationFromInput();
            activity.StartActivity(activity._activityName, activity._description, activity._duration);
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(activity._duration);
            activity.GeneratePrompt();

            // Allows the user to finish writing down their next item before cutting them off
            while(startTime < futureTime)
            {
                activity.UserListsItems();
                startTime = DateTime.Now;
            }
            activity.DisplayNumItems();
            activity.EndMessage();
        }
    }
}