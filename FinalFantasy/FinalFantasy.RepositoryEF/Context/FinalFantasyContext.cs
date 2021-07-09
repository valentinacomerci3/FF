
using FinalFantasy.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF.Context
{
    public class FinalFantasyContext : DbContext
    {
        public DbSet<Giocatore> Giocatori { get; set; }
        public DbSet<Eroe> Eroe { get; set; } 
        public DbSet <Mostro> Mostro { get; set; }
        public DbSet <Arma> Arma { get; set; }

        



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
                        .HasKey(g => g.Nickname);
            modelBuilder.Entity<Giocatore>()
                        .Property(g => g.Password).HasMaxLength(10).IsRequired();


            modelBuilder.Entity<Eroe>()
                         .ToTable("Eroe")
                         .HasKey(e => e.ID);
            modelBuilder.Entity<Eroe>()
                        .Property(e => e.Nome).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Eroe>()
                        .Property(e => e.Livello).IsRequired();
            modelBuilder.Entity<Eroe>()
                        .Property(e => e.Categoria).IsRequired();
            modelBuilder.Entity<Eroe>()
                        .Property(e => e.PuntiEsperienza).IsRequired();
            modelBuilder.Entity<Eroe>()
                        .Property(e => e.PuntiVita).IsRequired();
            modelBuilder.Entity<Eroe>()
                        .HasOne(e => e.Giocatore)
                        .WithMany(g => g.Eroi)
                        .HasForeignKey(e => e.GiocatoreNickname);
            modelBuilder.Entity<Eroe>()
                        .HasOne(e => e.Arma)
                        .WithMany(a => a.Eroi)
                        .HasForeignKey(e => e.ArmaNome);



            modelBuilder.Entity<Mostro>()
                         .ToTable("Mostro")
                         .HasKey(m => m.ID);
            modelBuilder.Entity<Mostro>()
                        .Property(m => m.Nome).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Mostro>()
                        .Property(m => m.Livello).IsRequired();
            modelBuilder.Entity<Mostro>()
                        .Property(m => m.Category).IsRequired();
            modelBuilder.Entity<Mostro>()
                        .Property(m => m.PuntiVita).IsRequired();
            

            modelBuilder.Entity<Arma>()
                        .ToTable("Arma")
                        .HasKey(a => a.Nome);
            modelBuilder.Entity<Arma>()
                        .Property(a => a.PuntiDanno).IsRequired();
            modelBuilder.Entity<Arma>()
                        .HasMany(a => a.Mostri)
                        .WithOne(m => m.Arma)
                        .HasForeignKey(m => m.ArmaNome);
            modelBuilder.Entity<Arma>()
                        .HasMany(a => a.Eroi)
                        .WithOne(e => e.Arma)
                        .HasForeignKey(e => e.ArmaNome);




            modelBuilder.Entity<Eroe>() 
                        .HasData(
                            new Eroe
                            {
                                Nome = "Thorus",
                                Livello=1,
                                Categoria= Categoria.Soldier,
                                PuntiEsperienza=12,
                                PuntiVita = 20,
                                GiocatoreNickname="jojo",
                                ArmaNome= "Mazza",

                            },
                            new Eroe
                            {
                                Nome = "Fredis",
                                Livello = 2,
                                Categoria = Categoria.Wizard,
                                PuntiEsperienza = 32,
                                PuntiVita = 40,
                                GiocatoreNickname = "jojo",
                                ArmaNome = "Arco",
                            }
                );

                modelBuilder.Entity<Mostro>().HasData(
                        new Mostro
                        {

                            Nome = "Grok",
                            Livello = 1,
                            Category = Category.Ghost,
                            PuntiVita = 20,
                            ArmaNome = "Clava",

                        },
                        new Mostro
                        {
                            Nome = "Shuk",
                            Livello = 2,
                            Category = Category.Lucifer,
                            PuntiVita = 40,
                            ArmaNome = "Fulmine",

                        }
                    );

                modelBuilder.Entity<Arma>().HasData(
                            new Arma
                            {

                                Nome = "Arco",
                                PuntiDanno=8,                              
                            },
                            new Arma
                            {

                                Nome = "Fulmine",
                                PuntiDanno = 10,
                            }, 
                            new Arma
                            {

                                Nome = "Clava",
                                PuntiDanno = 5,
                            }, 
                            new Arma
                            {

                                Nome = "Mazza",
                                PuntiDanno = 5,
                            }
                        );
            modelBuilder.Entity<Giocatore>().HasData(
                            new Giocatore
                            {

                                Nickname = "jojo",
                                Password = "pass",
                             
                            }
                            
                        );



        }

    }
}
