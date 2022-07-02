

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemObjectBase : BaseInfoEntity<string>
    {

        [Column("ASSEMBLYNAME")]
        public virtual string? AssemblyName { get; set; }

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("ENGLISHNAME")]
        public virtual string? EnglishName { get; set; }

        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Column("ROSEID")]
        public virtual string? RoseId { get; set; }

        [Column("SYSTEMOBJECTTYPE")]
        public virtual Anu.BaseInfo.Enumerations.SystemObjectType? SystemObjectType { get; set; }

    }

    [Table("SYSTEMOBJECT")]
    public partial class SystemObject : SystemObjectBase
    {
    }
}