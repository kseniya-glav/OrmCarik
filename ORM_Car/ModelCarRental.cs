
namespace ORM_Car
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    // add a reference to System.ComponentModel.DataAnnotations DLL
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public partial class ModelCarRental : DbContext
    {
        public ModelCarRental()
           : base("Server=127.0.0.1;Database=carrental2;User Id=postgres;Password=12345")
        {
        }

        public virtual DbSet<Автомобили> Автомобили { get; set; }
        public virtual DbSet<Автопрокаты> Автопрокаты { get; set; }
        public virtual DbSet<Арендаторы> Арендаторы { get; set; }
        public virtual DbSet<Банки> Банки { get; set; }
        public virtual DbSet<Дилеры> Дилеры { get; set; }
        public virtual DbSet<Квитанция> Квитанция { get; set; }
        public virtual DbSet<Марки> Марки { get; set; }
        public virtual DbSet<Модели> Модели { get; set; }
        public virtual DbSet<Типы> Типы { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            
            modelBuilder.Entity<Автомобили>()
                .Property(e => e.Цена_за_сутки)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Автомобили>()
                .HasMany(e => e.Квитанция)
                .WithRequired(e => e.Автомобили)
                //.HasForeignKey(e=>e.Номер_автомобиля)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Автопрокаты>()
                .HasMany(e => e.Автомобили)
                .WithRequired(e => e.Автопрокаты)
                //.HasForeignKey(e => e.Код_автопроката)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Арендаторы>()
                .HasMany(e => e.Квитанция)
                .WithRequired(e => e.Арендаторы)
               // .HasForeignKey(e => e.Номер_паспорта)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Банки>()
                .HasMany(e => e.Автопрокаты)
                .WithRequired(e => e.Банки)
               // .HasForeignKey(e => e.Код_банка)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Банки>()
                .HasMany(e => e.Дилеры)
                .WithRequired(e => e.Банки)
               // .HasForeignKey(e => e.Код_банка)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Дилеры>()
                .HasMany(e => e.Автомобили)
                .WithRequired(e => e.Дилеры)
               // .HasForeignKey(e => e.Код_диллера)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Марки>()
                .HasMany(e => e.Модели)
                .WithRequired(e => e.Марки)
               // .HasForeignKey(e => e.Код_марки)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Модели>()
                .HasMany(e => e.Автомобили)
                .WithRequired(e => e.Модели)
               // .HasForeignKey(e => e.Код_модели)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Типы>()
                .HasMany(e => e.Модели)
                .WithRequired(e => e.Типы)
               // .HasForeignKey(e => e.Код_типа)
                .WillCascadeOnDelete(false);
               
        }
    }
}
