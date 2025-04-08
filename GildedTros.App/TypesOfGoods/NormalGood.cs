namespace GildedTros.App.TypesOfGoods;

public class NormalGood : IItemUpdater
{
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