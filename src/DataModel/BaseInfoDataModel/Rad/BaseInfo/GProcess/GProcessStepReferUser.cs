

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessStepReferUserBase : BaseInfoEntity<string>
    {

		[Column("ADDATTACHPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddAttachPermission { get; set; }

		[Column("ADDLETTERPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddLetterPermission { get; set; }

		[Column("ADDPAYMENTPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddPaymentPermission { get; set; }

		[Column("ADDRELATEDDATAPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddRelatedDataPermission { get; set; }

		[Column("ADDRELATEDPERSONPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddRelatedPersonPermission { get; set; }

		[Column("CHANGEATTACHPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeAttachPermission { get; set; }

		[Column("CHANGELETTERPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeLetterPermission { get; set; }

		[Column("CHANGEPAYMENTPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangePaymentPermission { get; set; }

		[Column("CHANGERELATEDDATAPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeRelatedDataPermission { get; set; }

		[Column("CHANGERELATEDPERSONPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeRelatedPersonPermission { get; set; }

		[Column("REFERTOOTHERSTEPPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ReferToOtherStepPermission { get; set; }

		[Column("REMOVEATTACHPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? RemoveAttachPermission { get; set; }

		[Column("REMOVELETTERPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? RemoveLetterPermission { get; set; }

		[Column("REMOVEPAYMENTPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? RemovePaymentPermission { get; set; }

		[Column("REMOVERELATEDDATAPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? RemoveRelatedDataPermission { get; set; }

		[Column("REMOVERELATEDPERSONPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? RemoveRelatedPersonPermission { get; set; }

		[ForeignKey("GPROCESSSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheGProcessStep { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("GPROCESSSTEPREFERUSER")]
    public partial class GProcessStepReferUser : GProcessStepReferUserBase { }

    }


