

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.OrganizationChart
{
    public abstract class ScriptoriumEmployeeBase : BaseInfoEntity<string>
    {

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("DEADDATE")]
		public virtual string? DeadDate { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DIVORCENOTARYSTATE")]
		public virtual Rad.CMS.Enumerations.NotaryOccupationState? DivorceNotaryState { get; set; }

		[Column("DOCUMENTSNOTARYSTATE")]
		public virtual Rad.CMS.Enumerations.NotaryOccupationState? DocumentsNotaryState { get; set; }

		[Column("EMAIL")]
		public virtual string? Email { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("FIRSTNAME")]
		public virtual string? FirstName { get; set; }

		[Column("FROMDATE")]
		public virtual string? FromDate { get; set; }

		[Column("IDENTITYNO")]
		public virtual string? IdentityNo { get; set; }

		[Column("IDENTITYPLACENAME")]
		public virtual string? IdentityPlaceName { get; set; }

		[Column("IDENTITYSERIAL")]
		public virtual string? IdentitySerial { get; set; }

		[Column("LASTNAME")]
		public virtual string? LastName { get; set; }

		[Column("MARRIAGENOTARYSTATE")]
		public virtual Rad.CMS.Enumerations.NotaryOccupationState? MarriageNotaryState { get; set; }

		[Column("MOBILE")]
		public virtual string? Mobile { get; set; }

		[Column("NATIONALITYCODE")]
		public virtual string? NationalityCode { get; set; }

		[Column("NICKNAME")]
		public virtual string? NickName { get; set; }

		[Column("NOTIFICATIONDATE")]
		public virtual string? NotificationDate { get; set; }

		[Column("NOTIFICATIONNO")]
		public virtual string? NotificationNo { get; set; }

		[Column("NRESPONSIBILITYHISTORYID")]
		public virtual string? NResponsibilityHistoryId { get; set; }

		[Column("POSITION")]
		public virtual Rad.CMS.Enumerations.ScriptoriumEmployeePosition? Position { get; set; }

		[Column("POSITIONTYPE")]
		public virtual Rad.CMS.Enumerations.ScriptoriumEmployeePositionType? PositionType { get; set; }

		[Column("RELIGION")]
		public virtual Rad.CMS.Enumerations.Religion? Religion { get; set; }

		[Column("SEX")]
		public virtual Rad.CMS.Enumerations.SexType? Sex { get; set; }

		[ForeignKey("SCRIPTORIUMID")]
		public virtual Rad.BaseInfo.OrganizationChart.Scriptorium? TheScriptorium { get; set; }

		[Column("TODATE")]
		public virtual string? ToDate { get; set; }

		[Column("USAGESTARTDATE")]
		public virtual string? UsageStartDate { get; set; }

    }
    [Table("SCRIPTORIUMEMPLOYEE")]
    public partial class ScriptoriumEmployee : ScriptoriumEmployeeBase { }

    }


