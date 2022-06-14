

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Explorer
{
    public abstract class ExplorerNodeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DISPLAYSCRIPT")]
		public virtual string? DisplayScript { get; set; }

		[Column("NODETYPE")]
		public virtual Rad.CMS.Enumerations.ExpNodeType? NodeType { get; set; }

		[Column("PERFORMERSCRIPT")]
		public virtual string? PerformerScript { get; set; }

		[InverseProperty("TheExplorerNode")]
		public virtual List<Rad.Explorer.ExplorerNodeCondition>? TheExplorerNodeConditionList { get; set; }

		[ForeignKey("EXPLORERNODEID")]
		public virtual List<Rad.Explorer.ExplorerNodeInputParam>? TheExplorerNodeInputParamList { get; set; }

		[InverseProperty("TheSourceNode")]
		public virtual List<Rad.Explorer.ExplorerNodeTransition>? TheExplorerNodeTransitionList { get; set; }

		[ForeignKey("EXPLORERNODEID")]
		public virtual List<Rad.Explorer.ExplorerVariable>? TheExplorerVariableList { get; set; }

		[ForeignKey("ICONID")]
		public virtual Rad.Explorer.ExplorerNodeIcon? TheIcon { get; set; }

		[ForeignKey("SELECTEDICONID")]
		public virtual Rad.Explorer.ExplorerNodeIcon? TheSelectedIcon { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("EXPLORERNODE")]
    public partial class ExplorerNode : ExplorerNodeBase { }

    }


