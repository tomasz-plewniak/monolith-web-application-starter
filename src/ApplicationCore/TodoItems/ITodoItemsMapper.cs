namespace ApplicationCore.TodoItems;

public static class TodoItemsMapper 
{
    public static TodoItemDto ToDto(TodoItemEntity todoItemEntity)
    {
        ArgumentNullException.ThrowIfNull(todoItemEntity);

        return new TodoItemDto(
            todoItemEntity.Id,
            todoItemEntity.Title,
            todoItemEntity.Note,
            todoItemEntity.Priority,
            todoItemEntity.Reminder);
    }
    
    public static IEnumerable<TodoItemDto> ToDto(IEnumerable<TodoItemEntity> todoItems)
    {
        ArgumentNullException.ThrowIfNull(todoItems);


        return todoItems.Select(todoItem => ToDto(todoItem));
    }
    
    public static TodoItemEntity ToEntity(TodoItemDto todoItemDto)
    {
        ArgumentNullException.ThrowIfNull(todoItemDto);

        return new TodoItemEntity()
        {
            Id = todoItemDto.Id,
            Note = todoItemDto.Note,
            Priority = todoItemDto.PriorityLevel,
            Reminder = todoItemDto.Reminder,
            Title = todoItemDto.Title
        };
    }
}