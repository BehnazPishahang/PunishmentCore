

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Explorer
{
    public abstract class ExplorerNodeTransitionBase : BaseInfoEntity<string>
    {

		[Column("ORDERNO")]
		public virtual decimal? OrderNo { get; set; }

		[Column("ORDERTEMPLATE")]
		public virtual string? OrderTemplate { get; set; }

		[InverseProperty("TheExplorerNodeTransition")]
		public virtual List<Rad.Explorer.ExplorerTransitionCondition>? TheExplorerTransitionConditionList { get; set; }

		[ForeignKey("EXPLORERNODETRANSITIONID")]
		public virtual List<Rad.Explorer.ExplorerTransParamSetting>? TheExplorerTransParamSettingList { get; set; }

		[ForeignKey("EXPLORERNODETRANSITIONID")]
		public virtual List<Rad.Explorer.ExplorerTransVariableRename>? TheExplorerTransVariableRenameList { get; set; }

		[ForeignKey("SOURCENODEID")]
		public virtual Rad.Explorer.ExplorerNode? TheSourceNode { get; set; }

		[ForeignKey("TARGETNODEID")]
		public virtual Rad.Explorer.ExplorerNode? TheTargetNode { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("EXPLORERNODETRANSITION")]
    public partial class ExplorerNodeTransition : ExplorerNodeTransitionBase { }

    }


