using Microsoft.EntityFrameworkCore;
using GadgetDepot.Models;

namespace GadgetDepot {
    public class ApiDbContext : DbContext {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Gadget> Gadgets { get; set; }
    }
}