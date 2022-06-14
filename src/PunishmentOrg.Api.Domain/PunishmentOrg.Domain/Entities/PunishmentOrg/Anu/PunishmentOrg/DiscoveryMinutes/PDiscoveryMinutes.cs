

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PunishmentOrg.Domain.Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    
    public abstract class PDiscoveryMinutesBase
    {
        [Key]
        [Column("ID")]
        public virtual string Id { get; set; }

        [ForeignKey("OBJECTSTATEID")]
		public virtual BaseInfo.Anu.BaseInfo.SystemObject.ObjectState TheObjectState { get; set; }

		[Column("UNIQUENO")]
		public virtual string UniqueNo { get; set; }
    }
    [Table("PDISCOVERYMINUTES")]
    public partial class PDiscoveryMinutes : PDiscoveryMinutesBase { }

    }


