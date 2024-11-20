using AutoMapper;
using Domain.CardGamesGuruMiniApp.Entities.TodEntities;
using Infrastructure.CardGamesGuruMiniApp.Models.TodModels;

//updating the infrastructure

namespace Infrastructure.CardGamesGuruMiniApp.Profiles
{
    public class TodProfile : Profile
    {
        public TodProfile()
        {
            CreateMap<TodBson, TodCard>();
            CreateMap<TodCard, TodBson>();
        }
    }
}
