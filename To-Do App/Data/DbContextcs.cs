using Microsoft.EntityFrameworkCore;
using To_Do_App.Models;

namespace To_Do_App.Data
{
    // The Todo list of items are added to the database for modelling
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todo { get; set; }
        public TodoDbContext(DbContextOptions<TodoDbContext> options)
         : base(options)
        { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Go to church", IsCompleted = true });
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Barbing", IsCompleted = false });
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Meeting", IsCompleted = true });
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Shopping", IsCompleted = false });
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Exercise", IsCompleted = false });
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Assignment", IsCompleted = true });

        }

    }
}