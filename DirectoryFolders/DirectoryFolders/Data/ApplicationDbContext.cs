using DirectoryFolders.Models;
using Microsoft.EntityFrameworkCore;

namespace DirectoryFolders.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Folder> Folders { get; set; }
    }
}
