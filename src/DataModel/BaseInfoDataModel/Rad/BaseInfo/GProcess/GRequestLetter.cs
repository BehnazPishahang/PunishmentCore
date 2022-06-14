

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GRequestLetterBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("LETTERTITLE")]
		public virtual string? LetterTitle { get; set; }

		[Column("LETTERTYPE")]
		public virtual Rad.CMS.Enumerations.EstateInputOutput? LetterType { get; set; }

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

		[ForeignKey("GREQUESTID")]
		public virtual Rad.BaseInfo.GProcess.GRequest? TheGRequest { get; set; }

    }
    [Table("GREQUESTLETTER")]
    public partial class GRequestLetter : GRequestLetterBase { }

    }


