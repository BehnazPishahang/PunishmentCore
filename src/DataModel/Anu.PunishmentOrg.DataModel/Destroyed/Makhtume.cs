using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class MakhtumeBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CODERAY")]
        public virtual string? CODERAY { get; set; }

        [Unicode(false)]
        [Column("DADNAME")]
        public virtual string? DADNAME { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? FAMILY { get; set; }

        [Unicode(false)]
        [Column("ID")]
        public virtual string? Id { get; set; }

        [Unicode(false)]
        [Column("MARHALE")]
        public virtual string? MARHALE { get; set; }

        [Unicode(false)]
        [Column("MARJA")]
        public virtual string? MARJA { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? NAME { get; set; }

        [Unicode(false)]
        [Column("NOBAT")]
        public virtual string? NOBAT { get; set; }

        [Unicode(false)]
        [Column("NOSHOBE")]
        public virtual string? NOSHOBE { get; set; }

        [Unicode(false)]
        [Column("OSTAN")]
        public virtual string? OSTAN { get; set; }

        [Unicode(false)]
        [Column("RAIFMOT")]
        public virtual string? RAIFMOT { get; set; }

        [Unicode(false)]
        [Column("RAY")]
        public virtual string? RAY { get; set; }

        [Unicode(false)]
        [Column("RTAKH")]
        public virtual string? RTAKH { get; set; }

        [Unicode(false)]
        [Column("SHGOZARESH")]
        public virtual string? SHGOZARESH { get; set; }

        [Unicode(false)]
        [Column("SHM")]
        public virtual string? SHM { get; set; }

        [Unicode(false)]
        [Column("SHOBE")]
        public virtual string? SHOBE { get; set; }

        [Unicode(false)]
        [Column("TAKH")]
        public virtual string? TAKH { get; set; }

        [InverseProperty("TheMakhtume")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.Mahkumiat>? TheMahkumiatList { get; set; }

        [InverseProperty("TheMakhtume")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.Mshaki>? TheMshakiList { get; set; }

        [Unicode(false)]
        [Column("VAHED")]
        public virtual string? VAHED { get; set; }

        }

    [Table("MAKHTUME")]
    public partial class Makhtume : MakhtumeBase
    {
    }
    }