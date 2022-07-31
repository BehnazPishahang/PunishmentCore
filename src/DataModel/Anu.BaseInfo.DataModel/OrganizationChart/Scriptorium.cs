

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.OrganizationChart
{
    public abstract class ScriptoriumBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("EMAILADDRESS")]
        public virtual string? EMailAddress { get; set; }

        [Unicode(false)]
        [Column("EXORDIUMFAMILY")]
        public virtual string? ExordiumFamily { get; set; }

        [Unicode(false)]
        [Column("EXORDIUMNAME")]
        public virtual string? ExordiumName { get; set; }

        [Column("ISRELTOTERMINAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsRelToTerminal { get; set; }

        [Unicode(false)]
        [Column("LEGACYCODE")]
        public virtual string? LegacyCode { get; set; }

        [Unicode(false)]
        [Column("MOBILENUMBER4SMS")]
        public virtual string? MobileNumber4SMS { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NSCRIPTORIUMID")]
        public virtual string? NScriptoriumId { get; set; }

        [Unicode(false)]
        [Column("POSTCODE")]
        public virtual string? PostCode { get; set; }

        [Column("SCRIPTORIUMDIVORCENO")]
        public virtual long? ScriptoriumDivorceNo { get; set; }

        [Column("SCRIPTORIUMNO")]
        public virtual long? ScriptoriumNo { get; set; }

        [Column("SCRIPTORIUMTYPE")]
        public virtual Anu.BaseInfo.Enumerations.NotaryActivityType? ScriptoriumType { get; set; }

        [Unicode(false)]
        [Column("SMSENGLISHNAME")]
        public virtual string? SMSEnglishName { get; set; }

        [Unicode(false)]
        [Column("SMSFARSINAME")]
        public virtual string? SMSFarsiName { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
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