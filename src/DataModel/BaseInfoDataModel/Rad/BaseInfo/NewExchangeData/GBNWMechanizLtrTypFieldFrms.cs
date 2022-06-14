

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.NewExchangeData
{
    public abstract class GBNWMechanizLtrTypFieldFrmsBase : BaseInfoEntity<string>
    {

		[Column("ATTRIBUTEENGLISHNAME")]
		public virtual string? AttributeEnglishName { get; set; }

		[Column("RELATIONATTRIBUTEENGLISHNAME")]
		public virtual string? RelationAttributeEnglishName { get; set; }

		[Column("RELATIONATTRIBUTEWITHRELCLASS")]
		public virtual string? RelationAttributeWithRelClass { get; set; }

		[Column("SOURCETYPE")]
		public virtual Rad.CMS.Enumerations.MechanizeLetterFieldSourceType? SourceType { get; set; }

		[ForeignKey("GBNWMECHANIZEDLTRTYPEFIELDID")]
		public virtual Rad.BaseInfo.NewExchangeData.GBNWMechanizedLtrTypeField? TheGBNWMechanizedLtrTypeField { get; set; }

		[ForeignKey("MAINCLASSID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheMainClass { get; set; }

		[ForeignKey("RELATEDCLASSID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedClass { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("GBNWMECHANIZLTRTYPFIELDFRMS")]
    public partial class GBNWMechanizLtrTypFieldFrms : GBNWMechanizLtrTypFieldFrmsBase { }

    }


