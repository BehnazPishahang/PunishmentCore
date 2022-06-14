

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMechanizedLetterReferUnitBase : BaseInfoEntity<string>
    {

		[ForeignKey("FROMCMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheFromCMSOrganization { get; set; }

		[ForeignKey("TOCMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheToCMSOrganization { get; set; }

    }
    [Table("GMECHANIZEDLETTERREFERUNIT")]
    public partial class GMechanizedLetterReferUnit : GMechanizedLetterReferUnitBase { }

    }


