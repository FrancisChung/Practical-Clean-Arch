using System.Collections.Generic;
using System.Linq;
using CaWorkshop.Domain.Entities;
using CaWorkshop.WebUI.Models;

namespace CaWorkshop.WebUI.Data
{
    public static class ApplicationDbContextSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.TodoLists.Any())
                return;

            context.TodoLists.Add(
                new TodoList
                {
                    Title = "Death List Five",
                    Items = new List<TodoItem>
                    {
                        new TodoItem
                        {
                            Title = "O-Ren Ishii",
                            Done = true
                        },
                        new TodoItem
                        {
                            Title = "Vernita Green",
                            Done = true
                        },
                        new TodoItem
                        {
                            Title = "Budd",
                            Done = true
                        },
                        new TodoItem
                        {
                            Title = "Ellie Driver"
                        },
                        new TodoItem
                        {
                            Title = "Bill"
                        }
                    }
                }
            );

            context.SaveChanges();

        }
    }
}
