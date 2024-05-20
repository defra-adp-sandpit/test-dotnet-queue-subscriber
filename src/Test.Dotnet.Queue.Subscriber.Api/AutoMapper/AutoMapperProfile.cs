using Test.Dotnet.Queue.Subscriber.Api.Models;
using Test.Dotnet.Queue.Subscriber.Core.Entities;

using AutoMapper;

namespace Test.Dotnet.Queue.Subscriber.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
