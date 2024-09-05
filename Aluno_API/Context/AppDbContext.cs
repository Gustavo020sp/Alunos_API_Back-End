﻿using Aluno_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aluno_API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Aluno> Alunos { get; set; }

        //seed database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Antonio José",
                    Email = "antonio@gmail.com",
                    Idade = 31
                },

                new Aluno
                {
                    Id = 2,
                    Nome = "Maria Penha",
                    Email = "maria@gmail.com",
                    Idade = 39
                },

                new Aluno
                {
                    Id = 3,
                    Nome = "Jonas Gomes",
                    Email = "jonas@gmail.com",
                    Idade = 20
                });
        }
    }
}
