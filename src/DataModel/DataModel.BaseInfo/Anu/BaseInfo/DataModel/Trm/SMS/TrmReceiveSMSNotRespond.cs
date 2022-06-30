

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Trm.SMS
{
    public abstract class TrmReceiveSMSNotRespondBase : BaseInfoEntity<string>
    {

        [ForeignKey("TRMRECEIVESMSID")]
        public virtual Anu.BaseInfo.DataModel.Trm.SMS.TrmReceiveSMS? TheTrmReceiveSMS { get; set; }

    }

    [Table("TRMRECEIVESMSNOTRESPOND")]
    public partial class TrmReceiveSMSNotRespond : TrmReceiveSMSNotRespondBase
    {
    }
}