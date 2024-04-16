using Microsoft.EntityFrameworkCore;

namespace foody_be.Models.Context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
    }
}
