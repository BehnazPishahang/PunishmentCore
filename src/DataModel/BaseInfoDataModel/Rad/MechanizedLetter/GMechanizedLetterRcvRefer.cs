

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMechanizedLetterRcvReferBase : BaseInfoEntity<string>
    {

		[ForeignKey("GMECHANIZEDLETTERREFERID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetterRefer? TheGMechanizedLetterRefer { get; set; }

		[Column("WORKFLOWINSTANCEWORKITEMID")]
		public virtual string? WorkFlowInstanceWorkItemId { get; set; }

    }
    [Table("GMECHANIZEDLETTERRCVREFER")]
    public partial class GMechanizedLetterRcvRefer : GMechanizedLetterRcvReferBase { }

    }


