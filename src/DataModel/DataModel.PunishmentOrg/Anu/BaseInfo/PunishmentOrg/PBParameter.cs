

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBParameterBase : PunishmentOrgEntity<string>
    {

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("PARAMDESC")]
		public virtual string? ParamDesc { get; set; }

		[Column("PARAMETERSTRINGVALUE")]
		public virtual string? ParameterStringValue { get; set; }

		[Column("PARAMETERTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUParameter? ParameterType { get; set; }

		[Column("PARAMETERVALUE")]
		public virtual long? ParameterValue { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

    }
    [Table("PBPARAMETER")]
    public partial class PBParameter : PBParameterBase { }

    }


