using System;

public class Object : Entity
{
    public Object()
    {
        _entityType = "Object";
    }
    public override void EntityDeath()
    {
        Console.WriteLine($"The {_entityName} has been broken.");
        _entityAlive = false;
    }
}