

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBBillMeasurementUnitTypeBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("ORGCODE")]
        public virtual string? OrgCode { get; set; }

        [Column("ORGID")]
        public virtual long? OrgID { get; set; }

        [Column("OVERALLTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MeasurementUnitType? OverallType { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("GEXCHANGEUNITTITLEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBBILLMEASUREMENTUNITTYPE")]
    public partial class PBBillMeasurementUnitType : PBBillMeasurementUnitTypeBase
    {
    }
    }