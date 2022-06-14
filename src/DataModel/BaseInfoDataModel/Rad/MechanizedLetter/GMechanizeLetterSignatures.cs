

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMechanizeLetterSignaturesBase : BaseInfoEntity<string>
    {

		[Column("ACTIONDATETIME")]
		public virtual string? ActionDateTime { get; set; }

		[Column("ACTIONLEVEL")]
		public virtual Rad.CMS.Enumerations.MechanizeLetterActionLevel? ActionLevel { get; set; }

		[Column("SIGNATUREDUSERNAME")]
		public virtual string? SignaturedUserName { get; set; }

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

    }
    [Table("GMECHANIZELETTERSIGNATURES")]
    public partial class GMechanizeLetterSignatures : GMechanizeLetterSignaturesBase { }

    }


