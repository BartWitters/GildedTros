namespace GildedTros.App.TypesOfGoods;

/// <summary>
/// Good Wine is a special item that increases in quality as it gets older.
/// </summary>
public class GoodWine : IItemUpdater
{
    /// <summary>
    /// Update the item. The quality of Good Wine increases by 1 before the sell date and by 2 after the sell date.
    /// </summary>
    /// <param name="item">The Good Wine item to be updated</param>
    public void UpdateItem(Item item)
    {
        item.SellIn--;
        item.Quality = item.SellIn >= 0 ? item.Quality + 1 : item.Quality + 2;

        if (item.Quality >= 50)
        {
            item.Quality = 50;
        }
    }
}