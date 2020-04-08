using CaWorkshop.Application.Common.Interfaces;
using CaWorkshop.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CaWorkshop.Application.TodoLists.Queries.GetTodoLists
{
    public class GetTodoListsQuery : IRequest<List<TodoListDto>>
    {
    }

    public class GetTodoListsQueryHandler
        : IRequestHandler<GetTodoListsQuery, List<TodoListDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetTodoListsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoListDto>> Handle(
            GetTodoListsQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.TodoLists
                .Select(l => new TodoListDto
                {
                    Id = l.Id,
                    Title = l.Title,
                    Items = l.Items.Select(i => new TodoItemDto
                    {
                        Id = i.Id,
                        ListId = i.ListId,
                        Title = i.Title,
                        Done = i.Done,
                        Priority = (int)i.Priority,
                        Note = i.Note
                    }).ToList()
                })
                .ToListAsync(cancellationToken);
        }
    }
}