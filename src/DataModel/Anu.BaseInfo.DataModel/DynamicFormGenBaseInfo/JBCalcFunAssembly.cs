using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBCalcFunAssemblyBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ASSEMBLYNAME")]
        public virtual string? AssemblyName { get; set; }

        [Column("CALCFUNCTYPE")]
        public virtual Anu.BaseInfo.Enumerations.CalcFuncType? CalcFuncType { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("FULLNAME")]
        public virtual string? FullName { get; set; }

        [Column("ITEMTYPE")]
        public virtual Anu.BaseInfo.Enumerations.TypeValue? ItemType { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        }

    [Table("JBCALCFUNASSEMBLY")]
    public partial class JBCalcFunAssembly : JBCalcFunAssemblyBase
    {
    }
    }