

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Proceeding
{
    public abstract class PEnumerationWritBase : PunishmentOrgEntity<string>
    {

		[Column("CASESNOSUBNO")]
		public virtual string? CasesNoSubno { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("EXEPRSFAMILY")]
		public virtual string? ExePrsFamily { get; set; }

		[Column("EXEPRSFATHERNAME")]
		public virtual string? ExePrsFatherName { get; set; }

		[Column("EXEPRSNAME")]
		public virtual string? ExePrsName { get; set; }

		[Column("EXEPRSNATIONALCODE")]
		public virtual string? ExePrsNationalCode { get; set; }

		[Column("EXPERTPRICE")]
		public virtual long? ExpertPrice { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePEnumerationWrit")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PEnumerationWritCase>? ThePEnumerationWritCaseList { get; set; }

		[InverseProperty("ThePEnumerationWrit")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PEnumerationWritExpert>? ThePEnumerationWritExpertList { get; set; }

		[InverseProperty("ThePEnumerationWrit")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PEnumerationWritIssuer>? ThePEnumerationWritIssuerList { get; set; }

		[InverseProperty("ThePEnumerationWrit")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PEnumerationWritUnit>? ThePEnumerationWritUnitList { get; set; }

		[InverseProperty("ThePEnumerationWrit")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PEnumerationWritWrapCase>? ThePEnumerationWritWrapCaseList { get; set; }

		[ForeignKey("PINCOMINGLETTERID")]
		public virtual Anu.PunishmentOrg.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("WRITDATE")]
		public virtual string? WritDate { get; set; }

		[Column("WRITTEXT")]
		public virtual string? WritText { get; set; }

		[Column("WRITTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUEnumerationWritType? WritType { get; set; }

    }
    [Table("PENUMERATIONWRIT")]
    public partial class PEnumerationWrit : PEnumerationWritBase { }

    }


