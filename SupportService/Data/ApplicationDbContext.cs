using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SupportService.Models;

namespace SupportService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Reclamation> Reclamations { get; set; }
    }
}
