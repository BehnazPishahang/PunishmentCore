﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class ChangeLogBase : BaseInfoEntity<string>
    {

        [Column("CHANGEDATETIME")]
        public virtual string? ChangeDateTime { get; set; }

        [Column("COMPUTERNAME")]
        public virtual string? ComputerName { get; set; }

        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("MILISECOND")]
        public virtual string? MiliSecond { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectId { get; set; }

        [InverseProperty("TheChangeLog")]
        public virtual List<Anu.BaseInfo.DataModel.DBLoging.ChangeLogCase>? TheChangeLogCaseList { get; set; }

        [InverseProperty("TheChangeLog")]
        public virtual List<Anu.BaseInfo.DataModel.DBLoging.ChangeLogMainDoc>? TheChangeLogMainDocList { get; set; }

        [ForeignKey("CURRENTORGID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheCurrentOrg { get; set; }

        [ForeignKey("CURRENTOUTORGID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheCurrentOutOrg { get; set; }

        [ForeignKey("GFESUSERACCESSID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [ForeignKey("RELATEDSYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedSystemForm { get; set; }

    }

    [Table("CHANGELOG")]
    public partial class ChangeLog : ChangeLogBase
    {
    }
}