namespace GildedTros.App.TypesOfGoods;

/// <summary>
/// SmellyItem is a smelly item that decreases in quality as it gets older.
/// </summary>
public class SmellyItem : IItemUpdater
{
    /// <summary>
    /// Update the item. The quality of a smelly item decreases by 2 before the sell date and by 4 after the sell date.
    /// </summary>
    /// <param name="item">The smelly item to be updated</param>
    public void UpdateItem(Item item)
    {
        item.SellIn--;
        item.Quality = item.SellIn >= 0 ? item.Quality - 2 : item.Quality - 4;

        if (item.Quality < 0)
        {
            item.Quality = 0;
        }
    }
}