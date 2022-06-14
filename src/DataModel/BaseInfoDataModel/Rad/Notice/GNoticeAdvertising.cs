

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Notice
{
    public abstract class GNoticeAdvertisingBase : BaseInfoEntity<string>
    {

		[Column("ADVERTISINGPRINTFILE")]
		public virtual byte[]? AdvertisingPrintFile { get; set; }

		[Column("ADVINETRNETTITLE")]
		public virtual string? AdvInetrnetTitle { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("INDEXEDFIELDS")]
		public virtual string? IndexedFields { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("NOTICEORDER")]
		public virtual string? NoticeOrder { get; set; }

		[Column("PRINTDATE")]
		public virtual string? PrintDate { get; set; }

		[Column("PRINTINGMULTIPLICITY")]
		public virtual Rad.CMS.Enumerations.SequenceNum? PrintingMultiplicity { get; set; }

		[Column("PUBLISHNAME")]
		public virtual string? PublishName { get; set; }

		[Column("REQUESTBODY")]
		public virtual string? RequestBody { get; set; }

		[ForeignKey("CONFIRMERUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheConfirmerUser { get; set; }

		[InverseProperty("TheGNoticeAdvertising")]
		public virtual List<Rad.Notice.GNoticeAdvertisingCase>? TheGNoticeAdvertisingCaseList { get; set; }

		[InverseProperty("TheGNoticeAdvertising")]
		public virtual List<Rad.Notice.GNoticeAdvertisingSiteMap>? TheGNoticeAdvertisingSiteMapList { get; set; }

		[InverseProperty("TheRelatedGNoticeAdvertising")]
		public virtual List<Rad.Notice.GNotice>? TheGNoticeList { get; set; }

		[ForeignKey("GNOTICETYPEID")]
		public virtual Rad.BaseInfo.Types.GNoticeType? TheGNoticeType { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("UNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("GNOTICEADVERTISING")]
    public partial class GNoticeAdvertising : GNoticeAdvertisingBase { }

    }


