

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.ExchangeData
{
    public abstract class GMechanizLtrTypeFieldFormsBase : BaseInfoEntity<string>
    {

		[Column("ATTRIBUTEENGLISHNAME")]
		public virtual string? AttributeEnglishName { get; set; }

		[Column("RELATIONATTRIBUTEENGLISHNAME")]
		public virtual string? RelationAttributeEnglishName { get; set; }

		[Column("RELATIONATTRIBUTEWITHRELCLASS")]
		public virtual string? RelationAttributeWithRelClass { get; set; }

		[ForeignKey("GMECHANIZEDLETTERTYPEFIELDID")]
		public virtual Anu.BaseInfo.ExchangeData.GMechanizedLetterTypeField? TheGMechanizedLetterTypeField { get; set; }

		[ForeignKey("MAINCLASSID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheMainClass { get; set; }

		[ForeignKey("RELATEDCLASSID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheRelatedClass { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("GMECHANIZLTRTYPEFIELDFORMS")]
    public partial class GMechanizLtrTypeFieldForms : GMechanizLtrTypeFieldFormsBase { }

    }


