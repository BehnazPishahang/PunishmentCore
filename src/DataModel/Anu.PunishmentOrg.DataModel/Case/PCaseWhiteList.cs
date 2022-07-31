

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseWhiteListBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("DOCLETTERDATE")]
        public virtual string? DocLetterDate { get; set; }

        [Column("DOCLETTERIMAGE")]
        public virtual byte[]? DocLetterImage { get; set; }

        [Unicode(false)]
        [Column("DOCLETTERNO")]
        public virtual string? DocLetterNo { get; set; }

        [Column("EXCEPTIONTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.ExceptionType? ExceptionType { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PCASEWHITELIST")]
    public partial class PCaseWhiteList : PCaseWhiteListBase
    {
    }
    }