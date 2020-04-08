using AutoMapper;
using CaWorkshop.Application.TodoLists.Queries.GetTodoLists;
using CaWorkshop.Domain.Entities;

namespace CaWorkshop.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            new TodoListDto().Mapping(this);
            new TodoItemDto().Mapping(this);
        }
    }
}
