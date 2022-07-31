

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Proceeding
{
    public abstract class PEnumerationWritExpertBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALITYCODE")]
        public virtual string? NationalityCode { get; set; }

        [ForeignKey("EXPERTMAJORID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertMajor? TheExpertMajor { get; set; }

        [ForeignKey("EXPERTMANID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertMan? TheExpertMan { get; set; }

        [ForeignKey("PENUMERATIONWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWrit? ThePEnumerationWrit { get; set; }

    }

    [Table("PENUMERATIONWRITEXPERT")]
    public partial class PEnumerationWritExpert : PEnumerationWritExpertBase
    {
    }
    }