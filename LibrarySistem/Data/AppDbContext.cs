using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySistem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarySistem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<DocumentType> DocumentTypes {get;set;}
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){
            
        }
    }
}