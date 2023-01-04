using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ASP.NETCore.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base (options) 
        {
            
        }
    }
}
