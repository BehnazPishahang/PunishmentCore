

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBParameterBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Unicode(false)]
        [Column("PARAMDESC")]
        public virtual string? ParamDesc { get; set; }

        [Unicode(false)]
        [Column("PARAMETERSTRINGVALUE")]
        public virtual string? ParameterStringValue { get; set; }

        [Column("PARAMETERTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUParameter? ParameterType { get; set; }

        [Column("PARAMETERVALUE")]
        public virtual long? ParameterValue { get; set; }

        [Unicode(false)]
        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

    }

    [Table("PBPARAMETER")]
    public partial class PBParameter : PBParameterBase
    {
    }
    }