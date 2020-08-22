using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Infrastructure
{
    public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            
            optionsBuilder.UseLazyLoadingProxies()
                          .UseSqlServer(ConfigSettings.ConnectionString);

            return new DBContext(optionsBuilder.Options);
        }
    }
}
