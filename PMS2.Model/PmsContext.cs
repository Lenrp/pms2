using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace PMS2.Model
{
    public class PmsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connStr = ConfigurationManager.AppSettings["connect"];
            options.UseSqlServer(connStr);
        }
    }                   
}
