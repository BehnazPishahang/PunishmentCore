

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DataModel
{
    public abstract class BaseEntity<TKey> : Anu.Oracle.DbContext.Entity, IEntity
    {
        [Key]
        [Column("ID")]
        [Unicode(false)]
        public TKey? Id { get; set; }

        [Column("TIMESTAMP")]
        [ConcurrencyCheck]

        public long Timestamp { get; set; } = 0;

        //public void Validate(EntityState state)
        //{
        //    this.OnValidate(state);
        //}
        //protected virtual void OnValidate(EntityState state)
        //{

        //}

        public override void OnStateChanged(EntityStateChangedEventArgs e)
        {
            base.OnStateChanged(e);
           
            if (e.OldState == EntityState.Unchanged && e.NewState == EntityState.Modified)
            {
                this.Timestamp++;
            }
            //else if (e.OldState == EntityState.Modified && e.NewState == EntityState.Detached)
            //{
            //    this.Timestamp--;
            //}
        }
    }
}