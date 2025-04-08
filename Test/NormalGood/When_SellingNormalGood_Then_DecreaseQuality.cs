using GildedTros.App;

namespace Test.NormalGood;

public class When_SellingNormalGood_Then_DecreaseQuality
{
    [Fact]
    public void Test()
    {
        // Arrange
        IList<Item> items = new List<Item> { new() { Name = "Ring of Cleansening Code", SellIn = 10, Quality = 20 } };
        var gildedTrosInventory = new GildedTrosInventory(items);

        // Act
        for (var day = 0; day < 2; day++)
        {
            gildedTrosInventory.UpdateQuality();
        }

        // Assert
        Assert.Equal("Ring of Cleansening Code", items[0].Name);
        Assert.Equal(8, items[0].SellIn);
        Assert.Equal(18, items[0].Quality);
    }
}