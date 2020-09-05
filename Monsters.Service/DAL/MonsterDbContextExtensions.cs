using Microsoft.EntityFrameworkCore;
using Monsters.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.DAL
{
    public static class MonsterDbContextExtensions
    {
        public static void Seed(this MonsterDbContext dbcontext, ModelBuilder builder)
        {
            builder.Entity<Door>()
                .HasData(
                new Door()
                {
                    Id = "door1",
                    KidBehindDoorName = "Rosie",
                    Power = 30,
                    LastScare = new DateTime(2020, 7, 5)
                },
                new Door()
                {
                    Id = "door2",
                    KidBehindDoorName = "Abraham",
                    Power = 50,
                    LastScare = new DateTime(2020, 7, 5)
                },
                new Door()
                {
                    Id = "door3",
                    KidBehindDoorName = "Moshe",
                    Power = 60,
                    LastScare = new DateTime(2020, 7, 5)
                },
                new Door()
                {
                    Id = "door4",
                    KidBehindDoorName = "Danny",
                    Power = 70,
                    LastScare = new DateTime(2020, 7, 5)
                },
                new Door()
                {
                    Id = "door5",
                    KidBehindDoorName = "Yoni",
                    Power = 80,
                    LastScare = new DateTime(2020, 7, 5)
                },
                new Door()
                {
                    Id = "door6",
                    KidBehindDoorName = "Lev",
                    Power = 90,
                    LastScare = new DateTime(2020, 7, 5)
                },
                new Door()
                {
                    Id = "door7",
                    KidBehindDoorName = "Maxim",
                    Power = 1000,
                    LastScare = new DateTime(2020, 7, 5)
                }
            );

        }
    }
}
