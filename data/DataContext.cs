﻿using Financas.models;
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
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=Financas;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    public DbSet<Categorias> Categorias { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    
}
