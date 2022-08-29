using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.ExchangeData
{
    public abstract class GMechanizLtrTypeFieldFormsBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ATTRIBUTEENGLISHNAME")]
        public virtual string? AttributeEnglishName { get; set; }

        [Unicode(false)]
        [Column("RELATIONATTRIBUTEENGLISHNAME")]
        public virtual string? RelationAttributeEnglishName { get; set; }

        [Unicode(false)]
        [Column("RELATIONATTRIBUTEWITHRELCLASS")]
        public virtual string? RelationAttributeWithRelClass { get; set; }

        [ForeignKey("GMECHANIZEDLETTERTYPEFIELDID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterTypeField? TheGMechanizedLetterTypeField { get; set; }

        [ForeignKey("MAINCLASSID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheMainClass { get; set; }

        [ForeignKey("RELATEDCLASSID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedClass { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        }

    [Table("GMECHANIZLTRTYPEFIELDFORMS")]
    public partial class GMechanizLtrTypeFieldForms : GMechanizLtrTypeFieldFormsBase
    {
    }
    }