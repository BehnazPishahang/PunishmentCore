

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.GAdvertising
{
    public abstract class GAdvertisingBase : BaseInfoEntity<string>
    {

		[Column("ACCESSNO")]
		public virtual string? AccessNo { get; set; }

		[Column("ADVERTISINGBUG")]
		public virtual string? AdvertisingBug { get; set; }

		[Column("ADVERTISINGCHANGEABLETEXT")]
		public virtual string? AdvertisingChangeableText { get; set; }

		[Column("ADVERTISINGCOST")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AdvertisingCost { get; set; }

		[Column("ADVERTISINGDATE")]
		public virtual string? AdvertisingDate { get; set; }

		[Column("ADVERTISINGNOTCHANGEABLETEXT")]
		public virtual string? AdvertisingNotChangeableText { get; set; }

		[Column("ADVERTISINGNUMBER")]
		public virtual decimal? AdvertisingNumber { get; set; }

		[Column("ADVERTISINGPRINTFILE")]
		public virtual byte[]? AdvertisingPrintFile { get; set; }

		[Column("ADVERTISINGTEXT")]
		public virtual string? AdvertisingText { get; set; }

		[Column("ADVINETRNETTITLE")]
		public virtual string? AdvInetrnetTitle { get; set; }

		[Column("CONFIRMEDDATE")]
		public virtual string? ConfirmedDate { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("INDEXEDFIELDS")]
		public virtual string? IndexedFields { get; set; }

		[Column("ISPAID")]
		public virtual Rad.CMS.Enumerations.YesNo? IsPaid { get; set; }

		[Column("ISPRINTED")]
		public virtual Rad.CMS.Enumerations.YesNo? IsPrinted { get; set; }

		[Column("LOCALFIELDS")]
		public virtual string? LocalFields { get; set; }

		[Column("NEWSPAPER")]
		public virtual string? Newspaper { get; set; }

		[Column("NEWSPAPERNO")]
		public virtual string? NewspaperNo { get; set; }

		[Column("NEWSPAPERPAGENO")]
		public virtual string? NewspaperPageNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PAIDDATETIME")]
		public virtual string? PaidDateTime { get; set; }

		[Column("PRESENSEDATETIME")]
		public virtual string? PresenseDateTime { get; set; }

		[Column("PRINTDATE")]
		public virtual string? PrintDate { get; set; }

		[Column("REGISTEREDDATE")]
		public virtual string? RegisteredDate { get; set; }

		[Column("RELATEDCASEDESCRIPTION")]
		public virtual string? RelatedCaseDescription { get; set; }

		[Column("REQUESTTEXT")]
		public virtual string? RequestText { get; set; }

		[Column("SENDEDDATE")]
		public virtual string? SendedDate { get; set; }

		[Column("SIDENOTE")]
		public virtual string? SideNote { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.AdvertisingState? State { get; set; }

		[ForeignKey("CONFIRMERUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheConfirmerUser { get; set; }

		[ForeignKey("CREATORUNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheCreatorUnit { get; set; }

		[InverseProperty("TheGAdvertising")]
		public virtual List<Rad.GAdvertising.GAdvertisingCase>? TheGAdvertisingCaseList { get; set; }

		[InverseProperty("TheGAdvertising")]
		public virtual List<Rad.GAdvertising.GAdvertisingRelatedDoc>? TheGAdvertisingRelatedDocList { get; set; }

		[InverseProperty("TheGAdvertising")]
		public virtual List<Rad.GAdvertising.GAdvertisingSiteMap>? TheGAdvertisingSiteMapList { get; set; }

		[ForeignKey("GADVERTISINGSUBJECTTYPEID")]
		public virtual Rad.BaseInfo.Types.GAdvertisingSubjectType? TheGAdvertisingSubjectType { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("REGISTRARUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheRegistrarUser { get; set; }

		[ForeignKey("SENDERUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheSenderUser { get; set; }

    }
    [Table("GADVERTISING")]
    public partial class GAdvertising : GAdvertisingBase { }

    }


