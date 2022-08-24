using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.ExchangeData
{
    public abstract class GExchangeUnitTitleBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("ISMECHANIZERELATION")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsMechanizeRelation { get; set; }

        [Column("ORGLOGO")]
        public virtual byte[]? OrgLogo { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheGExchangeUnitTitle")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESNJUnitRelatedUserAccess>? TheGFESNJUnitRelatedUserAccessList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Unicode(false)]
        [Column("WEBSERVICEFULLNAME")]
        public virtual string? WebServiceFullName { get; set; }

        }

    [Table("GEXCHANGEUNITTITLE")]
    public partial class GExchangeUnitTitle : GExchangeUnitTitleBase
    {
    }
    }