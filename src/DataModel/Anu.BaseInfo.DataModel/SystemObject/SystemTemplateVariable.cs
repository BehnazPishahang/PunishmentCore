using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemTemplateVariableBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Unicode(false)]
        [Column("FARSIPATH")]
        public virtual string? FarsiPath { get; set; }

        [Unicode(false)]
        [Column("LATINPATH")]
        public virtual string? LatinPath { get; set; }

        [Column("TYPE")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowDataType? Type { get; set; }

        }

    [Table("SYSTEMTEMPLATEVARIABLE")]
    public partial class SystemTemplateVariable : SystemTemplateVariableBase
    {
    }
    }