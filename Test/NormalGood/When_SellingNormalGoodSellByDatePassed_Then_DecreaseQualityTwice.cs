using GildedTros.App;

namespace Test.NormalGood;

public class When_SellingNormalGoodSellByDatePassed_Then_DecreaseQualityTwice
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "Ring of Cleansening Code", SellIn = 10, Quality = 20 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 12; day++)
        {
            gildedTrosInventory.UpdateQuality();
        }

        // Assert
        Assert.Equal("Ring of Cleansening Code", items[0].Name);
        Assert.Equal(-2, items[0].SellIn);
        Assert.Equal(6, items[0].Quality);
    }
}