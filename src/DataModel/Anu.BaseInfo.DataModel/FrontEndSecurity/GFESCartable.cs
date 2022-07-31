

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESCartableBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DESC1")]
        public virtual string? Desc1 { get; set; }

        [Unicode(false)]
        [Column("DESC2")]
        public virtual string? Desc2 { get; set; }

        [Unicode(false)]
        [Column("DESC3")]
        public virtual string? Desc3 { get; set; }

        [Unicode(false)]
        [Column("LASTACTIONDATETIME")]
        public virtual string? LastActionDateTime { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASEID")]
        public virtual string? RelatedCaseId { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASENO")]
        public virtual string? RelatedCaseNo { get; set; }

        [Unicode(false)]
        [Column("RELATEDDOCID")]
        public virtual string? RelatedDocId { get; set; }

        [Unicode(false)]
        [Column("RELATEDDOCNO")]
        public virtual string? RelatedDocNo { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowActivityInstanceState? State { get; set; }

        [ForeignKey("ACCESSUSERID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser? TheAccessUser { get; set; }

        [ForeignKey("ACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.Security.Role.BaseRole? TheActivity { get; set; }

        [ForeignKey("CREATORUSERID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser? TheCreatorUser { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

        [ForeignKey("NAJAUNITID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

        [ForeignKey("PERFORMERUSERID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser? ThePerformerUser { get; set; }

        [ForeignKey("RELATEDFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedForm { get; set; }

        [ForeignKey("RELATEDSYSOBJECTCASEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedSysObjectCase { get; set; }

        [ForeignKey("RELATEDSYSOBJECTDOCID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedSysObjectDoc { get; set; }

    }

    [Table("GFESCARTABLE")]
    public partial class GFESCartable : GFESCartableBase
    {
    }
    }