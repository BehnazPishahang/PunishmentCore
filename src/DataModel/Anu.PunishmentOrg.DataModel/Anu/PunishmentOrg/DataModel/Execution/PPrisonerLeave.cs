

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PPrisonerLeaveBase : PunishmentOrgEntity<string>
    {

        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [ForeignKey("PINCOMINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

        [ForeignKey("PPRISONERID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PPrisoner? ThePPrisoner { get; set; }

    }

    [Table("PPRISONERLEAVE")]
    public partial class PPrisonerLeave : PPrisonerLeaveBase
    {
    }
}