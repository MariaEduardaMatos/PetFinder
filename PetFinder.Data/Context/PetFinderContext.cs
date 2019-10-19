﻿using PetFinder.Data.EntityConfig;
using PetFinder.Data.Interfaces;
using PetFinderDomain.Entities;
using Projeto.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.Context
{

    [DbConfigurationType(typeof(NpgsqlConfiguration))]
    public class PetFinderContext: DbContext, IDbContext
    {
        public PetFinderContext() : base("DefaultConnection")
        {
            Database.SetInitializer<PetFinderContext>(null);
        }
        //adicionando as entidades
        public DbSet<Adocao> Adocao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet <AdocaoInteresse> AdocaoInteresse { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Endereco> Endereco  { get; set; }
        public DbSet<PetImagem> Imagem  { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Raca> Raca  { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties().Where(a => a.Name.Equals("Codigo")).Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new AdocaoConfig());
            modelBuilder.Configurations.Add(new AdocaoInteresseConfig());
            modelBuilder.Configurations.Add(new PetConfig());
            modelBuilder.Configurations.Add(new EstadoConfig());
            modelBuilder.Configurations.Add(new PaisConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new RacaConfig());
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
