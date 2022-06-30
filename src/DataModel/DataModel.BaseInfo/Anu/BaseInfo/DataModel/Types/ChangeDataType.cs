﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class ChangeDataTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("CHANGEDATATYPE")]
    public partial class ChangeDataType : ChangeDataTypeBase
    {
    }
}