

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart
{
    public abstract class NScriptoriumEmployeeBase : BaseInfoEntity<string>
    {

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("EMAIL")]
		public virtual string? Email { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("FIRSTNAME")]
		public virtual string? FirstName { get; set; }

		[Column("GRADE")]
		public virtual Anu.Enumerations.ScriptoriumEmployeePosition? Grade { get; set; }

		[Column("HOMEADDRESS")]
		public virtual string? HomeAddress { get; set; }

		[Column("IDENTITYNO")]
		public virtual string? IdentityNo { get; set; }

		[Column("LASTNAME")]
		public virtual string? LastName { get; set; }

		[Column("MOBILE")]
		public virtual string? Mobile { get; set; }

		[Column("NATIONALITYCODE")]
		public virtual string? NationalityCode { get; set; }

		[Column("NICKNAME")]
		public virtual string? NickName { get; set; }

		[Column("RELIGION")]
		public virtual Anu.Enumerations.Religion? Religion { get; set; }

		[Column("SEX")]
		public virtual Anu.Enumerations.SexType? Sex { get; set; }

		[InverseProperty("TheNotary1AssistantCurrent")]
		public virtual List<Anu.BaseInfo.OrganizationChart.NScriptorium>? TheNotary1AssistantCurrentList { get; set; }

		[InverseProperty("TheNotary2AssistantCurrent")]
		public virtual List<Anu.BaseInfo.OrganizationChart.NScriptorium>? TheNotary2AssistantCurrentList { get; set; }

		[InverseProperty("TheNotaryCurrent")]
		public virtual List<Anu.BaseInfo.OrganizationChart.NScriptorium>? TheNotaryCurrentList { get; set; }

		[InverseProperty("TheNotaryFirstAssistant")]
		public virtual List<Anu.BaseInfo.OrganizationChart.NScriptorium>? TheNotaryFirstAssistantList { get; set; }

		[InverseProperty("TheNotary")]
		public virtual List<Anu.BaseInfo.OrganizationChart.NScriptorium>? TheNotaryList { get; set; }

		[InverseProperty("TheNotarySecondAssistant")]
		public virtual List<Anu.BaseInfo.OrganizationChart.NScriptorium>? TheNotarySecondAssistantList { get; set; }

    }
    [Table("NSCRIPTORIUMEMPLOYEE")]
    public partial class NScriptoriumEmployee : NScriptoriumEmployeeBase { }

    }


