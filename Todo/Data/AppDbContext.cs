using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data
{
    public class AppDbContext:DbContext
    {
        DbSet<TodoModel> Todos => Set<TodoModel>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=todoapp.db;Cache=Shared");
        }
    }
}
