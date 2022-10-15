using AbcSoftwareWishList.Helpers;
using AbcSoftwareWishList.Models;
using AbcWishList.Core.Helpers;
using AbcWishList.Core.Models;
using AbcWishList.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace AbcSoftwareWishList.Controllers;

[ApiController, Route("api")]
public class ApiController : ControllerBase
{
    private readonly IEntityService<Item> _entityService;

    public ApiController(IEntityService<Item> context)
    {
        _entityService = context;
    }

    [HttpGet, Route("items")]
    public IActionResult GetAllItems()
    {
        var items = _entityService.GetAll();
        return Ok(items);
    }

    [HttpPost, Route("item")]
    public IActionResult PostItem(ItemRequest itemRequest)
    {
        if (!itemRequest.IsItemRequestDataValid())
        {
            return BadRequest("Item name can't be empty or null.");
        }

        var item = itemRequest.ToItem();

        _entityService.Create(item);

        var uri = $"{Request.Scheme}://{Request.Host}{Request.PathBase}{Request.Path}/{item.Id}";

        return Created(uri, item);
    }

    [HttpGet, Route("item/{id:int}")]
    public IActionResult GetItemById(int id)
    {
        var item = _entityService.GetById(id);

        return item == null ? NotFound($"Item with id:\"{id}\" not found.") : Ok(item);
    }

    [HttpDelete, Route("item/{id:int}")]
    public IActionResult DeleteItem([FromRoute] int id)
    {
        var item = _entityService.GetById(id);

        if (item == null)
        {
            return NotFound($"Item with id:\"{id}\" not found.");
        }

        _entityService.Delete(item);

        return Ok(item);
    }

    [HttpPut, Route("item/{id:int}")]
    public IActionResult UpdateItem([FromRoute] int id, [FromBody] ItemRequest itemRequest)
    {
        if (!itemRequest.IsItemRequestDataValid())
        {
            return BadRequest("Item name can't be empty or null.");
        }

        if (_entityService.Query().Any(i => i.Id == id))
        {
            var item = itemRequest.ToItem();

            item.Id = id;
            _entityService.Update(item);

            return Ok(item);
        }

        return NotFound($"Item with id:\"{id}\" not found.");
    }

    [HttpPost, Route("users")]
    public IActionResult GetUserNamesFromRequest([FromBody] UsersRequest users)
    {
        var userNames = Converters.GetNameStringFromUserList(users.users);

        return Ok(userNames);
    }
}
