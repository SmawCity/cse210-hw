using System;

public class Player : Entity
{
    int _deathSaveSuccesses;
    int _deathSaveFailures;

    public Player()
    {
        _entityType = "Player";
    }
    public override void EntityDeath()
    {
        string input;
        Console.WriteLine($"{_entityName} has been knocked unconcious! \nPress enter to roll death saving throws to determine their fate! ");
        while (_deathSaveSuccesses != 3 & _deathSaveFailures != 3)
        {
            input = Console.ReadLine();
            Random random = new Random();
            int randomNumber = random.Next(1, 20);
            Console.WriteLine($"Death Saving Throw: {randomNumber}");
            if (randomNumber < 10)
            {
                _deathSaveFailures += 1;
            }
            else
            {
                _deathSaveSuccesses += 1;
            }
        }
        if (_deathSaveFailures == 3)
        {
            Console.WriteLine($"{_entityName} has died.");
            _entityAlive = false;
        }
        else if (_deathSaveSuccesses == 3)
        {
            Console.WriteLine($"{_entityName} lives on!");
        }
    }
}