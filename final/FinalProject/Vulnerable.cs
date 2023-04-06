using System;

public class Vulnerable : Damage
{
    
    public override int GetDamage()
    {
        Console.WriteLine("By what numeral do you want to change the entity's hp (negative will deal damage, positive will heal)? ");
        _damage = Convert.ToInt32(Console.ReadLine());
        _damage = _damage*2;
        return _damage;
    }
}