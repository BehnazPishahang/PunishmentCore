using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PIllicitPersonSearchLogBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Unicode(false)]
        [Column("CASENO")]
        public virtual string? CaseNo { get; set; }

        [Unicode(false)]
        [Column("COMPUTERNAME")]
        public virtual string? ComputerName { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("IDENTITYNUMBER")]
        public virtual string? IdentityNumber { get; set; }

        [Column("ISFINDHISTORY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsFindHistory { get; set; }

        [Unicode(false)]
        [Column("JUDGENO")]
        public virtual string? JudgeNo { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Unicode(false)]
        [Column("PCASENO")]
        public virtual string? PCaseNo { get; set; }

        [Unicode(false)]
        [Column("PCASEPERSONID")]
        public virtual string? PCasePersonId { get; set; }

        [Column("PCASESUBNO")]
        public virtual long? PCaseSubNo { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Unicode(false)]
        [Column("SEARCHDATETIME")]
        public virtual string? SearchDateTime { get; set; }

        [Unicode(false)]
        [Column("SEARCHMILISECOND")]
        public virtual string? SearchMiliSecond { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        }

    [Table("PILLICITPERSONSEARCHLOG")]
    public partial class PIllicitPersonSearchLog : PIllicitPersonSearchLogBase
    {
    }
    }