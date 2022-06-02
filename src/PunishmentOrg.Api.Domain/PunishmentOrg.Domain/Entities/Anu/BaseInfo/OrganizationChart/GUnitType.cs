using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.Domain.Entities.Anu.BaseInfo.OrganizationChart
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
