using ApplicationCore.Common.Enums;

namespace ApplicationCore.TodoItems;

public class TodoItemsService : ITodoItemsService
{
    public Task<List<TodoItemEntity>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult(new List<TodoItemEntity>()
        {
            new TodoItemEntity()
            {
                Id = 1,
                Title = "hehe",
                Note = "Test Note",
                Priority = PriorityLevel.High,
                Reminder = null
            }
        });
    }

    public Task<TodoItemEntity> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TodoItemEntity> Create(TodoItemEntity todoItem)
    {
        throw new NotImplementedException();
    }

    public Task<TodoItemEntity> Update(int id, TodoItemEntity todoItemEntity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteById(int id)
    {
        throw new NotImplementedException();
    }
}