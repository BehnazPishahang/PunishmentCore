

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class GWebServiceCallLogBase : BaseInfoEntity<string>
    {

		[Column("CALLADDRESS")]
		public virtual string? CallAddress { get; set; }

		[Column("CALLDATETIME")]
		public virtual string? CallDateTime { get; set; }

		[Column("LOGCALLTYPE")]
		public virtual Rad.CMS.Enumerations.WebServiceCallType? LogCallType { get; set; }

		[Column("MILISECOND")]
		public virtual decimal? MiliSecond { get; set; }

		[ForeignKey("GBAPPLICATIONWEBSERVICEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.GBApplicationWebService? TheGBApplicationWebService { get; set; }

		[InverseProperty("TheGWebServiceCallLog")]
		public virtual List<Rad.DBLoging.GWebServiceCallLogParam>? TheGWebServiceCallLogParamList { get; set; }

    }
    [Table("GWEBSERVICECALLLOG")]
    public partial class GWebServiceCallLog : GWebServiceCallLogBase { }

    }


