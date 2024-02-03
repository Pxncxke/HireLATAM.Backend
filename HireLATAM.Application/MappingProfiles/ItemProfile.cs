using AutoMapper;
using HireLATAM.Application.Features.Commands.CreateItem;
using HireLATAM.Application.Features.Queries.GetItems;
using HireLATAM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireLATAM.Application.MappingProfiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<ItemDto, Item>().ReverseMap();
            CreateMap<CreateItemCommand, Item>().ReverseMap();
        }
    }
}
