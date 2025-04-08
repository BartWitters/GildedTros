using GildedTros.App;

namespace Test.SmellyItem;

public class When_SellingSmellyItem_Then_DecreaseQualityTwice
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "Long Methods", SellIn = 3, Quality = 16 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 2; day++)
        {
            gildedTrosInventory.UpdateItems();
        }

        // Assert
        Assert.Equal("Long Methods", items[0].Name);
        Assert.Equal(1, items[0].SellIn);
        Assert.Equal(12, items[0].Quality); // Original code is not correct, test succeeds when value is 14
    }
}