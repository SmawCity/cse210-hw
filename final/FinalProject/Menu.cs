using System;
using System.IO;

public class Menu
{
    Damage damage = new Damage();
    Resistance resistance = new Resistance();
    Vulnerable vulnerable = new Vulnerable();
    public void EntityMenu()
    {
        List<string> _names = new List<string>();
        List<int> _health = new List<int>();
        List<string> _types = new List<string>();
        List<bool> _alive = new List<bool>();
        int count = 0;

        using (StreamReader sr = new StreamReader("entity.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                if (count % 4 == 1)
                {
                    _names.Add(parts[0]);
                }
                else if (count % 4 == 2)
                {
                    int value;
                    if (int.TryParse(parts[1], out value))
                    {
                        _health.Add(value);
                    }
                }
                else if (count % 4 == 3)
                {
                    _types.Add(parts[2]);
                }
                else if (count % 4 == 0)
                {
                    bool boolValue;
                    if (bool.TryParse(parts[3], out boolValue))
                    {
                        _alive.Add(boolValue);
                    }
                }
                count++;
            }
        }
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Create New Entity");
            Console.WriteLine("\t2. Display Entities");
            Console.WriteLine("\t3. Heal/Deal Damage");
            Console.WriteLine("\t4. Quit");
            Console.Write("Your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Entity entity = new Entity();
                entity.CreateEntity();
                entity.SaveEntity();
            }
            else if (choice == 2)
            {
                DisplayEntities();
            }
            else if (choice == 3)
            {
                StreamWriter sw = new StreamWriter("entity.txt");
                int change = 0;
                Console.WriteLine("Which entity do you want to heal/damage? ");
                string nameChoice = Console.ReadLine();
                Console.WriteLine("Are they resistant, vulnerable, or neither (r/v/n) to this damage type? ");
                string resChoice = Console.ReadLine();
                if (resChoice == "n")
                {
                    change = damage.GetDamage();
                }
                else if (resChoice == "r")
                {
                    change = resistance.GetDamage();
                }
                else if (resChoice == "v")
                {
                    change = vulnerable.GetDamage();
                }
                for (int i = 0; i < _names.Count(); i++)
                {
                    if (nameChoice == _names[i])
                    {
                        _health[i] = _health[i] + change;
                    }
                }
                //for (int i = 0; i < _names.Count(); i++)
                //{
                //    sw.WriteLine($"{_names[i]}:{_health[i]}:{_types[i]}:{_alive[i]}:");
                //}
                //sw.Close();
            }
        }
    }
    private void DisplayEntities()
    {
        string line;
        StreamReader sr = new StreamReader("entity.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }   
        sr.Close();
    }
}