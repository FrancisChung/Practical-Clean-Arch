using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaWorkshop.Application.Common.Interfaces;
using CaWorkshop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaWorkshop.Application.TodoLists.Queries.GetTodoLists
{

    public interface IGetTodoListsQuery
    {
        Task<List<TodoList>> Handle();
    }

    public class GetTodoListsQuery : IGetTodoListsQuery
    {
        private readonly IApplicationDbContext _context;

        public GetTodoListsQuery(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoList>> Handle()
        {
            return await _context.TodoLists
                .Select(l => new TodoList
                {
                    Id = l.Id,
                    Title = l.Title,
                    Items = l.Items.Select(i => new TodoItem
                    {
                        Id = i.Id,
                        ListId = i.ListId,
                        Title = i.Title,
                        Done = i.Done,
                        Priority = i.Priority,
                        Note = i.Note
                    }).ToList()
                }).ToListAsync();
        }
    }
}
