

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.OrganizationChart
{
    public abstract class ScriptoriumBase : BaseInfoEntity<string>
    {

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("EMAILADDRESS")]
        public virtual string? EMailAddress { get; set; }

        [Column("EXORDIUMFAMILY")]
        public virtual string? ExordiumFamily { get; set; }

        [Column("EXORDIUMNAME")]
        public virtual string? ExordiumName { get; set; }

        [Column("ISRELTOTERMINAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsRelToTerminal { get; set; }

        [Column("LEGACYCODE")]
        public virtual string? LegacyCode { get; set; }

        [Column("MOBILENUMBER4SMS")]
        public virtual string? MobileNumber4SMS { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NSCRIPTORIUMID")]
        public virtual string? NScriptoriumId { get; set; }

        [Column("POSTCODE")]
        public virtual string? PostCode { get; set; }

        [Column("SCRIPTORIUMDIVORCENO")]
        public virtual long? ScriptoriumDivorceNo { get; set; }

        [Column("SCRIPTORIUMNO")]
        public virtual long? ScriptoriumNo { get; set; }

        [Column("SCRIPTORIUMTYPE")]
        public virtual Anu.BaseInfo.Enumerations.NotaryActivityType? ScriptoriumType { get; set; }

        [Column("SMSENGLISHNAME")]
        public virtual string? SMSEnglishName { get; set; }

        [Column("SMSFARSINAME")]
        public virtual string? SMSFarsiName { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Column("TEL")]
        public virtual string? Tel { get; set; }

        [ForeignKey("RELATEDUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheRelatedUnit { get; set; }

    }

    [Table("SCRIPTORIUM")]
    public partial class Scriptorium : ScriptoriumBase
    {
    }
}