using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Oracle.DbContext
{
    public abstract class OracleDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public OracleDbContext(DbContextOptions options) : base(options)
        {
            SavingChanges += OracleDbContext_SavingChanges;
        }

        private void OracleDbContext_SavingChanges(object? sender, SavingChangesEventArgs e)
        {

            //foreach (var entry in ChangeTracker.Entries())
            //{
            //    if (entry.Entity is IEntity)
            //    {
            //        var entity = (IEntity)entry.Entity;
            //        entity.Validate(entry.State);
            //    }
            //}

        }

        public TResult? GetOriginalValue<TEntity, TResult>(TEntity entity, string propertyName) where TEntity : class
        {
            var entry = ChangeTracker.Entries<TEntity>().Where(x => x.Entity == entity).FirstOrDefault();
            if (entry != null)
            {
                return entry.OriginalValues.GetValue<TResult>(propertyName);
            }
            return default;
        }

        private List<Type> _entityTypes = new List<Type>();
        protected void UseEntity<TEntity>()
        {
            UseEntity(typeof(TEntity));

        }

        protected void UseEntity(Type entityType)
        {
            if (entityType.IsClass && !_entityTypes.Contains(entityType))
            {
                var attributes = entityType.GetCustomAttributes(typeof(TableAttribute), false);
                if (attributes.Length == 1)
                {
                    _entityTypes.Add(entityType);
                }
            }
        }

        protected void UseAssembly(System.Reflection.Assembly assembly)
        {
            var types = assembly.GetTypes();
            foreach (var t in types)
            {
                UseEntity(t);
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var et in _entityTypes)
            {
                modelBuilder.Entity(et);
            }

            modelBuilder.Entity(typeof(SqlRawEntity))
                .HasNoKey();


            base.OnModelCreating(modelBuilder);
        }









    }

    public class SqlRawEntity
    {
        #region String
        public string? S0 { get; set; }
        public string? S1 { get; set; }
        public string? S2 { get; set; }
        public string? S3 { get; set; }
        public string? S4 { get; set; }
        public string? S5 { get; set; }
        public string? S6 { get; set; }
        public string? S7 { get; set; }
        public string? S8 { get; set; }
        public string? S9 { get; set; }

        #endregion String

        #region Decimal
        public decimal? D0 { get; set; }
        public decimal? D1 { get; set; }
        public decimal? D2 { get; set; }
        public decimal? D3 { get; set; }
        public decimal? D4 { get; set; }
        public decimal? D5 { get; set; }
        public decimal? D6 { get; set; }
        public decimal? D7 { get; set; }
        public decimal? D8 { get; set; }
        public decimal? D9 { get; set; }

        #endregion Decimal

        #region DateTime

        public DateTime? T0 { get; set; }
        public DateTime? T1 { get; set; }
        public DateTime? T2 { get; set; }
        public DateTime? T3 { get; set; }
        public DateTime? T4 { get; set; }
        public DateTime? T5 { get; set; }
        public DateTime? T6 { get; set; }
        public DateTime? T7 { get; set; }
        public DateTime? T8 { get; set; }
        public DateTime? T9 { get; set; }

        #endregion DateTime

        #region GUID
        public Guid? G0 { get; set; }
        public Guid? G1 { get; set; }
        public Guid? G2 { get; set; }

        #endregion GUID

        #region Binary
        public byte[]? B0 { get; set; }
        public byte[]? B1 { get; set; }
        public byte[]? B2 { get; set; }

        #endregion Binary

    }


}