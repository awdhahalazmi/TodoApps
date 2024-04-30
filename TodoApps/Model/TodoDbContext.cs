using Microsoft.EntityFrameworkCore;
using TodoApps.Model.Entity;

namespace TodoApps.Model
{
    public class TodoDbContext: DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //   modelBuilder.Entity<TodoItem>().HasData();

        }
    }
    
}