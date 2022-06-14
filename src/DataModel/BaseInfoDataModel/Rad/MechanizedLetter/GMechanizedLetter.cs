

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMechanizedLetterBase : BaseInfoEntity<string>
    {

		[Column("CONFIRMDATETIME")]
		public virtual string? ConfirmDateTime { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CREATORUSERNAME")]
		public virtual string? CreatorUserName { get; set; }

		[Column("DISCIPLE")]
		public virtual string? Disciple { get; set; }

		[Column("INFORMATIONFIELDVALUE")]
		public virtual string? InformationFieldValue { get; set; }

		[Column("INPUTLETTERDATE")]
		public virtual string? InputLetterDate { get; set; }

		[Column("INPUTLETTERNO")]
		public virtual string? InputLetterNo { get; set; }

		[Column("INPUTOUTPUT")]
		public virtual Rad.CMS.Enumerations.EstateInputOutput? InputOutput { get; set; }

		[Column("ISINTERNALMECHANIZEDLETTER")]
		public virtual Rad.CMS.Enumerations.YesNo? IsInternalMechanizedLetter { get; set; }

		[Column("JUDCIARYLETTERNO")]
		public virtual string? JudciaryLetterNo { get; set; }

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("MECHANIZESTATE")]
		public virtual Rad.CMS.Enumerations.CaseMechanizeState? MechanizeState { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("OLDNO")]
		public virtual string? OldNo { get; set; }

		[Column("REFERENCE")]
		public virtual string? Reference { get; set; }

		[Column("RELATEDRECEIVELETTERNO")]
		public virtual string? RelatedReceiveLetterNo { get; set; }

		[Column("RELATEDSIGNERUSERID")]
		public virtual string? RelatedSignerUserId { get; set; }

		[Column("SIGNERLETTERUSERNAME")]
		public virtual string? SignerLetterUserName { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.UnitExchangeLetter? State { get; set; }

		[InverseProperty("TheGMechanizedLetter")]
		public virtual List<Rad.MechanizedLetter.GMechanizedLetterAttach>? TheGMechanizedLetterAttachList { get; set; }

		[InverseProperty("TheGMechanizedLetter")]
		public virtual List<Rad.MechanizedLetter.GMechanizedLetterCase>? TheGMechanizedLetterCaseList { get; set; }

		[InverseProperty("TheGMechanizedLetter")]
		public virtual List<Rad.MechanizedLetter.GMechanizedLetterFields>? TheGMechanizedLetterFieldsList { get; set; }

		[InverseProperty("TheGMechanizedLetter")]
		public virtual List<Rad.MechanizedLetter.GMechanizedLetterRefer>? TheGMechanizedLetterReferList { get; set; }

		[ForeignKey("GMECHANIZEDLETTERTYPEID")]
		public virtual Rad.BaseInfo.Types.GMechanizedLetterType? TheGMechanizedLetterType { get; set; }

		[InverseProperty("TheGMechanizedLetter")]
		public virtual List<Rad.MechanizedLetter.GMechanizeLetterSignatures>? TheGMechanizeLetterSignaturesList { get; set; }

		[InverseProperty("TheGMechanizedLetter")]
		public virtual List<Rad.MechanizedLetter.GMOutgoingLetter>? TheGMOutgoingLetterList { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("RELATEDLETTERID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetter? TheRelatedLetter { get; set; }

		[ForeignKey("RELATEDLETTERRETURNID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetter? TheRelatedLetterReturn { get; set; }

    }
    [Table("GMECHANIZEDLETTER")]
    public partial class GMechanizedLetter : GMechanizedLetterBase { }

    }


