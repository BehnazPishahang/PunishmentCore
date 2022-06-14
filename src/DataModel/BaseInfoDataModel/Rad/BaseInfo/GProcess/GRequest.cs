

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GRequestBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DOSSIERRECEIVED")]
		public virtual bool? DossierReceived { get; set; }

		[Column("HELPERFIELD1")]
		public virtual string? HelperField1 { get; set; }

		[Column("HELPERFIELD2")]
		public virtual string? HelperField2 { get; set; }

		[Column("HELPERFIELD3")]
		public virtual string? HelperField3 { get; set; }

		[Column("LASTREFERDATE")]
		public virtual string? LastReferDate { get; set; }

		[Column("LASTREFERUSER")]
		public virtual string? LastReferUser { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("NODATETIME")]
		public virtual string? NoDateTime { get; set; }

		[Column("RELATEDDATETIME")]
		public virtual string? RelatedDateTime { get; set; }

		[Column("RELATEDNO")]
		public virtual string? RelatedNo { get; set; }

		[Column("STOPREQUESTCAUSE")]
		public virtual string? StopRequestCause { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GPROCESSID")]
		public virtual Rad.BaseInfo.GProcess.GProcess? TheGProcess { get; set; }

		[InverseProperty("TheGRequest")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestAction>? TheGRequestActionList { get; set; }

		[InverseProperty("TheGRequest")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestAttachment>? TheGRequestAttachmentList { get; set; }

		[InverseProperty("TheGRequest")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestLetter>? TheGRequestLetterList { get; set; }

		[InverseProperty("TheGRequest")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestPayment>? TheGRequestPaymentList { get; set; }

		[InverseProperty("TheGRequest")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestPerson>? TheGRequestPersonList { get; set; }

		[InverseProperty("TheGRequest")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestRefer>? TheGRequestReferList { get; set; }

		[InverseProperty("TheGRequest")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestRelatedData>? TheGRequestRelatedDataList { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[Column("TRACKINGCODE")]
		public virtual string? TrackingCode { get; set; }

    }
    [Table("GREQUEST")]
    public partial class GRequest : GRequestBase { }

    }


