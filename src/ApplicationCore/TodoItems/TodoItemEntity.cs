using ApplicationCore.Common;
using ApplicationCore.Common.Enums;

namespace ApplicationCore.TodoItems;

public class TodoItemEntity : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public string Note { get; set; } = string.Empty;
    
    public PriorityLevel Priority { get; set; }

    public DateTime? Reminder { get; set; }
}
