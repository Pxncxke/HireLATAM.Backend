using AutoMapper;
using HireLATAM.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireLATAM.Application.Features.Queries.GetItems
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery, List<ItemDto>>
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public GetItemQueryHandler(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public async Task<List<ItemDto>> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            var inquiries = await _itemRepository.GetAsync();

            var dto = _mapper.Map<List<ItemDto>>(inquiries);

            return dto;
        }
    }
}
