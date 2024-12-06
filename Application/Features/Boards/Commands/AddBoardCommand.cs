using Application.Common.Interfaces.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Net.Http.Metrics;

namespace Application.Features.Boards
{
    public class AddBoardCommand : IRequest<AddBoardResponse>
    {
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
    }

    public class AddBoardCommandHandler : IRequestHandler<AddBoardCommand, AddBoardResponse>
    {
        private readonly IBoardRepository boardRepository;
        private readonly IMapper mapper;
        public AddBoardCommandHandler(IBoardRepository boardRepository, IMapper mapper)
        {
            this.boardRepository = boardRepository;
            this.mapper = mapper;
        }
        public async Task<AddBoardResponse> Handle(AddBoardCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Board newBoard = new Board
                {
                    Name = request.Name,
                    Description = request.Description
                };

                var entity = await this.boardRepository.AddAsync(newBoard, cancellationToken);
                if (entity == null)
                {
                    return new AddBoardResponse
                    {
                        Message = "Failed to add new board",
                        IsSuccess = false,
                        Data = entity
                    };
                }

                return new AddBoardResponse
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new AddBoardResponse
                {
                    IsSuccess = false,
                    Message = $"An error occurred: {ex.Message} + {ex.InnerException} "
                };
            }
        }
    }
}
