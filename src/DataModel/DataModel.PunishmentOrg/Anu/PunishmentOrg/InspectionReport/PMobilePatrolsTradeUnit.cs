

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.InspectionReport
{
    public abstract class PMobilePatrolsTradeUnitBase : PunishmentOrgEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("INSPECTIONNO")]
		public virtual string? InspectionNo { get; set; }

		[Column("MOBILNUMBER")]
		public virtual string? MobilNumber { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALCODE")]
		public virtual string? NationalCode { get; set; }

		[Column("REFERENCETIME")]
		public virtual string? ReferenceTime { get; set; }

		[Column("RESULT")]
		public virtual Anu.Enumerations.PunishmentOrg.PUMobilePatrolsResult? Result { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SEX")]
		public virtual Anu.Enumerations.SexType? Sex { get; set; }

		[ForeignKey("PBREGULATORYPLANID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBRegulatoryPlan? ThePBRegulatoryPlan { get; set; }

		[ForeignKey("PBTRADEUNIONSID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBTradeUnions? ThePBTradeUnions { get; set; }

		[ForeignKey("PBTRADEUNITTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBTradeUnitType? ThePBTradeUnitType { get; set; }

		[ForeignKey("PMOBILEPATROLSID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PMobilePatrols? ThePMobilePatrols { get; set; }

		[Column("TRADELICENSEDATE")]
		public virtual string? TradeLicenseDate { get; set; }

		[Column("TRADELICENSENUMBER")]
		public virtual string? TradeLicenseNumber { get; set; }

    }
    [Table("PMOBILEPATROLSTRADEUNIT")]
    public partial class PMobilePatrolsTradeUnit : PMobilePatrolsTradeUnitBase { }

    }


