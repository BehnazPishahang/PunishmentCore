

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Letter
{
    public abstract class PRevisionRequestAskerBase : PunishmentOrgEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("ASKERTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PURevisionRequestAskerType? AskerType { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("MOBILNUMBER")]
		public virtual string? MobilNumber { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALCODE")]
		public virtual string? NationalCode { get; set; }

		[Column("PERSONTYPE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.PersonType? PersonType { get; set; }

		[Column("PHONENUMBER")]
		public virtual string? PhoneNumber { get; set; }

		[Column("POSTCODE")]
		public virtual string? PostCode { get; set; }

		[Column("SEX")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.SexType? Sex { get; set; }

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[ForeignKey("PREVISIONREQUESTID")]
		public virtual Anu.PunishmentOrg.Letter.PRevisionRequest? ThePRevisionRequest { get; set; }

    }
    [Table("PREVISIONREQUESTASKER")]
    public partial class PRevisionRequestAsker : PRevisionRequestAskerBase { }

    }


