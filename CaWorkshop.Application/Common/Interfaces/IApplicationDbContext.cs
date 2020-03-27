using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CaWorkshop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaWorkshop.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }
        DbSet<TodoItem> TodoItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
