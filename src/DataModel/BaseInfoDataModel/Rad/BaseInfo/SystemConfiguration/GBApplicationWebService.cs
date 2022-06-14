

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class GBApplicationWebServiceBase : BaseInfoEntity<string>
    {

		[Column("OWNERORGTYPE")]
		public virtual Rad.CMS.Enumerations.WebServiceOwnerOrg? OwnerOrgType { get; set; }

		[Column("SUBSYSTEMOWNER")]
		public virtual Rad.CMS.Enumerations.Subsystems? SubsystemOwner { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("GBWEBSERVICEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.GBWebService? TheGBWebService { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Rad.BaseInfo.NewExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[Column("WEBSERVICEPATHANDNAME")]
		public virtual string? WebServicePathAndName { get; set; }

    }
    [Table("GBAPPLICATIONWEBSERVICE")]
    public partial class GBApplicationWebService : GBApplicationWebServiceBase { }

    }


