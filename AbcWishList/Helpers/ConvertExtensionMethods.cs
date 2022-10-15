using AbcSoftwareWishList.Models;
using AbcWishList.Core.Models;
using AutoMapper;

namespace AbcSoftwareWishList.Helpers;

public static class ConvertExtensionMethods
{
    private static IMapper _mapper => CreateMapper();

    public static IMapper CreateMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<ItemRequest, Item>()
                .ForMember(dest => dest.Id,
                    opt => opt.Ignore());
        });

        return config.CreateMapper();
    }

    public static Item ToItem(this ItemRequest itemRequest)
    {
        return _mapper.Map<Item>(itemRequest);
    }
}
