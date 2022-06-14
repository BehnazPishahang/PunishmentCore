

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GRequestReferBase : BaseInfoEntity<string>
    {

		[Column("RECEIVERTEXT")]
		public virtual string? ReceiverText { get; set; }

		[Column("REFERDESCRIPTION")]
		public virtual string? ReferDescription { get; set; }

		[Column("REFERNO")]
		public virtual decimal? ReferNo { get; set; }

		[Column("REFERTIME")]
		public virtual string? ReferTime { get; set; }

		[Column("SENDERTEXT")]
		public virtual string? SenderText { get; set; }

		[ForeignKey("FIRSTREFERROLEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheFirstReferRole { get; set; }

		[ForeignKey("FROMSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheFromStep { get; set; }

		[ForeignKey("GPROCESSSTEPREFERTEXTID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStepReferText? TheGProcessStepReferText { get; set; }

		[ForeignKey("GREQUESTID")]
		public virtual Rad.BaseInfo.GProcess.GRequest? TheGRequest { get; set; }

		[InverseProperty("TheGRequestRefer")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestAction>? TheGRequestActionList { get; set; }

		[InverseProperty("TheGRequestRefer")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestArgumentValue>? TheGRequestArgumentValueList { get; set; }

		[ForeignKey("RECEIVERCMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheReceiverCmsOrganization { get; set; }

		[ForeignKey("REFERFROMID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheReferFrom { get; set; }

		[ForeignKey("REFERTOID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheReferTo { get; set; }

		[ForeignKey("SECONDREFERROLEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheSecondReferRole { get; set; }

		[ForeignKey("TOSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheToStep { get; set; }

    }
    [Table("GREQUESTREFER")]
    public partial class GRequestRefer : GRequestReferBase { }

    }


