

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProseccStepAndGroupRelationBase : BaseInfoEntity<string>
    {

		[ForeignKey("GCMSREFERGROUPID")]
		public virtual Rad.BaseInfo.GProcess.GCmsReferGroup? TheGCmsReferGroup { get; set; }

		[ForeignKey("GPROCESSSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheGProcessStep { get; set; }

    }
    [Table("GPROSECCSTEPANDGROUPRELATION")]
    public partial class GProseccStepAndGroupRelation : GProseccStepAndGroupRelationBase { }

    }


