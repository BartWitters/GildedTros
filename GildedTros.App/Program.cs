﻿using System;
using System.Collections.Generic;

namespace GildedTros.App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Name = "Ring of Cleansening Code", SellIn = 10, Quality = 20},
                new Item {Name = "Good Wine", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the SOLID", SellIn = 5, Quality = 7},
                new Item {Name = "B-DAWG Keychain", SellIn = 0, Quality = 80},
                new Item {Name = "B-DAWG Keychain", SellIn = -1, Quality = 80},
                new Item {Name = "Backstage passes for Re:factor", SellIn = 15, Quality = 20},
                new Item {Name = "Backstage passes for Re:factor", SellIn = 10, Quality = 49},
                new Item {Name = "Backstage passes for HAXX", SellIn = 5, Quality = 49},
                // these smelly items do not work properly yet
                new Item {Name = "Duplicate Code", SellIn = 3, Quality = 6},
                new Item {Name = "Long Methods", SellIn = 3, Quality = 6},
                new Item {Name = "Ugly Variable Names", SellIn = 3, Quality = 6}
            };

            var inventory = new GildedTrosInventory(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("\n-------- Day " + i + " --------");
                Console.WriteLine($"|{"Name",-35}|{"SellIn",8}|{"Quality",8}|");
                Console.WriteLine("|-----------------------------------------------------|");

                foreach (var item in Items)
                {
                    Console.WriteLine($"|{item.Name,-35}|{item.SellIn,8}|{item.Quality,8}|");
                }

                inventory.UpdateQuality();
            }
        }
    }
}
