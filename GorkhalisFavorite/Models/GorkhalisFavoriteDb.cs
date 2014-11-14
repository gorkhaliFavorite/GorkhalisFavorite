
using System.Data.Entity;

namespace GorkhalisFavorite.Models
{
    public class GorkhalisFavoriteDb : DbContext
    {
        public GorkhalisFavoriteDb() : base("name=ApplicationServices")
        {
            
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}