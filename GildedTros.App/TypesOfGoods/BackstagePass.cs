namespace GildedTros.App.TypesOfGoods;

/// <summary>
/// Represents a Backstage Pass item in the Gilded Tros inventory.
/// </summary>
public class BackstagePass : IItemUpdater
{
    /// <summary>
    /// Update the Backstage Pass item. The quality of a Backstage Pass increases as the sell date approaches.
    /// </summary>
    /// <param name="item">The BackstagePass item to be updated</param>
    public void UpdateItem(Item item)
    {
        item.SellIn--;

        switch (item.SellIn)
        {
            case >= 10:
                item.Quality++;
                break;
            case >= 5:
                item.Quality += 2;
                break;
            case >= 0:
                item.Quality += 3;
                break;
            default:
                item.Quality = 0;
                break;
        }

        if (item.Quality > 50)
        {
            item.Quality = 50;
        }
    }
}