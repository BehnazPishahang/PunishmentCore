

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Gravamen
{
    public abstract class PGravamenViolationBase : PunishmentOrgEntity<string>
    {

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SUBJECTTITLE")]
		public virtual string? SubjectTitle { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("PBVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBViolationType? ThePBViolationType { get; set; }

		[ForeignKey("PGRAVAMENID")]
		public virtual Anu.PunishmentOrg.Gravamen.PGravamen? ThePGravamen { get; set; }

		[Column("VIOLATIONADDRESS")]
		public virtual string? ViolationAddress { get; set; }

		[Column("VIOLATIONDATE")]
		public virtual string? ViolationDate { get; set; }

		[Column("VIOLATIONDESC")]
		public virtual string? ViolationDesc { get; set; }

		[Column("VIOLATIONPRICE")]
		public virtual long? ViolationPrice { get; set; }

    }
    [Table("PGRAVAMENVIOLATION")]
    public partial class PGravamenViolation : PGravamenViolationBase { }

    }


