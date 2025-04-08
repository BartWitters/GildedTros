namespace GildedTros.App.TypesOfGoods;

public class SmellyItem : IItemUpdater
{
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