

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PGravamenViolationBase : PunishmentOrgEntity<string>
    {

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Unicode(false)]
        [Column("SUBJECTTITLE")]
        public virtual string? SubjectTitle { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [ForeignKey("PBVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationType? ThePBViolationType { get; set; }

        [ForeignKey("PGRAVAMENID")]
        public virtual Anu.PunishmentOrg.DataModel.Gravamen.PGravamen? ThePGravamen { get; set; }

        [Unicode(false)]
        [Column("VIOLATIONADDRESS")]
        public virtual string? ViolationAddress { get; set; }

        [Unicode(false)]
        [Column("VIOLATIONDATE")]
        public virtual string? ViolationDate { get; set; }

        [Unicode(false)]
        [Column("VIOLATIONDESC")]
        public virtual string? ViolationDesc { get; set; }

        [Column("VIOLATIONPRICE")]
        public virtual long? ViolationPrice { get; set; }

    }

    [Table("PGRAVAMENVIOLATION")]
    public partial class PGravamenViolation : PGravamenViolationBase
    {
    }
    }