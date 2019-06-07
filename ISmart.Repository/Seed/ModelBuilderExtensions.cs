using iSmart.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISmart.Repository.Seed
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "Tennis",
                    IsFree = true,
                    CreatedDate = DateTime.Now
                },

                new Game
                {
                    Id = 2,
                    Name = "VolleyBall",
                    IsFree = true,
                    CreatedDate = DateTime.Now
                }
           );
        }
    }
}
