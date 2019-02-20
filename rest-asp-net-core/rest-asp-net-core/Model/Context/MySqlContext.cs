using Microsoft.EntityFrameworkCore;

namespace rest_asp_net_core.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {

        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
