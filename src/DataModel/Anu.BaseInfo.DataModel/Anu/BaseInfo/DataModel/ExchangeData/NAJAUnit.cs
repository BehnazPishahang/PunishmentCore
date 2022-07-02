

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.ExchangeData
{
    public abstract class NAJAUnitBase : BaseInfoEntity<string>
    {

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("DESC1")]
        public virtual string? Desc1 { get; set; }

        [Column("DESC2")]
        public virtual string? Desc2 { get; set; }

        [Column("DESC3")]
        public virtual string? Desc3 { get; set; }

        [Column("LEVELCODE")]
        public virtual string? LevelCode { get; set; }

        [Column("NAJACODE")]
        public virtual string? NAJACode { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheParentUnit")]
        public virtual List<Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit>? TheChildUnitList { get; set; }

        [ForeignKey("GEXCHANGEUNITTITLEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

        [InverseProperty("TheNAJAUnit")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess>? TheGFESUserAccessList { get; set; }

        [InverseProperty("TheNAJAUnit")]
        public virtual List<Anu.BaseInfo.DataModel.ExchangeData.GUnitRelatedNajaUnit>? TheGUnitRelatedNajaUnitList { get; set; }

        [ForeignKey("PARENTUNITID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheParentUnit { get; set; }

        [Column("UNITNAME")]
        public virtual string? UnitName { get; set; }

    }

    [Table("NAJAUNIT")]
    public partial class NAJAUnit : NAJAUnitBase
    {
    }
}