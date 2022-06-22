

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBViolationTypeInspectionBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBINSPECTIONVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBInspectionViolationType? ThePBInspectionViolationType { get; set; }

		[ForeignKey("PBVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBViolationType? ThePBViolationType { get; set; }

    }
    [Table("PBVIOLATIONTYPEINSPECTION")]
    public partial class PBViolationTypeInspection : PBViolationTypeInspectionBase { }

    }


