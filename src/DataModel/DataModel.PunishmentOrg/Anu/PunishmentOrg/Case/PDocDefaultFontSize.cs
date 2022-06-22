

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PDocDefaultFontSizeBase : PunishmentOrgEntity<string>
    {

		[Column("FONTSIZE")]
		public virtual long? FontSize { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PDOCDEFAULTFONTSIZE")]
    public partial class PDocDefaultFontSize : PDocDefaultFontSizeBase { }

    }


