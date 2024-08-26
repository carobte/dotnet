using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudsitoWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudsitoWeb.Database
{
    public class AppDbContext : DbContext
    {
        
        // aquí se especifica cuáles clases se conectan con cuáles entidades de mi DB
        public DbSet<Coder> Coders { get;set;}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}

// esqueleto para appsettings.json: "server=;port=;database=;uid=;password="