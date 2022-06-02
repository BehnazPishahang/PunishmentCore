using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PunishmentOrg.Api.Core.Domain.Classes.Anu.BaseInfo.OrganizationChart
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