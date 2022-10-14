using System.ComponentModel.DataAnnotations;

namespace AbcWishList.Core.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
