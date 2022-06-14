

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.OrganizationChart
{
    public abstract class NScriptoriumBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("EMAILADDRESS")]
		public virtual string? EMailAddress { get; set; }

		[Column("FAX")]
		public virtual string? Fax { get; set; }

		[Column("LASTMODIFIER")]
		public virtual string? LastModifier { get; set; }

		[Column("LASTMODIFYDATETIME")]
		public virtual string? LastModifyDateTime { get; set; }

		[Column("LEGACYCODE")]
		public virtual string? LegacyCode { get; set; }

		[Column("MOBILENUMBER4SMS")]
		public virtual string? MobileNumber4SMS { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALID")]
		public virtual string? NationalID { get; set; }

		[Column("POSTALCODE")]
		public virtual string? PostalCode { get; set; }

		[Column("SCRIPTORIUMDIVORCENO")]
		public virtual long? ScriptoriumDivorceNo { get; set; }

		[Column("SCRIPTORIUMNO")]
		public virtual long? ScriptoriumNo { get; set; }

		[Column("SCRIPTORIUMTYPE")]
		public virtual Anu.Enumerations.NotaryActivityType? ScriptoriumType { get; set; }

		[Column("SMSENGLISHNAME")]
		public virtual string? SMSEnglishName { get; set; }

		[Column("SMSFARSINAME")]
		public virtual string? SMSFarsiName { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[Column("SYNCHRONIZEISDONE")]
		public virtual Anu.Enumerations.YesNo? SynchronizeIsDone { get; set; }

		[Column("TEL")]
		public virtual string? Tel { get; set; }

		[ForeignKey("NOTARYID")]
		public virtual Anu.BaseInfo.OrganizationChart.NScriptoriumEmployee? TheNotary { get; set; }

		[ForeignKey("NOTARY1ASSISTANTCURRENTID")]
		public virtual Anu.BaseInfo.OrganizationChart.NScriptoriumEmployee? TheNotary1AssistantCurrent { get; set; }

		[ForeignKey("NOTARY2ASSISTANTCURRENTID")]
		public virtual Anu.BaseInfo.OrganizationChart.NScriptoriumEmployee? TheNotary2AssistantCurrent { get; set; }

		[ForeignKey("NOTARYCURRENTID")]
		public virtual Anu.BaseInfo.OrganizationChart.NScriptoriumEmployee? TheNotaryCurrent { get; set; }

		[ForeignKey("NOTARYFIRSTASSISTANTID")]
		public virtual Anu.BaseInfo.OrganizationChart.NScriptoriumEmployee? TheNotaryFirstAssistant { get; set; }

		[ForeignKey("NOTARYSECONDASSISTANTID")]
		public virtual Anu.BaseInfo.OrganizationChart.NScriptoriumEmployee? TheNotarySecondAssistant { get; set; }

    }
    [Table("NSCRIPTORIUM")]
    public partial class NScriptorium : NScriptoriumBase { }

    }


