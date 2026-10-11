using System;
using System.Collections.Generic;

public class Program
{
    public static void AskToExit()
    {
        Console.WriteLine();
        Console.WriteLine("Exit? Y/N");
        string answer = Console.ReadLine();

        if (answer == "Y" || answer == "y")
        {
            Environment.Exit(0);
        }
        else if (answer == "N" || answer == "n")
        {
            return;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid entry, please enter Y/N");
        }
    }

    public static void ShowMenu(List<string> foods)
    {
        Console.WriteLine("Menu: ");
        int count = 1;

        foreach (string food in foods)
        {
            Console.WriteLine($"{count}.{food}");
            count++;
        }
    }

    public static void Main()
    {
        Console.WriteLine("Restaurant Manager Menu: ");
        Console.WriteLine();

        List<string> foods = new List<string>();

        while (true)
        {
            Console.WriteLine("What do you want to do?: ");
            Console.WriteLine("1. Add a food to the menu");
            Console.WriteLine("2. Remove a food from the menu");
            Console.WriteLine("3. Edit food");
            Console.WriteLine("4. Show Menu");
            Console.WriteLine("5. Exit");
            string action = Console.ReadLine();

            if (!int.TryParse(action, out int num))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter one of the displayed numbers (1-5).");
                continue;
            }

            else if (num == 1)
            {
                Console.WriteLine("Enter food to add to the menu:");
                string food = Console.ReadLine();

                foods.Add(food);
                Console.WriteLine($"{food} was added to the menu");
            }

            else if (num == 2 && foods.Count != 0)
            {
                ShowMenu(foods);

                Console.WriteLine("Select food to remove from menu: ");
                string RemoveFood = Console.ReadLine();

                if (!int.TryParse(RemoveFood, out int removefood))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Invalid Input, please choose from the options (1 - {foods.Count}) ");
                }
                else
                {
                    if (removefood >= 1 && removefood <= foods.Count)
                    {
                        Console.WriteLine($"{foods[removefood - 1]} has been removed");
                        foods.RemoveAt(removefood - 1);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("That number isn't on the menu, please try again");
                    }
                }
            }
            else if (num == 2 && foods.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There is nothing on the menu to remove, please try again");
            }
            else if (num == 3)
            {
                if (foods.Count == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("There is nothing on the menu to edit, please try again");
                }
                else
                {
                    ShowMenu(foods);
                    Console.WriteLine("Select food to edit: ");

                    string EditFood = Console.ReadLine();
                    if (!int.TryParse(EditFood, out int editfood))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Invalid. Please enter a food on the menu");
                    }
                    else
                    {
                        if (editfood >= 1 && editfood <= foods.Count)
                        {
                            Console.WriteLine($"Change {foods[editfood - 1]} to?: ");
                            string updatefood = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine($"{foods[editfood - 1]} is now {updatefood}");

                            foods[editfood - 1] = updatefood;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("That number isn't on the menu, please try again");
                        }
                    }
                }
            }
            else if (num == 4)
            {
                if (foods.Count != 0);
                {
                ShowMenu(foods);
                }
                else
                {
                     Console.WriteLine("Menu: ");
                    int count = 1;
    
                    foreach (string food in foods)
                    {
                        Console.WriteLine($"{count}.{food}");
                        count++;
                    }
                }
            }
            else if (num == 5)
            {
                AskToExit();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid entry, please try again");
            }
        }
    }
}
