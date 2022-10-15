using AbcSoftwareWishList.Models;
using AbcWishList.Core.Helpers;

namespace AbcWishList.Tests;

public class ConvertersTests
{
    [Fact]
    public void GetNameStingFromUserList_PassListOfUsers_GetExpectedString()
    {
        // Arrange
        var users = new List<User>
        {
            new()
            {
                Type = "user",

                Id = 150709,

                Name = "johnsmith",

                Email = "jsmith@example.com"
            },
            new()
            {
                Type = "user",

                Id = 150710,

                Name = "angelinasmith",

                Email = "asmith@example.com"
            },
            new()
            {
                Type = "user",

                Id = 150910,

                Name = "adamivanov",

                Email = "aivanov@another.org"
            }
        };

        var expectedString = "johnsmith, angelinasmith, adamivanov";

        // Act
        var act = Converters.GetNameStringFromUserList(users);

        // Assert
        act.Should().Be(expectedString);
    }
}
