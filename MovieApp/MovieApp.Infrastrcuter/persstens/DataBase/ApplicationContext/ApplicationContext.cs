using Microsoft.EntityFrameworkCore;
using MovieSystem.Domain.Entites.Commen;
using MovieSystem.Infrastructer.presistance.seading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.ApplicationContext
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        :base(options) 
        {
                
        }

        //==================================

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new DbInilaizer(modelBuilder).Seed();

            // إعداد العلاقة بين User و Review كـ One-to-Many مع شرط No Action عند الحذف
            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.Userid)
                .OnDelete(DeleteBehavior.NoAction);

            // إعداد العلاقة بين Movie و Review كـ One-to-Many مع شرط No Action عند الحذف
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.reviews)
                .HasForeignKey(r => r.Movieid)
                .OnDelete(DeleteBehavior.NoAction);
            // إعداد العلاقة Many-to-Many بين User و Role باستخدام RoleUser كجدول وسيط
            modelBuilder.Entity<RoleUser>()
                .HasKey(ru => new { ru.Userid, ru.Roleid }); // المفتاح المركب

            modelBuilder.Entity<RoleUser>()
                .HasOne(ru => ru.User)
                .WithMany(u => u.RoleUsers)
                .HasForeignKey(ru => ru.Userid)
                .OnDelete(DeleteBehavior.NoAction); // عدم الحذف التلقائي عند حذف المستخدم

            modelBuilder.Entity<RoleUser>()
                .HasOne(ru => ru.Role)
                .WithMany(r => r.roleUsers)
                .HasForeignKey(ru => ru.Roleid)
                .OnDelete(DeleteBehavior.NoAction); // عدم الحذف التلقائي عند حذف الدور

            // إعداد العلاقة Many-to-Many بين Role و Permission
            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.rolePermissions)
                .HasForeignKey(rp => rp.RoleId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.permission)
                .WithMany(p => p.rolePermissions)
                .HasForeignKey(rp => rp.PermissionId)
                .OnDelete(DeleteBehavior.NoAction);
            //===================

            modelBuilder.Entity<Role>()
                .HasMany(ur => ur.roleUsers)
                .WithOne(r => r.Role)
                .HasForeignKey(ur => ur.Roleid)
                .OnDelete(DeleteBehavior.NoAction);

           //------------------------------
          
            modelBuilder.Entity<Movie>()
            .HasMany(m=>m.reviews)
            .WithOne(r => r.Movie)
            .HasForeignKey(p => p.Movieid)
            .OnDelete(DeleteBehavior.NoAction);

            
            //------------------------------

            // User to Review relationship
            modelBuilder.Entity<User>()
                .HasMany(r => r.Reviews)
                .WithOne(u => u.User)
                .HasForeignKey(r => r.Userid)
                .OnDelete(DeleteBehavior.NoAction); // No action on delete

                modelBuilder.Entity<User>()
               .HasMany(r => r.Likes)
               .WithOne(u => u.User)
               .HasForeignKey(r => r.Userid)
               .OnDelete(DeleteBehavior.NoAction); // No action on delete

            modelBuilder.Entity<Catogery>()
           .HasMany(r => r.Movies)
           .WithOne(u => u.Catogery)
           .HasForeignKey(r => r.Catogeryid)
           .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Catogery>()
           .HasMany(r => r.subcatogeries)
           .WithOne(u => u.parentcatogeries)
           .HasForeignKey(r => r.Parentid)
           .OnDelete(DeleteBehavior.NoAction);
           


         

        }


        //==================  Dbset Entity

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<RoleUser> RoleUsers { get; set; }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        //--
        public DbSet<Catogery> Catogeries { get; set; }
        public DbSet<Like> Likes { get; set; }   
        public DbSet<Movie> Movies { get; set; } 
        
        public DbSet<Review> Reviews { get; set; } 
        
       
        
        //===========================================
        
    }
}
