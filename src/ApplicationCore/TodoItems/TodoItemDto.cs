using ApplicationCore.Common.Enums;

namespace ApplicationCore.TodoItems;

public record TodoItemDto(
    int Id,
    string Title,
    string Note,
    PriorityLevel PriorityLevel,
    DateTime? Reminder);