namespace GildedTros.App.TypesOfGoods;

public class GoodWine : IItemUpdater
{
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