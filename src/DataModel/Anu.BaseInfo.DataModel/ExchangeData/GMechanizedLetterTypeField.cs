using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.ExchangeData
{
    public abstract class GMechanizedLetterTypeFieldBase : BaseInfoEntity<string>
    {

        [Column("CHANGEDFILEDDATATYPE")]
        public virtual Anu.BaseInfo.Enumerations.ChangedFiledDataType? ChangedFiledDataType { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("ISMANDATORY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsMandatory { get; set; }

        [Column("MECHANIZEDFIELDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MechanizedFieldType? MechanizedFieldType { get; set; }

        [ForeignKey("GMECHANIZEDLETTERTYPEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterType? TheGMechanizedLetterType { get; set; }

        [InverseProperty("TheGMechanizedLetterTypeField")]
        public virtual List<Anu.BaseInfo.DataModel.ExchangeData.GMechanizLtrTypeFieldForms>? TheGMechanizLtrTypeFieldFormsList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        }

    [Table("GMECHANIZEDLETTERTYPEFIELD")]
    public partial class GMechanizedLetterTypeField : GMechanizedLetterTypeFieldBase
    {
    }
    }