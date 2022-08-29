using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBSpecificDataBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheJBSpecificData")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBSpecificDataValue>? TheJBSpecificDataValueList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        }

    [Table("JBSPECIFICDATA")]
    public partial class JBSpecificData : JBSpecificDataBase
    {
    }
    }