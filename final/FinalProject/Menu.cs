using System;

public class Menu
{

    public void EntityMenu()
    {
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
            }
            else if (choice == 2)
            {
                DisplayEntities();
            }
        }
    }
    public void DisplayEntities()
    {

    }
}