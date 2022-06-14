

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Notice
{
    public abstract class PNoticeAdvertisingBase : PunishmentOrgEntity<string>
    {

		[Column("ADVERTISINGDATE")]
		public virtual string? AdvertisingDate { get; set; }

		[Column("ADVERTISINGNUMBER")]
		public virtual long? AdvertisingNumber { get; set; }

		[Column("ADVERTISINGTEXT")]
		public virtual string? AdvertisingText { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("ISPRINTED")]
		public virtual Anu.Enumerations.YesNo? IsPrinted { get; set; }

		[Column("NEWSPAPER")]
		public virtual string? Newspaper { get; set; }

		[Column("NEWSPAPERNO")]
		public virtual string? NewspaperNo { get; set; }

		[Column("NEWSPAPERPAGENO")]
		public virtual string? NewspaperPageNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("NOTICEORDER")]
		public virtual string? NoticeOrder { get; set; }

		[Column("PRINTDATE")]
		public virtual string? PrintDate { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePNoticeAdvertising")]
		public virtual List<Anu.PunishmentOrg.Notice.PNoticeAdvertisingCase>? ThePNoticeAdvertisingCaseList { get; set; }

		[InverseProperty("ThePNoticeAdvertising")]
		public virtual List<Anu.PunishmentOrg.Notice.PNoticeAdvertisingDoc>? ThePNoticeAdvertisingDocList { get; set; }

		[InverseProperty("ThePNoticeAdvertising")]
		public virtual List<Anu.PunishmentOrg.Notice.PNoticeAdvertisingUnit>? ThePNoticeAdvertisingUnitList { get; set; }

		[InverseProperty("ThePNoticeAdvertising")]
		public virtual List<Anu.PunishmentOrg.Notice.PNotice>? ThePNoticeList { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PNOTICEADVERTISING")]
    public partial class PNoticeAdvertising : PNoticeAdvertisingBase { }

    }


