namespace CaWorkshop.Application.TodoLists.Queries.GetTodoLists
{
    public class TodoItemDto
    {
        public long Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public bool Done { get; set; }

        public int Priority { get; set; }

        public string Note { get; set; }
    }
}