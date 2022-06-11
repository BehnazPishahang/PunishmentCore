

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PunishmentOrg.Domain.Entities.BaseInfo.Anu.BaseInfo.SystemObject
{
    
    public abstract class ObjectStateBase
    {
        [Key]
        [Column("ID")]
        public virtual string Id { get; set; }

        [Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("OBJECTSTATE")]
    public partial class ObjectState : ObjectStateBase { }

    }


