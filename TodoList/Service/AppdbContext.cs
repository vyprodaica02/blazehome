using Microsoft.EntityFrameworkCore;
using TodoList.Entity;

namespace TodoList.Service
{
    public class AppdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Integrated Security=true;Initial Catalog=DataTodoList;MultipleActiveResultSets=True;encrypt=true;trustservercertificate=true");
        }

        public DbSet<User> users { get; set; }
    }
}
