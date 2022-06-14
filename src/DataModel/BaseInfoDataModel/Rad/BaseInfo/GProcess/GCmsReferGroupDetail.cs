

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GCmsReferGroupDetailBase : BaseInfoEntity<string>
    {

		[Column("REFERTOSCRIPTORIUM")]
		public virtual bool? ReferToScriptorium { get; set; }

		[Column("REFERTOSINGLEUNIT")]
		public virtual bool? ReferToSingleUnit { get; set; }

		[Column("REFERTOUNIT")]
		public virtual bool? ReferToUnit { get; set; }

		[Column("SCRIPTORIUMTYPE")]
		public virtual Rad.CMS.Enumerations.NotaryActivityType? ScriptoriumType { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GCMSREFERGROUPID")]
		public virtual Rad.BaseInfo.GProcess.GCmsReferGroup? TheGCmsReferGroup { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual Rad.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

    }
    [Table("GCMSREFERGROUPDETAIL")]
    public partial class GCmsReferGroupDetail : GCmsReferGroupDetailBase { }

    }


