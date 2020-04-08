using AutoMapper;
using CaWorkshop.Application.TodoLists.Queries.GetTodoLists;
using CaWorkshop.Domain.Entities;

namespace CaWorkshop.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TodoList, TodoListDto>();

            CreateMap<TodoItem, TodoItemDto>()
                .ForMember(d => d.Priority, opt =>
                    opt.MapFrom(s => (int) s.Priority));
        }
    }
}
