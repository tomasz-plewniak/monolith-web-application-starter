using ApplicationCore.TodoItems;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/todo-items")]
public class TodoItemsController : ControllerBase
{
    private readonly ITodoItemsService _todoItemsService;

    public TodoItemsController(ITodoItemsService todoItemsService)
    {
        _todoItemsService = todoItemsService;
    }

    [HttpGet]
    public async Task<IEnumerable<TodoItemDto>> GetAllAsync()
    {
        return await _todoItemsService.GetAllAsync();
    }
}