using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemObjectBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ASSEMBLYNAME")]
        public virtual string? AssemblyName { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("ENGLISHNAME")]
        public virtual string? EnglishName { get; set; }

        [Unicode(false)]
        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Unicode(false)]
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