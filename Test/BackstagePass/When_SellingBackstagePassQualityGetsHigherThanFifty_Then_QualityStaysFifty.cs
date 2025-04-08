using GildedTros.App;

namespace Test.BackstagePass;

public class When_SellingBackstagePassQualityGetsHigherThanFifty_Then_QualityStaysFifty
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "Backstage passes for Re:factor", SellIn = 10, Quality = 49 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 3; day++)
        {
            gildedTrosInventory.UpdateQuality();
        }

        // Assert
        Assert.Equal("Backstage passes for Re:factor", items[0].Name);
        Assert.Equal(7, items[0].SellIn);
        Assert.Equal(50, items[0].Quality);
    }
}