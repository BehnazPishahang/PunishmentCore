

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class CMSOrganizationBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CMSORGANIZATIONNO")]
		public virtual string? CMSOrganizationNo { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[InverseProperty("TheCMSOrganization")]
		public virtual List<Rad.BaseInfo.SystemConfiguration.ECMSaveMethod>? TheECMSaveMethodList { get; set; }

		[ForeignKey("ECMSERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.ECMServer? TheECMServer { get; set; }

		[InverseProperty("TheCMSOrganization")]
		public virtual List<Rad.BaseInfo.SystemConfiguration.RegisterUserHistory>? TheRegisterUserHistoryList { get; set; }

		[ForeignKey("SCRIPTORIUMID")]
		public virtual Rad.BaseInfo.OrganizationChart.Scriptorium? TheScriptorium { get; set; }

		[ForeignKey("UNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("CMSORGANIZATION")]
    public partial class CMSOrganization : CMSOrganizationBase { }

    }


