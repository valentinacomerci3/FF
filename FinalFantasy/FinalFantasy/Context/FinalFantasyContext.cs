using FinalFantasy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Context
{
    public class FinalFantasyContext : DbContext
    {
        public DbSet<Giocatore> Giocatori { get; set; }
        public DbSet<Personaggio> Personaggi { get; set; }
        public DbSet<Arma> Armi { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info = False; 
                                    Integrated Security = true; 
                                    Initial Catalog = FinalFantasy; 
                                    Server = .\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Giocatore>()
                        .ToTable("Giocatore")
                        .HasKey(g => g.ID);
            modelBuilder.Entity<Giocatore>()
                        .Property(g => g.Nickname).IsFixedLength().HasMaxLength(16);
            modelBuilder.Entity<Giocatore>()
                        .Property(g => g.Password).HasMaxLength(10).IsRequired();
            

            modelBuilder.Entity<Personaggio>()
                        .ToTable("Personaggio")
                        .HasKey(p => p.ID);
            modelBuilder.Entity<Personaggio>()
                        .Property(p => p.Nome)
                        .IsRequired();
            modelBuilder.Entity<Personaggio>()
                        .Property(p => p.PuntiVita)
                        .IsRequired();
            
            modelBuilder.Entity<Personaggio>()
                        .HasDiscriminator<string>("Categoria")
                        .HasValue<Eroe>("Eroe")
                        .HasValue<Mostro>("Mostro")
                        

            

            modelBuilder.Entity<Eroe>()
                        .HasData(
                            new Eroe
                            {
                                Nome = "Thorus",
                                PuntiVita = 10,
                                
                                
                            },
                            new Eroe
                            {
                                Nome = "Thanos",
                                PuntiVita = 30,
                                
                            }
                );
            modelBuilder.Entity<Mostro>().HasData(
                    new Mostro
                    {
                        Nome = "Grok",
                        PuntiVita = 10,

                    },
                    new Mostro
                    {
                        Nome = "Shuk",
                        PuntiVita = 20,

                    }
                );
        }

    }
}
