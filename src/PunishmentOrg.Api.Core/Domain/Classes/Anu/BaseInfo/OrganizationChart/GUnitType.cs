using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PunishmentOrg.Api.Core.Domain.Classes.Anu.BaseInfo.OrganizationChart
{
    [Table("GUNITTYPE")]
    public class GUnitType
    {
        [Key]
        [Column("ID")]
        public string Id { get; set; }

        [Column("CODE")]
        public string Code { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }
    }
}
