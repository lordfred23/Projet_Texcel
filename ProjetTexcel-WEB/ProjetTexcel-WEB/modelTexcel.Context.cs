﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetTexcel_WEB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdTexelFredAlexEntities : DbContext
    {
        public bdTexelFredAlexEntities()
            : base("name=bdTexelFredAlexEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCategorieTest> tblCategorieTest { get; set; }
        public virtual DbSet<tblClassification> tblClassification { get; set; }
        public virtual DbSet<tblEmploye> tblEmploye { get; set; }
        public virtual DbSet<tblEquipe> tblEquipe { get; set; }
        public virtual DbSet<tblGenre> tblGenre { get; set; }
        public virtual DbSet<tblJeu> tblJeu { get; set; }
        public virtual DbSet<tblPlatform> tblPlatform { get; set; }
        public virtual DbSet<tblProjet> tblProjet { get; set; }
        public virtual DbSet<tblRole> tblRole { get; set; }
        public virtual DbSet<tblSystemExploitation> tblSystemExploitation { get; set; }
        public virtual DbSet<tblTest> tblTest { get; set; }
        public virtual DbSet<tblTheme> tblTheme { get; set; }
        public virtual DbSet<tblTravail> tblTravail { get; set; }
        public virtual DbSet<tblUser> tblUser { get; set; }
    }
}
