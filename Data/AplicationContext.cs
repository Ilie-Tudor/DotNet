using Microsoft.EntityFrameworkCore;
using ReviewApp.Models;

namespace ReviewApp.Data{

    public class AplicationContext : DbContext{

        public AplicationContext(DbContextOptions<AplicationContext> opt) : base(opt){
            
        }

        public DbSet<User> Users { get; set; } 
        public DbSet<UserCategory> UserCategories { get; set; } 
        public DbSet<Profile> Profiles {get; set;}
        public DbSet<Preference> Preferences {get; set;}
        public DbSet<Article> Articles {get; set;}
        public DbSet<ArticleCategory> ArticleCategories {get; set;}
        public DbSet<A_AC> A_ACs {get; set;}
        public DbSet<Comment> Comments {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<A_AC>().HasKey(c => new { c.article_id, c.articleCategory_id });
            modelBuilder.Entity<Comment>().HasKey(c => new { c.article_id, c.user_id });

            modelBuilder.Entity<UserCategory>().HasData(
                new UserCategory[] {
                new UserCategory{userCategory_id="1", role="Administrator", aditionalInfo_id="ceva"},
                new UserCategory{userCategory_id="2", role="Creator", aditionalInfo_id="ceva"},
                new UserCategory{userCategory_id="3", role="Consumer", aditionalInfo_id="ceva"}
            });
        }
        
    }
}