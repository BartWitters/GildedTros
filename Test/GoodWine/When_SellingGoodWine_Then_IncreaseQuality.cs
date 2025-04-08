using GildedTros.App;

namespace Test.GoodWine;

public class When_SellingGoodWine_ThenIncreaseQuality
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "Good Wine", SellIn = 2, Quality = 0 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 2; day++)
        {
            gildedTrosInventory.UpdateQuality();
        }

        // Assert
        Assert.Equal("Good Wine", items[0].Name);
        Assert.Equal(0, items[0].SellIn);
        Assert.Equal(2, items[0].Quality);
    }
}