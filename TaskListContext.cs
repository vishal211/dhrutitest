using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SecurityTemplate.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SecurityTemplate.DAL
{
    public class TaskListContext : IdentityDbContext //DbContext
    {

        public TaskListContext() :  base("name=DefaultConnection")
        {
            
        //    this.Database.Initialize(true);
        }
        
        //public DbSet<Company> Companys { get; set; }
        //public DbSet<Address> Addresses { get; set; }
        //// public DbSet<UserType> UserTypes { get; set; }
        //public DbSet<UserTypeRoles> UserTypeRoles { get; set; }
        //public DbSet<Goal> Goals { get; set; }
        //public DbSet<GoalItem> GoalItems  { get; set; }
        //public DbSet<GoalItemsDocument> GoalItemDocuments { get; set; }
        //public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            //modelBuilder.Entity<ApplicationUser>();

            base.OnModelCreating(modelBuilder);

        }

        public System.Data.Entity.DbSet<SecurityTemplate.Models.ApplicationUser> IdentityUsers { get; set; }
    }
}
