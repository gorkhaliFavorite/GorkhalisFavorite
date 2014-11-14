
using System.Data.Entity;

namespace GorkhalisFavorite.Models
{
    public class GorkhalisFavoriteDb : DbContext
    {
        public GorkhalisFavoriteDb() : base("name=DefaultConnection")
        {
            
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}