

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class BehdadCodeStructureBase : BaseInfoEntity<string>
    {

		[Column("EXECUTIVECODE")]
		public virtual string? ExecutiveCode { get; set; }

		[Column("IDTYPE")]
		public virtual string? IdType { get; set; }

		[Column("INCOMEROW")]
		public virtual string? IncomeRow { get; set; }

		[Column("MOEINCODE")]
		public virtual string? MoeinCode { get; set; }

		[Column("OSTAN")]
		public virtual string? Ostan { get; set; }

		[Column("SHEBANO")]
		public virtual string? ShebaNo { get; set; }

    }
    [Table("BEHDADCODESTRUCTURE")]
    public partial class BehdadCodeStructure : BehdadCodeStructureBase { }

    }


