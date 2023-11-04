using AutoMapper;
using SearchService.Consumers;
using SearchService.Models;
using Contracts;
namespace SearchService;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<AuctionCreated,Item>();
        CreateMap<AuctionCreated,Item>();
    }
}
