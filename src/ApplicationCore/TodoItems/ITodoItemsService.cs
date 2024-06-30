namespace ApplicationCore.TodoItems;

public interface ITodoItemsService
{
    Task<List<TodoItemEntity>> GetAllAsync(CancellationToken cancellationToken = default);
    
    Task<TodoItemEntity> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<TodoItemEntity> Create(TodoItemEntity todoItem);

    Task<TodoItemEntity> Update(int id, TodoItemEntity todoItemEntity);

    Task<bool> DeleteById(int id);
}
