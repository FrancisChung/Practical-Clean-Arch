using System.Collections.Generic;

namespace CaWorkshop.Application.TodoLists.Queries.GetTodoLists
{
    public class TodoListDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public IList<TodoItemDto> Items { get; set; }
    }
}