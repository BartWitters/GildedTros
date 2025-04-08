using GildedTros.App;

namespace Test.BackstagePass;

public class When_SellingBackstagePassSellByDatePassed_Then_QualityIsZero
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "Backstage passes for Re:factor", SellIn = 15, Quality = 20 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 16; day++)
        {
            gildedTrosInventory.UpdateItems();
        }

        // Assert
        Assert.Equal("Backstage passes for Re:factor", items[0].Name);
        Assert.Equal(-1, items[0].SellIn);
        Assert.Equal(0, items[0].Quality);
    }
}