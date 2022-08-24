using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFActivityBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("DELETEFROMDIAGRAM")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? DeleteFromDiagram { get; set; }

        [Unicode(false)]
        [Column("ENGLISHNAME")]
        public virtual string? EnglishName { get; set; }

        [Unicode(false)]
        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Column("MAXDELAYTIME")]
        public virtual long? MaxDelayTime { get; set; }

        [Column("STEPBACKABLE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? StepBackable { get; set; }

        [ForeignKey("BASEROLEID")]
        public virtual Anu.BaseInfo.DataModel.Security.Role.BaseRole? TheBaseRole { get; set; }

        [InverseProperty("TheNextActivity")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivityTransition>? TheCurrentActivitiesTransList { get; set; }

        [InverseProperty("TheCurrentActivity")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivityTransition>? TheNextActivitiesTransList { get; set; }

        [InverseProperty("TheWFActivity")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivityEventCreate>? TheWFActivityEventCreateList { get; set; }

        [InverseProperty("TheWFActivity")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivityEventFunc>? TheWFActivityEventFuncList { get; set; }

        [InverseProperty("TheWFActivity")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivityParameter>? TheWFActivityParameterList { get; set; }

        [InverseProperty("TheWFActivity")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivityTransitionFunc>? TheWFActivityTransitionFuncList { get; set; }

        [ForeignKey("WFWORKFLOWID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFWorkflow? TheWFWorkflow { get; set; }

        [Column("TOTALINPUT")]
        public virtual long? TotalInput { get; set; }

        [Column("TYPE")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowActivityType? Type { get; set; }

        [Column("USERCANDELAY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? UserCanDelay { get; set; }

        [Column("USERCHOOSETRANSITION")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? UserChooseTransition { get; set; }

        }

    [Table("WFACTIVITY")]
    public partial class WFActivity : WFActivityBase
    {
    }
    }