using GildedTros.App;

namespace Test.GoodWine;

public class When_SellingGoodWineSellByDatePassed_Then_IncreaseQualityTwice
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "Good Wine", SellIn = 2, Quality = 0 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 3; day++)
        {
            gildedTrosInventory.UpdateItems();
        }

        // Assert
        Assert.Equal("Good Wine", items[0].Name);
        Assert.Equal(-1, items[0].SellIn);
        Assert.Equal(4, items[0].Quality);
    }
}