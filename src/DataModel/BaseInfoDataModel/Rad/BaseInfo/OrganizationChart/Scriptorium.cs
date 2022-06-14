

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.OrganizationChart
{
    public abstract class ScriptoriumBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("EMAILADDRESS")]
		public virtual string? EMailAddress { get; set; }

		[Column("EXORDIUMFAMILY")]
		public virtual string? ExordiumFamily { get; set; }

		[Column("EXORDIUMNAME")]
		public virtual string? ExordiumName { get; set; }

		[Column("GEOLOCATIONINFO")]
		public virtual string? GeoLocationInfo { get; set; }

		[Column("ISRELTOTERMINAL")]
		public virtual Rad.CMS.Enumerations.YesNo? IsRelToTerminal { get; set; }

		[Column("LEGACYCODE")]
		public virtual string? LegacyCode { get; set; }

		[Column("MOBILENUMBER4SMS")]
		public virtual string? MobileNumber4SMS { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NSCRIPTORIUMID")]
		public virtual string? NScriptoriumId { get; set; }

		[Column("POSTCODE")]
		public virtual string? PostCode { get; set; }

		[Column("SCRIPTORIUMDIVORCENO")]
		public virtual decimal? ScriptoriumDivorceNo { get; set; }

		[Column("SCRIPTORIUMNO")]
		public virtual decimal? ScriptoriumNo { get; set; }

		[Column("SCRIPTORIUMTYPE")]
		public virtual Rad.CMS.Enumerations.NotaryActivityType? ScriptoriumType { get; set; }

		[Column("SMSENGLISHNAME")]
		public virtual string? SMSEnglishName { get; set; }

		[Column("SMSFARSINAME")]
		public virtual string? SMSFarsiName { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[Column("TEL")]
		public virtual string? Tel { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("RELATEDUNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheRelatedUnit { get; set; }

		[ForeignKey("RELIGIONID")]
		public virtual Rad.BaseInfo.Types.Religion? TheReligion { get; set; }

		[ForeignKey("RELIGIONIDEOLOGYID")]
		public virtual Rad.BaseInfo.Types.ReligionIdeology? TheReligionIdeology { get; set; }

    }
    [Table("SCRIPTORIUM")]
    public partial class Scriptorium : ScriptoriumBase { }

    }


