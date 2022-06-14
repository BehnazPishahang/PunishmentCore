

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessStepReferRoleBase : BaseInfoEntity<string>
    {

		[Column("ADDLETTERPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddLetterPermision { get; set; }

		[Column("ADDNEWATTACHPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddNewAttachPermision { get; set; }

		[Column("ADDPAYMENTPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddPaymentPermission { get; set; }

		[Column("ADDRELATEDDATAPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddRelatedDataPermision { get; set; }

		[Column("ADDRELATEDPERSONPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? AddRelatedPersonPermision { get; set; }

		[Column("CHANGEATTACHPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeAttachPermision { get; set; }

		[Column("CHANGELETTERPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeLetterPermission { get; set; }

		[Column("CHANGEPAYMENTPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangePaymentPermission { get; set; }

		[Column("CHANGERELATEDDATAPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeRelatedDataPermission { get; set; }

		[Column("CHANGERELATEDPERSONPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeRelatedPersonPermission { get; set; }

		[Column("DELETEATTACHPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? DeleteAttachPermision { get; set; }

		[Column("REFERTOOTHERSTEPPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ReferToOtherStepPermision { get; set; }

		[Column("REMOVELETTERPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? RemoveLetterPermision { get; set; }

		[Column("REMOVEPAYMENTPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? RemovePaymentPermission { get; set; }

		[Column("REMOVERELATEDDATAPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? RemoveRelatedDataPermission { get; set; }

		[Column("REMOVERELATEDPERSONPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? RemoveRelatedPersonPermission { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("GPROCESSSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheGProcessStep { get; set; }

    }
    [Table("GPROCESSSTEPREFERROLE")]
    public partial class GProcessStepReferRole : GProcessStepReferRoleBase { }

    }


