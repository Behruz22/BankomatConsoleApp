using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatConsoleApp;

public class BankomatDbContext : DbContext
{
    public DbSet<Bankomat> Bankomats { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Database=BankomatDatabase;User Id=postgres;Password=behruz22;");
    }
}
