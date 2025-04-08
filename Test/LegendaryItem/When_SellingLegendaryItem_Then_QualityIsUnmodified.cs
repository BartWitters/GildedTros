using GildedTros.App;

namespace Test.LegendaryItem;

public class When_SellingLegendaryItem_Then_QualityIsUnmodified
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "B-DAWG Keychain", SellIn = -1, Quality = 80 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 6; day++)
        {
            gildedTrosInventory.UpdateItems();
        }

        // Assert
        Assert.Equal("B-DAWG Keychain", items[0].Name);
        Assert.Equal(-1, items[0].SellIn);
        Assert.Equal(80, items[0].Quality);
    }
}