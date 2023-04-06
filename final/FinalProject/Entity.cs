using System;
using System.IO;

public class Entity
{
    public string _entityType;
    public string _entityName;
    public int _entityHealth;
    public bool _entityAlive = true;

    //creates a new entity
    public void CreateEntity()
    {
        int choice = 0;
        Console.WriteLine("What type of entity do you want to create?");
        Console.WriteLine("(1. Player | 2. Monster | 3. Object)");
        Console.Write("\nYour choice: ");
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            _entityType = "Player";
        }
        else if (choice == 2)
        {
            _entityType = "Monster";
        }
        else if (choice == 3)
        {
            _entityType = "Object";
        }
        Console.WriteLine("What is your entity's name? ");
        _entityName = Console.ReadLine();
        Console.WriteLine($"How much health does [the] {_entityName} have?");
        _entityHealth = Convert.ToInt32(Console.ReadLine());
    }
    // saves the entity and its traits to a txt file
    public void SaveEntity()
    {
        StreamWriter sw = new StreamWriter("entity.txt");
        sw.WriteLine($"{_entityName}:{_entityHealth}:{_entityType}:{_entityAlive}:");
        sw.Close();
    }
    // Checks the health of the entity to determine if it is alive
    public virtual void EntityDeath()
    {
        Console.WriteLine($"{_entityName} has died.");
        _entityAlive = false;
    }
}