

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Advertising
{
    public abstract class GAdvertisingBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ACCESSNO")]
        public virtual string? AccessNo { get; set; }

        [Unicode(false)]
        [Column("ADVERTISINGBUG")]
        public virtual string? AdvertisingBug { get; set; }

        [Column("ADVERTISINGCOST")]
        public virtual Anu.BaseInfo.Enumerations.HaveNoHave? AdvertisingCost { get; set; }

        [Unicode(false)]
        [Column("ADVERTISINGDATE")]
        public virtual string? AdvertisingDate { get; set; }

        [Column("ADVERTISINGNUMBER")]
        public virtual long? AdvertisingNumber { get; set; }

        [Column("ADVERTISINGPRINTFILE")]
        public virtual byte[]? AdvertisingPrintFile { get; set; }

        [Unicode(false)]
        [Column("ADVERTISINGTEXT")]
        public virtual string? AdvertisingText { get; set; }

        [Unicode(false)]
        [Column("CONFIRMEDDATE")]
        public virtual string? ConfirmedDate { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("INDEXEDFIELDS")]
        public virtual string? IndexedFields { get; set; }

        [Column("ISPAID")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPaid { get; set; }

        [Column("ISPRINTED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPrinted { get; set; }

        [Unicode(false)]
        [Column("LOCALFIELDS")]
        public virtual string? LocalFields { get; set; }

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
        [Column("PAIDDATETIME")]
        public virtual string? PaidDateTime { get; set; }

        [Unicode(false)]
        [Column("PRESENSEDATETIME")]
        public virtual string? PresenseDateTime { get; set; }

        [Unicode(false)]
        [Column("PRINTDATE")]
        public virtual string? PrintDate { get; set; }

        [Unicode(false)]
        [Column("REGISTEREDDATE")]
        public virtual string? RegisteredDate { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASEDESCRIPTION")]
        public virtual string? RelatedCaseDescription { get; set; }

        [Unicode(false)]
        [Column("REQUESTTEXT")]
        public virtual string? RequestText { get; set; }

        [Unicode(false)]
        [Column("SENDEDDATE")]
        public virtual string? SendedDate { get; set; }

        [Unicode(false)]
        [Column("SIDENOTE")]
        public virtual string? SideNote { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.AdvertisingState? State { get; set; }

        [ForeignKey("CREATORUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheCreatorUnit { get; set; }

        [InverseProperty("TheGAdvertising")]
        public virtual List<Anu.BaseInfo.DataModel.Advertising.GAdvertisingCase>? TheGAdvertisingCaseList { get; set; }

        [InverseProperty("TheGAdvertising")]
        public virtual List<Anu.BaseInfo.DataModel.Advertising.GAdvertisingRelatedDoc>? TheGAdvertisingRelatedDocList { get; set; }

        [ForeignKey("GADVERTISINGSUBJECTTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.GAdvertisingSubjectType? TheGAdvertisingSubjectType { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

    }

    [Table("GADVERTISING")]
    public partial class GAdvertising : GAdvertisingBase
    {
    }
    }