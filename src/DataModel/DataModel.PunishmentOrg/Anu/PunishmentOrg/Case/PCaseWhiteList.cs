

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PCaseWhiteListBase : PunishmentOrgEntity<string>
    {

		[Column("DOCLETTERDATE")]
		public virtual string? DocLetterDate { get; set; }

		[Column("DOCLETTERIMAGE")]
		public virtual byte[]? DocLetterImage { get; set; }

		[Column("DOCLETTERNO")]
		public virtual string? DocLetterNo { get; set; }

		[Column("EXCEPTIONTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.ExceptionType? ExceptionType { get; set; }

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PCASEWHITELIST")]
    public partial class PCaseWhiteList : PCaseWhiteListBase { }

    }


