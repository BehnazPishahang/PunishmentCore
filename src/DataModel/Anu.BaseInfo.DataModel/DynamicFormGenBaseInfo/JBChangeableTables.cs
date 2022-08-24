using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBChangeableTablesBase : BaseInfoEntity<string>
    {

        [ForeignKey("TABLEONEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheTableOne { get; set; }

        [ForeignKey("TABLETWOID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheTableTwo { get; set; }

        }

    [Table("JBCHANGEABLETABLES")]
    public partial class JBChangeableTables : JBChangeableTablesBase
    {
    }
    }