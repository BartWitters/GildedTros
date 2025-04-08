using System;
using System.Collections.Generic;

namespace GildedTros.App;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Gilded Tros simulation!");

        var numberOfDays = GetNumberOfDays(args);

        IList<Item> items = new List<Item>{
            new() {Name = "Ring of Cleansening Code", SellIn = 10, Quality = 20},
            new() {Name = "Good Wine", SellIn = 2, Quality = 0},
            new() {Name = "Elixir of the SOLID", SellIn = 5, Quality = 7},
            new() {Name = "B-DAWG Keychain", SellIn = 0, Quality = 80},
            new() {Name = "B-DAWG Keychain", SellIn = -1, Quality = 80},
            new() {Name = "Backstage passes for Re:factor", SellIn = 15, Quality = 20},
            new() {Name = "Backstage passes for Re:factor", SellIn = 10, Quality = 49},
            new() {Name = "Backstage passes for HAXX", SellIn = 5, Quality = 49},
            new() {Name = "Duplicate Code", SellIn = 3, Quality = 6},
            new() {Name = "Long Methods", SellIn = 3, Quality = 6},
            new() {Name = "Ugly Variable Names", SellIn = 3, Quality = 6}
        };

        var inventory = new GildedTrosInventory(items);

        ShowResult(inventory, items, numberOfDays);
    }

    private static int GetNumberOfDays(string[] args)
    {
        var inputNumberOfDays = (args.Length >= 1) ? args[0] : AskInput("Please enter the number of days:");

        int numberOfDays;
        while (!(int.TryParse(inputNumberOfDays, out numberOfDays) && numberOfDays > 0))
        {
            Console.WriteLine("The input \"" + inputNumberOfDays +
                              "\" is not valid, it should be an integer greater than 0! Please enter a correct number:");
            inputNumberOfDays = Console.ReadLine();
        }

        return numberOfDays;
    }

    private static string AskInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine() ?? throw new InvalidOperationException("Failed to read user input.");
    }

    private static void ShowResult(GildedTrosInventory inventory, IList<Item> items, int numberOfDays)
    {
        for (var i = 0; i < numberOfDays; i++)
        {
            Console.WriteLine("\n-------- Day " + i + " --------");
            Console.WriteLine($"|{"Name",-35}|{"SellIn",8}|{"Quality",8}|");
            Console.WriteLine("|-----------------------------------------------------|");

            foreach (var item in items)
            {
                Console.WriteLine($"|{item.Name,-35}|{item.SellIn,8}|{item.Quality,8}|");
            }

            inventory.UpdateItems();
        }
    }
}