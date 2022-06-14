

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMechanizedLetterCaseTypeBase : BaseInfoEntity<string>
    {

		[InverseProperty("TheGMechanizedLetterCaseType")]
		public virtual List<Rad.MechanizedLetter.GMechanizedLetterCase>? TheGMechanizedLetterCaseList { get; set; }

		[ForeignKey("GMLETTERSERVICEID")]
		public virtual Rad.MechanizedLetter.GMLetterService? TheGMLetterService { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GMECHANIZEDLETTERCASETYPE")]
    public partial class GMechanizedLetterCaseType : GMechanizedLetterCaseTypeBase { }

    }


