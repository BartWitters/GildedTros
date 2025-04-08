namespace GildedTros.App.TypesOfGoods;

/// <summary>
/// NormalGood is a normal item that decreases in quality as it gets older.
/// </summary>
public class NormalGood : IItemUpdater
{
    /// <summary>
    /// Update the item. The quality of a normal good decreases by 1 before the sell date and by 2 after the sell date.
    /// </summary>
    /// <param name="item">The normal good item to be updated</param>
    public void UpdateItem(Item item)
    {
        item.SellIn--;
        item.Quality = item.SellIn >= 0 ? item.Quality - 1 : item.Quality - 2;

        if (item.Quality < 0)
        {
            item.Quality = 0;
        }
    }
}