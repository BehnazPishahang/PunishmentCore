

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PNote1Article21ProtestPrsBase : PunishmentOrgEntity<string>
    {

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [ForeignKey("PNOTE1ARTICLE21PROTESTID")]
        public virtual Anu.PunishmentOrg.DataModel.Gravamen.PNote1Article21Protest? ThePNote1Article21Protest { get; set; }

    }

    [Table("PNOTE1ARTICLE21PROTESTPRS")]
    public partial class PNote1Article21ProtestPrs : PNote1Article21ProtestPrsBase
    {
    }
}