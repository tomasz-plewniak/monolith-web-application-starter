using ApplicationCore.Common.Enums;

namespace ApplicationCore.TodoItems;

public class TodoItemsService : ITodoItemsService
{
    public Task<List<TodoItemDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var todoItems = new List<TodoItemEntity>()
        {
            new TodoItemEntity()
            {
                Id = 1,
                Title = "hehe",
                Note = "Test Note",
                Priority = PriorityLevel.High,
                Reminder = null
            },
            new TodoItemEntity()
            {
                Id = 2,
                Title = "It's the second one",
                Note = "Test",
                Priority = PriorityLevel.High,
                Reminder = null
            }
        };

        return Task.FromResult<List<TodoItemDto>>(TodoItemsMapper.ToDto(todoItems).ToList());
    }

    public Task<TodoItemDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TodoItemDto> Create(TodoItemDto todoItem)
    {
        throw new NotImplementedException();
    }

    public Task<TodoItemDto> Update(int id, TodoItemDto todoItemEntity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteById(int id)
    {
        throw new NotImplementedException();
    }
}