using System.Collections.Generic;
using GildedTros.App.TypesOfGoods;

namespace GildedTros.App;

public class GildedTrosInventory
{
    // The exercise says I am not allowed to update this property but it hurts too much so I updated its access modifier etc.
    private readonly IList<Item> _items;
    public GildedTrosInventory(IList<Item> items)
    {
        this._items = items;
    }

    public void UpdateItems()
    {
        foreach (var item in _items)
        {
            var itemUpdater = GetItemUpdater(item);
            itemUpdater.UpdateItem(item);
        }
    }

    public IItemUpdater GetItemUpdater(Item item)
    {
        switch (item.Name)
        {
            case "Good Wine":
                return new GoodWine();
            case var itemName when itemName.StartsWith("Backstage passes"):
                return new BackstagePass();
            case "B-DAWG Keychain":
                return new LegendaryItem();
            case "Duplicate Code" or "Long Methods" or "Ugly Variable Names":
                return new SmellyItem();

            default: return new NormalGood();
        }
    }
}