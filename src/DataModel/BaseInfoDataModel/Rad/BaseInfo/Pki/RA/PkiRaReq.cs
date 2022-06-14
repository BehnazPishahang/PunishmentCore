

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaReqBase : BaseInfoEntity<string>
    {

		[Column("CMSORGANIZATIONADDRESS")]
		public virtual string? CMSOrganizationAddress { get; set; }

		[Column("CMSORGANIZATIONCODE")]
		public virtual string? CMSOrganizationCode { get; set; }

		[Column("CMSORGANIZATIONFAXNO")]
		public virtual string? CMSOrganizationFaxNo { get; set; }

		[Column("CMSORGANIZATIONNAME")]
		public virtual string? CMSOrganizationName { get; set; }

		[Column("CMSORGANIZATIONPOSTCODE")]
		public virtual string? CMSOrganizationPostCode { get; set; }

		[Column("CMSORGANIZATIONTELNO")]
		public virtual string? CMSOrganizationTelNo { get; set; }

		[Column("CMSUSERROLETYPECODE")]
		public virtual string? CMSUserRoleTypeCode { get; set; }

		[Column("DELIVERYDATE")]
		public virtual string? DeliveryDate { get; set; }

		[Column("ISKAFIL")]
		public virtual Rad.CMS.Enumerations.YesNo? IsKafil { get; set; }

		[Column("ISSUEDATE")]
		public virtual string? IssueDate { get; set; }

		[Column("PERSONADDRESS")]
		public virtual string? PersonAddress { get; set; }

		[Column("PERSONBIRTHDATE")]
		public virtual string? PersonBirthDate { get; set; }

		[Column("PERSONEMAIL")]
		public virtual string? PersonEMail { get; set; }

		[Column("PERSONFAMILY")]
		public virtual string? PersonFamily { get; set; }

		[Column("PERSONFATHERNAME")]
		public virtual string? PersonFatherName { get; set; }

		[Column("PERSONIDENTITYISSUELOCATION")]
		public virtual string? PersonIdentityIssueLocation { get; set; }

		[Column("PERSONIDENTITYNO")]
		public virtual string? PersonIdentityNo { get; set; }

		[Column("PERSONIDENTITYSERIALNO1")]
		public virtual Rad.CMS.Enumerations.NotaryAlphabetLetter? PersonIdentitySerialNo1 { get; set; }

		[Column("PERSONIDENTITYSERIALNO2")]
		public virtual string? PersonIdentitySerialNo2 { get; set; }

		[Column("PERSONIDENTITYSERIALNO3")]
		public virtual string? PersonIdentitySerialNo3 { get; set; }

		[Column("PERSONMOBILENO")]
		public virtual string? PersonMobileNo { get; set; }

		[Column("PERSONNAME")]
		public virtual string? PersonName { get; set; }

		[Column("PERSONNATIONALNO")]
		public virtual string? PersonNationalNo { get; set; }

		[Column("PERSONPOSTALCODE")]
		public virtual string? PersonPostalCode { get; set; }

		[Column("PERSONSEXTYPE")]
		public virtual Rad.CMS.Enumerations.SexType? PersonSexType { get; set; }

		[Column("PERSONTELNO")]
		public virtual string? PersonTelNo { get; set; }

		[Column("REASONTYPE")]
		public virtual Rad.CMS.Enumerations.PkiRaReasonType? ReasonType { get; set; }

		[Column("REGISTERUSERHISTORYID")]
		public virtual string? RegisterUserHistoryId { get; set; }

		[Column("REQDATE")]
		public virtual string? ReqDate { get; set; }

		[Column("REQNO")]
		public virtual string? ReqNo { get; set; }

		[Column("REQTYPE")]
		public virtual Rad.CMS.Enumerations.PkiRaReqType? ReqType { get; set; }

		[Column("REQUESTERTYPE")]
		public virtual Rad.CMS.Enumerations.PkiRaRequesterType? RequesterType { get; set; }

		[Column("SCRIPTORIUMNO")]
		public virtual decimal? ScriptoriumNo { get; set; }

		[Column("SCRIPTORIUMTYPE")]
		public virtual Rad.CMS.Enumerations.NotaryActivityType? ScriptoriumType { get; set; }

		[Column("SIGNOFREQ")]
		public virtual string? SignOfReq { get; set; }

		[Column("SIGNOFREQVERSION")]
		public virtual string? SignOfReqVersion { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.PkiRaReqState? State { get; set; }

		[InverseProperty("ThePkiRaReq")]
		public virtual List<Rad.BaseInfo.Pki.RA.PkiRaCertificates>? ThePkiRaCertificatesList { get; set; }

		[InverseProperty("ThePkiRaReq")]
		public virtual List<Rad.BaseInfo.Pki.RA.PkiRaReqAnnex>? ThePkiRaReqAnnexList { get; set; }

		[ForeignKey("RAID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheRa { get; set; }

		[ForeignKey("REQUESTERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheRequester { get; set; }

		[Column("USERNAME")]
		public virtual string? UserName { get; set; }

    }
    [Table("PKIRAREQ")]
    public partial class PkiRaReq : PkiRaReqBase { }

    }


