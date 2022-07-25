﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedCasePlaintiffBase : PunishmentOrgEntity<string>
    {

        [Column("DAMAGECAUSEDVALUE")]
        public virtual long? DamageCausedValue { get; set; }

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [ForeignKey("PDESTROYEDCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCase? ThePDestroyedCase { get; set; }

    }

    [Table("PDESTROYEDCASEPLAINTIFF")]
    public partial class PDestroyedCasePlaintiff : PDestroyedCasePlaintiffBase
    {
    }
}