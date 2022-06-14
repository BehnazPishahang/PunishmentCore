

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GTransitionControlerBase : BaseInfoEntity<string>
    {

		[Column("ASSEMBLYNAME")]
		public virtual string? AssemblyName { get; set; }

		[Column("CLASSNAME")]
		public virtual string? ClassName { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[InverseProperty("TheGTransitionControler")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessStepTransition>? TheGProcessStepTransitionList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GTRANSITIONCONTROLER")]
    public partial class GTransitionControler : GTransitionControlerBase { }

    }


