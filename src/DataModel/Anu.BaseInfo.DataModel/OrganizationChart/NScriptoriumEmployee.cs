

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.OrganizationChart
{
    public abstract class NScriptoriumEmployeeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("EMAIL")]
        public virtual string? Email { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("FIRSTNAME")]
        public virtual string? FirstName { get; set; }

        [Column("GRADE")]
        public virtual Anu.BaseInfo.Enumerations.ScriptoriumEmployeePosition? Grade { get; set; }

        [Unicode(false)]
        [Column("HOMEADDRESS")]
        public virtual string? HomeAddress { get; set; }

        [Unicode(false)]
        [Column("IDENTITYNO")]
        public virtual string? IdentityNo { get; set; }

        [Unicode(false)]
        [Column("LASTNAME")]
        public virtual string? LastName { get; set; }

        [Unicode(false)]
        [Column("MOBILE")]
        public virtual string? Mobile { get; set; }

        [Unicode(false)]
        [Column("NATIONALITYCODE")]
        public virtual string? NationalityCode { get; set; }

        [Unicode(false)]
        [Column("NICKNAME")]
        public virtual string? NickName { get; set; }

        [Column("RELIGION")]
        public virtual Anu.BaseInfo.Enumerations.Religion? Religion { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [InverseProperty("TheNotary1AssistantCurrent")]
        public virtual List<Anu.BaseInfo.DataModel.OrganizationChart.NScriptorium>? TheNotary1AssistantCurrentList { get; set; }

        [InverseProperty("TheNotary2AssistantCurrent")]
        public virtual List<Anu.BaseInfo.DataModel.OrganizationChart.NScriptorium>? TheNotary2AssistantCurrentList { get; set; }

        [InverseProperty("TheNotaryCurrent")]
        public virtual List<Anu.BaseInfo.DataModel.OrganizationChart.NScriptorium>? TheNotaryCurrentList { get; set; }

        [InverseProperty("TheNotaryFirstAssistant")]
        public virtual List<Anu.BaseInfo.DataModel.OrganizationChart.NScriptorium>? TheNotaryFirstAssistantList { get; set; }

        [InverseProperty("TheNotary")]
        public virtual List<Anu.BaseInfo.DataModel.OrganizationChart.NScriptorium>? TheNotaryList { get; set; }

        [InverseProperty("TheNotarySecondAssistant")]
        public virtual List<Anu.BaseInfo.DataModel.OrganizationChart.NScriptorium>? TheNotarySecondAssistantList { get; set; }

    }

    [Table("NSCRIPTORIUMEMPLOYEE")]
    public partial class NScriptoriumEmployee : NScriptoriumEmployeeBase
    {
    }
    }