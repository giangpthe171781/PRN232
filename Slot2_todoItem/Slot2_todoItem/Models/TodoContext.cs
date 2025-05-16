using Microsoft.EntityFrameworkCore;

namespace Slot2_todoItem.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        // Optional nếu dùng InMemoryDatabase cho test/dev
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseInMemoryDatabase("TodoList");
        }
    }
}
