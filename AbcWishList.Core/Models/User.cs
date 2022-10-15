using AbcWishList.Core.Models;

namespace AbcSoftwareWishList.Models;

public class User : Entity
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
