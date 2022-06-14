

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class GNewspaperBase : BaseInfoEntity<string>
    {

		[Column("CERTIFICATETYPE")]
		public virtual Rad.CMS.Enumerations.NewspaperCertificateType? CertificateType { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ERSHADCODE")]
		public virtual string? ErshadCode { get; set; }

		[Column("GROUPLEVEL")]
		public virtual Rad.CMS.Enumerations.NewspaperGroupLevel? GroupLevel { get; set; }

		[Column("PERIOD")]
		public virtual Rad.CMS.Enumerations.NewspaperPeriod? Period { get; set; }

		[Column("PRINTAREA")]
		public virtual Rad.CMS.Enumerations.NewspaperPrintArea? PrintArea { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheGNewspaper")]
		public virtual List<Rad.BaseInfo.Types.GNewspaperUnit>? TheGNewspaperUnitList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GNEWSPAPER")]
    public partial class GNewspaper : GNewspaperBase { }

    }


