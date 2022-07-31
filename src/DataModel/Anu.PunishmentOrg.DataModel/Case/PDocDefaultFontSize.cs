

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PDocDefaultFontSizeBase : PunishmentOrgEntity<string>
    {

        [Column("FONTSIZE")]
        public virtual long? FontSize { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PDOCDEFAULTFONTSIZE")]
    public partial class PDocDefaultFontSize : PDocDefaultFontSizeBase
    {
    }
    }