using Financas.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localhost)\mssqllocaldb;Database=Financas;Integrated Security=True");
    }
    public DbSet<Categorias> Categorias { get; set; }
    
}
