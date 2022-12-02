using GrünflachenManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrünflachenManager;

public class DataContext : DbContext
{
    public DbSet<Kunde> Kunden { get; set; }
    public DbSet<Wunsch> Wünsche { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("\"Data Source=(localdb)\\\\MSSQLLocalDB;Initial Catalog=CarDB;Integrated Security=True;");
        base.OnConfiguring(optionsBuilder);
    }
}
