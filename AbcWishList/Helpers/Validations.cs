using AbcSoftwareWishList.Models;

namespace AbcSoftwareWishList.Helpers;

public static class Validations
{
    public static bool IsItemRequestDataValid(this ItemRequest itemRequest)
    {
        var isValid = !string.IsNullOrEmpty(itemRequest.Name);

        return isValid;
    }
}
