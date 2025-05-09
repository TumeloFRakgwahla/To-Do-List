using Microsoft.EntityFrameworkCore;
using TodoListApp.Models;

namespace TodoListApp.Data
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> option) : base(option)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}
