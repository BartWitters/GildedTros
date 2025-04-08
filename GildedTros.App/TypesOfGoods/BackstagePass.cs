namespace GildedTros.App.TypesOfGoods;

public class BackstagePass : IItemUpdater
{
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