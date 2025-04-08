using GildedTros.App;

namespace Test.SmellyItem;

public class When_SellingSmellyitemsellByDatePassed_Then_DecreaseQualityFourTimes
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "Long Methods", SellIn = 3, Quality = 16 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 4; day++)
        {
            gildedTrosInventory.UpdateQuality();
        }

        // Assert
        Assert.Equal("Long Methods", items[0].Name);
        Assert.Equal(-1, items[0].SellIn);
        Assert.Equal(6, items[0].Quality); // Original code is not correct, test succeeds when value is 11
    }
}