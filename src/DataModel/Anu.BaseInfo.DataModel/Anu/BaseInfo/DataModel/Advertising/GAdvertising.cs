

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Advertising
{
    public abstract class GAdvertisingBase : BaseInfoEntity<string>
    {

        [Column("ACCESSNO")]
        public virtual string? AccessNo { get; set; }

        [Column("ADVERTISINGBUG")]
        public virtual string? AdvertisingBug { get; set; }

        [Column("ADVERTISINGCOST")]
        public virtual Anu.BaseInfo.Enumerations.HaveNoHave? AdvertisingCost { get; set; }

        [Column("ADVERTISINGDATE")]
        public virtual string? AdvertisingDate { get; set; }

        [Column("ADVERTISINGNUMBER")]
        public virtual long? AdvertisingNumber { get; set; }

        [Column("ADVERTISINGPRINTFILE")]
        public virtual byte[]? AdvertisingPrintFile { get; set; }

        [Column("ADVERTISINGTEXT")]
        public virtual string? AdvertisingText { get; set; }

        [Column("CONFIRMEDDATE")]
        public virtual string? ConfirmedDate { get; set; }

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("INDEXEDFIELDS")]
        public virtual string? IndexedFields { get; set; }

        [Column("ISPAID")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPaid { get; set; }

        [Column("ISPRINTED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPrinted { get; set; }

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