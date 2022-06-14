

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMLetterTemplateBase : BaseInfoEntity<string>
    {

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("PRIORITY")]
		public virtual decimal? Priority { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GMLETTERTEMPLATE")]
    public partial class GMLetterTemplate : GMLetterTemplateBase { }

    }


