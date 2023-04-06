using System;

public class Damage
{
    public int _damage;
    public string _damageType;

    public virtual int GetDamage()
    {
        Console.WriteLine("By what numeral do you want to change the entity's hp (negative will deal damage, positive will heal)? ");
        _damage = Convert.ToInt32(Console.ReadLine());
        return _damage;
    }

    public string GetDamageType()
    {
        Console.WriteLine("What damage type is this damage?");
        _damageType = Console.ReadLine();
        return _damageType;

    }
}