using Microsoft.EntityFrameworkCore;

namespace AspNetWebApi.Data
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
    }
}
