
using Microsoft.EntityFrameworkCore;
using Oracle.DbContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public abstract class BaseEntity<TKey> : IEntity
    {
        [Key]
        [Column("ID")]
        public TKey? Id { get; set; }

        [Column("TIMESTAMP")]
        public long? Timestamp { get; set; }

        public void Validate(EntityState state)
        {
            this.OnValidate(state);
        }
        protected virtual void OnValidate(EntityState state)
        {

        }
    }
}