

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.OrganizationChart
{
    public abstract class UnitBase : BaseInfoEntity<string>
    {

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("LEVELCODE")]
        public virtual string? LevelCode { get; set; }

        [Column("SMSFARSINAME")]
        public virtual string? SMSFarsiName { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheParentUnit")]
        public virtual List<Anu.BaseInfo.DataModel.OrganizationChart.Unit>? TheChildUnitsList { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [InverseProperty("TheUnit")]
        public virtual List<Anu.BaseInfo.DataModel.OrganizationChart.GUnitImages>? TheGUnitImagesList { get; set; }

        [InverseProperty("TheUnit")]
        public virtual List<Anu.BaseInfo.DataModel.ExchangeData.GUnitRelatedNajaUnit>? TheGUnitRelatedNajaUnitList { get; set; }

        [ForeignKey("GUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.GUnitType? TheGUnitType { get; set; }

        [ForeignKey("PARENTUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheParentUnit { get; set; }

        [Column("UNITNAME")]
        public virtual string? UnitName { get; set; }

        [Column("UNITNO")]
        public virtual string? UnitNo { get; set; }

    }

    [Table("UNIT")]
    public partial class Unit : UnitBase
    {
    }
}