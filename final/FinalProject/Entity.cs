using System;
using System.IO;

public class Entity
{
    public string _entityType;
    public string _entityName;
    public int _entityHealth;
    public List<string> _entityResistances;
    public List<string> _entityVulnerabilities;

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
    public void SaveEntity()
    {
        StreamWriter sw = new StreamWriter("entity.txt");
        sw.WriteLine($"{_entityName}:{_entityHealth}:{_entityType}");
        sw.Close();
    }
    public void EntityDeath()
    {

    }
    public void GetResistances()
    {
        Console.WriteLine("What damage types is this entity resistant to?");
        Console.WriteLine("1. Bludgeoning | 2. Piercing | 3. Slashing |\n4. Acid | 5. Poison | 6. Fire |\n7. Cold | 8. Force | 9. Lightning |\n10. Thunder | 11. Necrotic | 12. Psychic | \n13. Radiant |");
        
    }
    public void GetVulnerabilities()
    {
        
    }
}