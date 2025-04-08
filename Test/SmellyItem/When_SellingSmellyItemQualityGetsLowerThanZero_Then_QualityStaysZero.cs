using GildedTros.App;

namespace Test.SmellyItem;

public class When_SellingSmellyItemQualityGetsLowerThanZero_Then_QualityStaysZero
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "Long Methods", SellIn = 3, Quality = 16 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 10; day++)
        {
            gildedTrosInventory.UpdateItems();
        }

        // Assert
        Assert.Equal("Long Methods", items[0].Name);
        Assert.Equal(-7, items[0].SellIn);
        Assert.Equal(0, items[0].Quality);
    }
}