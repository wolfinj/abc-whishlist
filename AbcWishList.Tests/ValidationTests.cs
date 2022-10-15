using AbcSoftwareWishList.Helpers;
using AbcSoftwareWishList.Models;

namespace AbcWishList.Tests;

public class ValidationTests
{
    [Fact]
    public void IsItemRequestDataValid_PassValidData_ExpectToBeTrue()
    {
        // Arrange
        var userRequest = new ItemRequest
        {
            Name = "Product",
            Url = "www.shop.com/product/224"
        };

        // Act 
        var act = userRequest.IsItemRequestDataValid();

        // Assert
        act.Should().BeTrue();
    }

    [Fact]
    public void IsItemRequestDataValid_PassDataWithEmptyName_ExpectToBeFalse()
    {
        // Arrange
        var userRequest = new ItemRequest
        {
            Name = "",
            Url = "www.shop.com/product/224"
        };

        // Act
        var act = userRequest.IsItemRequestDataValid();

        // Assert
        act.Should().BeFalse();
    }
}
