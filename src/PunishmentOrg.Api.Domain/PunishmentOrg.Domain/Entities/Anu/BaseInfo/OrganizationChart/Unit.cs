using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.Domain.Entities.Anu.BaseInfo.OrganizationChart
{
    [Table("UNIT")]
    public class Unit
    {
        [Key]
        [Column("ID")]
        public string Id { get; set; }

        [ForeignKey("PARENTUNITID")]
        public ICollection<Unit> TheUnitList { get; set; }

        [ForeignKey("GUNITTYPEID")]
        public GUnitType TheGUnitType { get; set; }
    }
}
