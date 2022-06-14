

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.WorkFlow.Cartable
{
    public abstract class CartableBase : BaseInfoEntity<string>
    {

		[Column("ACTIVATEDATE")]
		public virtual string? ActivateDate { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("LASTACTIONDATETIME")]
		public virtual string? LastActionDateTime { get; set; }

		[Column("MAXDELAYDATE")]
		public virtual string? MaxDelayDate { get; set; }

		[Column("RELATEDNOTICEDOCNO")]
		public virtual string? RelatedNoticeDocNo { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectID { get; set; }

		[ForeignKey("CARTABLESTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheCartableState { get; set; }

		[ForeignKey("DOCSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheDocState { get; set; }

		[ForeignKey("RELATEDSYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedSystemForm { get; set; }

		[ForeignKey("RELATEDSYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("USERCANDELAY")]
		public virtual Rad.CMS.Enumerations.YesNo? UserCanDelay { get; set; }

    }
    [Table("CARTABLE")]
    public partial class Cartable : CartableBase { }

    }


