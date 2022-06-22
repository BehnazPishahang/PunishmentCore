

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Attachment
{
    public abstract class GAttachmentDataBase : BaseInfoEntity<string>
    {

		[Column("DOCFILE")]
		public virtual byte[]? DocFile { get; set; }

    }
    [Table("GATTACHMENTDATA")]
    public partial class GAttachmentData : GAttachmentDataBase { }

    }


