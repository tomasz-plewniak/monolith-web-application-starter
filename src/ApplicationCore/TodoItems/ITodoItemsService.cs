namespace ApplicationCore.TodoItems;

public interface ITodoItemsService
{
    Task<List<TodoItemDto>> GetAllAsync(CancellationToken cancellationToken = default);
    
    Task<TodoItemDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<TodoItemDto> Create(TodoItemDto todoItem);

    Task<TodoItemDto> Update(int id, TodoItemDto todoItemEntity);

    Task<bool> DeleteById(int id);
}
