

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class NewspapersBase : BaseInfoEntity<string>
    {

		[Column("CERTIFICATETYPE")]
		public virtual Rad.CMS.Enumerations.NewspaperCertificateType? CertificateType { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("GROUPLEVEL")]
		public virtual Rad.CMS.Enumerations.NewspaperGroupLevel? GroupLevel { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("PERIOD")]
		public virtual Rad.CMS.Enumerations.NewspaperPeriod? Period { get; set; }

		[Column("PRINTAREA")]
		public virtual Rad.CMS.Enumerations.NewspaperPrintArea? PrintArea { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("GNEWSPAPERID")]
		public virtual Rad.BaseInfo.Types.GNewspaper? TheGNewspaper { get; set; }

		[ForeignKey("NEWSPAPERGEOLOCATIONID")]
		public virtual Rad.BaseInfo.Types.NewspaperGeoLocation? TheNewspaperGeoLocation { get; set; }

    }
    [Table("NEWSPAPERS")]
    public partial class Newspapers : NewspapersBase { }

    }


