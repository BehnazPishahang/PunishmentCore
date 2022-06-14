

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.ExchangeData
{
    public abstract class ExchangeFieldBetweenOrgBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDFILEDDATATYPE")]
		public virtual Rad.CMS.Enumerations.ChangedFiledDataType? ChangedFiledDataType { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("EXCHANGEFIELDBETWEENORG")]
    public partial class ExchangeFieldBetweenOrg : ExchangeFieldBetweenOrgBase { }

    }


