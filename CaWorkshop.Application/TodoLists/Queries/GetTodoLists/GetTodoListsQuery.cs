﻿using CaWorkshop.Application.Common.Interfaces;
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
                .Select(TodoListDto.Projection)
                .ToListAsync(cancellationToken);
        }
    }
}