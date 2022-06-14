

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.OrganizationChart
{
    public abstract class ScriptoriumImageBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("IMAGETYPE")]
		public virtual decimal? ImageType { get; set; }

		[Column("LASTDATETIME")]
		public virtual string? LastDateTime { get; set; }

		[Column("PICTURE")]
		public virtual byte[]? Picture { get; set; }

		[Column("SCRIPTORIUMID")]
		public virtual string? ScriptoriumId { get; set; }

    }
    [Table("SCRIPTORIUMIMAGE")]
    public partial class ScriptoriumImage : ScriptoriumImageBase { }

    }


