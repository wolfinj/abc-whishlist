using AbcSoftwareWishList.Helpers;
using AbcSoftwareWishList.Models;
using AbcWishList.Core.Models;

namespace AbcWishList.Tests;

public class ConvertExtensionMethodsTests
{
    [Fact]
    public void ToItem_PassItemRequest_GetItem()
    {
        // Arrange
        var userRequest = new ItemRequest
        {
            Name = "",
            Url = "www.shop.com/product/224"
        };

        // Act
        var act = userRequest.ToItem();

        // Assert
        act.Should().BeOfType<Item>();
    }
}
