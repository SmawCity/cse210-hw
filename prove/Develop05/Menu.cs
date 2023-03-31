using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
#pragma warning disable SYSLIB0011

[Serializable]
public class Menu
{
    List<Goal> goals = new List<Goal>();
    private static int _userScore;
    public void ManageGoals()
    {
        
        int choice = 0;
        while (choice != 6)
        {
            DisplayScore();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoals();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
        }
        
    }
    public void CreateGoal()
    {
        Goal goal = new Goal();
        Console.Write("What is the goal you are setting? ");
        goal._goalName = Console.ReadLine();
        Console.Write("What type of goal?(Simple[1], Checklist[2], Eternal[3]) ");
        goal._goalType = Convert.ToInt32(Console.ReadLine());
        if (goal._goalType == 1)
        {
            goal._goalDuration = 1;
            Console.Write("How many points is this goal worth? ");
            goal._scoreGain = Convert.ToInt32(Console.ReadLine());
        }
        else if (goal._goalType == 2)
        {
            Console.Write("How many steps are there to your goal? ");
            goal._goalDuration = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many points do you earn per step? ");
            goal._incrementBonus = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many points do you earn when you complete your goal? ");
            goal._scoreGain = Convert.ToInt32(Console.ReadLine());
        }
        else if (goal._goalType == 3)
        {
            Console.Write("How many points do you earn per step? ");
            goal._incrementBonus = Convert.ToInt32(Console.ReadLine());
        }
        goals.Add(goal);
    }
    public void DisplayScore()
    {
        Console.WriteLine($"You have {_userScore} points.");
    }
    public void SaveGoals()
    {
        goals[0]._score = _userScore;
        Console.WriteLine("What file name do you want to save to? ");
        string _fileName = Console.ReadLine();
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream(_fileName, FileMode.Create, FileAccess.Write);
        formatter.Serialize(stream, goals);
        stream.Close();
    }
    public void LoadGoals()
    {
        Console.WriteLine("What file name do you want to load? ");
        string _fileName = Console.ReadLine();
        goals = new List<Goal>();

        FileStream fs = new FileStream(_fileName, FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();
        goals = (List<Goal>) formatter.Deserialize(fs);
        _userScore = goals[0]._score;
    }
    public void RecordEvent()
    {
        ListGoals();
        Console.Write("What goal did you accomplish? ");
        int _goalChoice = Convert.ToInt32(Console.ReadLine()) - 1;
        if (goals[_goalChoice]._goalType == 1)
        {
            _userScore += goals[_goalChoice]._scoreGain;
            Console.WriteLine($"Congratulations! You have earned {goals[_goalChoice]._scoreGain} points!");
            goals[_goalChoice]._goalProgress += 1;
        }
        else if (goals[_goalChoice]._goalType == 2)
        {
            if (goals[_goalChoice]._goalProgress != goals[_goalChoice]._goalDuration)
            {
                _userScore += goals[_goalChoice]._incrementBonus;
                Console.WriteLine($"Congratulations! You have earned {goals[_goalChoice]._incrementBonus} points!\nYou have completed {goals[_goalChoice]._goalProgress} steps out of {goals[_goalChoice]._goalDuration}");
                goals[_goalChoice]._goalProgress += 1;
            }
            else
            {
                _userScore += goals[_goalChoice]._scoreGain;
                Console.WriteLine($"Congratulations! You have earned {goals[_goalChoice]._scoreGain} points and completed your goal! ");
            }
        }
        else if (goals[_goalChoice]._goalType == 3)
        {
            _userScore += goals[_goalChoice]._incrementBonus;
            Console.WriteLine($"Congratulations! You have earned {goals[_goalChoice]._incrementBonus} points!");
            goals[_goalChoice]._goalProgress += 1;
        }
    }
    public void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]._goalName}");
        }
    }
}
