using System;
using System.Collections.Generic;

namespace GildedTros.App;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Gilded Tros simulation!");

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


        for (var i = 0; i < 31; i++)
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