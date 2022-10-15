using AbcSoftwareWishList.Models;

namespace AbcWishList.Core.Helpers;

public static class Converters
{
    public static string GetNameStringFromUserList(IEnumerable<User> users)
    {
        return string.Join(", ", users.Select(u => u.Name));
    }
}
