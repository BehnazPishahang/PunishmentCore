

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Notice
{
    public abstract class GNoticeDefectBase : BaseInfoEntity<string>
    {

		[ForeignKey("DEFECTITEMTYPEID")]
		public virtual Rad.BaseInfo.Types.DefectItemType? TheDefectItemType { get; set; }

    }
    [Table("GNOTICEDEFECT")]
    public partial class GNoticeDefect : GNoticeDefectBase { }

    }


