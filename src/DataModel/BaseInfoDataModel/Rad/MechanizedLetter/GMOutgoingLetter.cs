

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMOutgoingLetterBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("RECEIVERTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizeRefererType? ReceiverType { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("EMPLOYEEID")]
		public virtual Rad.BaseInfo.OrganizationChart.Employee? TheEmployee { get; set; }

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

		[ForeignKey("UNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("TRANSCRIPTTEXT")]
		public virtual string? TranscriptText { get; set; }

    }
    [Table("GMOUTGOINGLETTER")]
    public partial class GMOutgoingLetter : GMOutgoingLetterBase { }

    }


