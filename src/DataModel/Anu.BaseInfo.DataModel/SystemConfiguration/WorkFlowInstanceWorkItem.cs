﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class WorkFlowInstanceWorkItemBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ACTIVATEDATE")]
        public virtual string? ActivateDate { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("KEYFIELD1")]
        public virtual string? KeyField1 { get; set; }

        [Unicode(false)]
        [Column("KEYFIELD2")]
        public virtual string? KeyField2 { get; set; }

        [Unicode(false)]
        [Column("LASTACTIONDATETIME")]
        public virtual string? LastActionDateTime { get; set; }

        [Unicode(false)]
        [Column("MAXDELAYDATE")]
        public virtual string? MaxDelayDate { get; set; }

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

        [Unicode(false)]
        [Column("SECURITYORGANIZATIONID")]
        public virtual string? SecurityOrganizationId { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowActivityInstanceState? State { get; set; }

        [ForeignKey("BASEROLEID")]
        public virtual Anu.BaseInfo.DataModel.Security.Role.BaseRole? TheBaseRole { get; set; }

        [ForeignKey("CREATORUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheCreatorUser { get; set; }

        [ForeignKey("CREATORWORKITEMID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.WorkFlowInstanceWorkItem? TheCreatorWorkItem { get; set; }

        [ForeignKey("PERFORMERUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? ThePerformerUser { get; set; }

        [ForeignKey("RELATEDCMSUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheRelatedCMSUser { get; set; }

        [ForeignKey("RELATEDCMSUSERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheRelatedCMSUserRoleType { get; set; }

        [ForeignKey("RELATEDDOCFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedDocForm { get; set; }

        [ForeignKey("RELATEDDOCOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedDocObject { get; set; }

        [ForeignKey("RELATEDSYSTEMOBJECTCASEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedSystemObjectCase { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Column("TYPE")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowWorkItemType? Type { get; set; }

        [Column("USERCANDELAY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? UserCanDelay { get; set; }

        }

    [Table("WORKFLOWINSTANCEWORKITEM")]
    public partial class WorkFlowInstanceWorkItem : WorkFlowInstanceWorkItemBase
    {
    }
    }