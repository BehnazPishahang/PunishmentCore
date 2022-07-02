

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemTemplateVariableBase : BaseInfoEntity<string>
    {

        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Column("FARSIPATH")]
        public virtual string? FarsiPath { get; set; }

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