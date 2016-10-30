using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ContosoUniversity.Core.Infrastructure.Data
{
    public class SchoolDbContextFactory : IDbContextFactory<SchoolContext>
    {
        public SchoolContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<SchoolContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyContosoUniversityCoreDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new SchoolContext(builder.Options);
        }
    }
}
