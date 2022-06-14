

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GCmsReferGroupBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheGCmsReferGroup")]
		public virtual List<Rad.BaseInfo.GProcess.GCmsReferGroupDetail>? TheGCmsReferGroupDetailList { get; set; }

		[InverseProperty("TheGCmsReferGroup")]
		public virtual List<Rad.BaseInfo.GProcess.GProseccStepAndGroupRelation>? TheGProseccStepAndGroupRelationList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GCMSREFERGROUP")]
    public partial class GCmsReferGroup : GCmsReferGroupBase { }

    }


