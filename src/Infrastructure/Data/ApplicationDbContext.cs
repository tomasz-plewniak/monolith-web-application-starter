using ApplicationCore.TodoItems;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<TodoItemEntity> TodoItems { get; set; }
}