

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PIllicitPersonSearchLogBase : PunishmentOrgEntity<string>
    {

		[Column("BIRTHDATE")]
		public virtual string? BirthDate { get; set; }

		[Column("CASENO")]
		public virtual string? CaseNo { get; set; }

		[Column("COMPUTERNAME")]
		public virtual string? ComputerName { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("IDENTITYNUMBER")]
		public virtual string? IdentityNumber { get; set; }

		[Column("ISFINDHISTORY")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? IsFindHistory { get; set; }

		[Column("JUDGENO")]
		public virtual string? JudgeNo { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALCODE")]
		public virtual string? NationalCode { get; set; }

		[Column("PCASENO")]
		public virtual string? PCaseNo { get; set; }

		[Column("PCASEPERSONID")]
		public virtual string? PCasePersonId { get; set; }

		[Column("PCASESUBNO")]
		public virtual long? PCaseSubNo { get; set; }

		[Column("PERSONTYPE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.PersonType? PersonType { get; set; }

		[Column("SEARCHDATETIME")]
		public virtual string? SearchDateTime { get; set; }

		[Column("SEARCHMILISECOND")]
		public virtual string? SearchMiliSecond { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("PILLICITPERSONSEARCHLOG")]
    public partial class PIllicitPersonSearchLog : PIllicitPersonSearchLogBase { }

    }


