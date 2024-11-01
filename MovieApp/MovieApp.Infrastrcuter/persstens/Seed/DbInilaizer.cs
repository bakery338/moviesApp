using Microsoft.EntityFrameworkCore;

using MovieSystem.Domain.Entites.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Permission = MovieSystem.Domain.Entites.Commen.Permission;
//using RolePermission = MovieSystem.Domain.Entites.Commen.RolePermission;
using User = MovieSystem.Domain.Entites.Commen.User;

namespace MovieSystem.Infrastructer.presistance.seading
{


    public class DbInilaizer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInilaizer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        //==================================
        public void Seed()
        {

            modelBuilder.Entity<User>().ToTable("Users")
                .HasData(
                   new User { Id = 1, Name = "bakery" },
                   new User { Id = 2,Name ="ali" }
                );
            modelBuilder.Entity<User>().HasKey(e => new { e.Id });
            //=========================
            modelBuilder.Entity<Role>().ToTable("Roles")
               .HasData(
                  new Role { Id = 1, Name = "Admin" },
                  new Role { Id = 2, Name = "HR" }
               );
            modelBuilder.Entity<Role>().HasKey(e => new { e.Id });
            //=========================

            modelBuilder.Entity<Permission>().ToTable("Permissions")
               .HasData(
                  new Permission { Id = 1, Name = "Create" },
                  new Permission { Id = 2, Name = "update" },
                  new Permission { Id = 3, Name = "delet" }
               );
            modelBuilder.Entity<Role>().HasKey(e => new { e.Id });

        //=========================

            modelBuilder.Entity<Catogery>().ToTable("Catogeries")
                .HasData( 
                   new Catogery {Id=1,Name=" action ",Parentid=1},
                   new Catogery {Id=2,Name=" Deram ",Parentid=1}
                );
            modelBuilder.Entity<Catogery>().HasKey(e => new { e.Id });
            //=========================

            modelBuilder.Entity<Movie>().ToTable("Movies")
                .HasData(
                 new Movie { Id = 1, Name = " action1 ",Catogeryid=1},
                 new Movie { Id = 2, Name = "deram 1", Catogeryid = 2 }
                );
            modelBuilder.Entity<Movie>().HasKey(e => new { e.Id });

            //=========================
            modelBuilder.Entity<Like>().ToTable("Likes")
                .HasData(

                );
            modelBuilder.Entity<Like>().HasKey(e => new { e.Id });
            //=========================

            modelBuilder.Entity<Review>().ToTable("Reviews")
               .HasData(
                  new Review { Id=1,Content="review content",Userid=1,Movieid=1}
               );
            modelBuilder.Entity<Review>().HasKey(e => new { e.Id });
           //=========================
           
            
          


        }





    }
}
