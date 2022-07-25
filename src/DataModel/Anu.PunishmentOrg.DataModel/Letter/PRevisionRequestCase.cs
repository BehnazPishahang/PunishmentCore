

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PRevisionRequestCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PREVISIONREQUESTID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PRevisionRequest? ThePRevisionRequest { get; set; }

    }

    [Table("PREVISIONREQUESTCASE")]
    public partial class PRevisionRequestCase : PRevisionRequestCaseBase
    {
    }
}