using AutoMapper;
using HireLATAM.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireLATAM.Application.Features.Commands.CreateItem
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public CreateItemCommandHandler(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }
        public async Task<Unit> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateItemCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                string message = string.Empty;
                foreach(var error in validationResult.Errors)
                {
                    message += error + "\n";
                }
                throw new Exception(message);
            }

            var inquiry = _mapper.Map<Domain.Models.Item>(request);

            await _itemRepository.CreateAsync(inquiry);

            return Unit.Value;
        }
    }
}
