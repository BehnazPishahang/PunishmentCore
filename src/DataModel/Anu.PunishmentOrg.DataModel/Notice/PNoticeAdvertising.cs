

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Notice
{
    public abstract class PNoticeAdvertisingBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADVERTISINGDATE")]
        public virtual string? AdvertisingDate { get; set; }

        [Column("ADVERTISINGNUMBER")]
        public virtual long? AdvertisingNumber { get; set; }

        [Unicode(false)]
        [Column("ADVERTISINGTEXT")]
        public virtual string? AdvertisingText { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("ISPRINTED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPrinted { get; set; }

        [Unicode(false)]
        [Column("NEWSPAPER")]
        public virtual string? Newspaper { get; set; }

        [Unicode(false)]
        [Column("NEWSPAPERNO")]
        public virtual string? NewspaperNo { get; set; }

        [Unicode(false)]
        [Column("NEWSPAPERPAGENO")]
        public virtual string? NewspaperPageNo { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("NOTICEORDER")]
        public virtual string? NoticeOrder { get; set; }

        [Unicode(false)]
        [Column("PRINTDATE")]
        public virtual string? PrintDate { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePNoticeAdvertising")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticeAdvertisingCase>? ThePNoticeAdvertisingCaseList { get; set; }

        [InverseProperty("ThePNoticeAdvertising")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticeAdvertisingDoc>? ThePNoticeAdvertisingDocList { get; set; }

        [InverseProperty("ThePNoticeAdvertising")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticeAdvertisingUnit>? ThePNoticeAdvertisingUnitList { get; set; }

        [InverseProperty("ThePNoticeAdvertising")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNotice>? ThePNoticeList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PNOTICEADVERTISING")]
    public partial class PNoticeAdvertising : PNoticeAdvertisingBase
    {
    }
    }