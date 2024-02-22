using Microsoft.EntityFrameworkCore;

namespace To_DoAPI.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ToDo> ToDoSet { get; set; }
    }
}
