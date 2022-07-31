

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Lawyer
{
    public abstract class GLawyerBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATE")]
        public virtual string? CreateDate { get; set; }

        [Unicode(false)]
        [Column("EMAILADDRESS")]
        public virtual string? EMailAddress { get; set; }

        [Unicode(false)]
        [Column("ENDCREDITLICENSEDATE")]
        public virtual string? EndCreditLicenseDate { get; set; }

        [Unicode(false)]
        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Unicode(false)]
        [Column("ENDNOVITIATEDATE")]
        public virtual string? EndNovitiateDate { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("HOMEADDRESS")]
        public virtual string? HomeAddress { get; set; }

        [Unicode(false)]
        [Column("IDENTITYNO")]
        public virtual string? IdentityNo { get; set; }

        [Column("ISDELETED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsDeleted { get; set; }

        [Unicode(false)]
        [Column("JOBADDRESS")]
        public virtual string? JobAddress { get; set; }

        [Unicode(false)]
        [Column("JOBTEL")]
        public virtual string? JobTel { get; set; }

        [Column("LAWYERDEGREE")]
        public virtual Anu.BaseInfo.Enumerations.LawyerDegree? LawyerDegree { get; set; }

        [Column("LAWYERSTATE")]
        public virtual Anu.BaseInfo.Enumerations.LawyerState? LawyerState { get; set; }

        [Column("LAWYERTYPELICENSE")]
        public virtual Anu.BaseInfo.Enumerations.LawyerTypeLicense? LawyerTypeLicense { get; set; }

        [Unicode(false)]
        [Column("LAWYERWORKNO")]
        public virtual string? LawyerWorkNo { get; set; }

        [Column("MARIAGESTATE")]
        public virtual Anu.BaseInfo.Enumerations.MarriageState? MariageState { get; set; }

        [Unicode(false)]
        [Column("MOBILENUMBER4SMS")]
        public virtual string? MobileNumber4SMS { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALITYCODE")]
        public virtual string? NationalityCode { get; set; }

        [Unicode(false)]
        [Column("PERSONPASSWORD")]
        public virtual string? PersonPassword { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [Unicode(false)]
        [Column("SOURCEID")]
        public virtual string? SourceID { get; set; }

        [Unicode(false)]
        [Column("TEL")]
        public virtual string? Tel { get; set; }

        [ForeignKey("ADDRESSLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheAddressLocation { get; set; }

        [ForeignKey("GLAWYERCLUBID")]
        public virtual Anu.BaseInfo.DataModel.Lawyer.GLawyerClub? TheGLawyerClub { get; set; }

        [InverseProperty("TheGLawyer")]
        public virtual List<Anu.BaseInfo.DataModel.Lawyer.GLawyerWorkHistory>? TheGLawyerWorkHistoryList { get; set; }

        [ForeignKey("ISSUELOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheIssueLocation { get; set; }

    }

    [Table("GLAWYER")]
    public partial class GLawyer : GLawyerBase
    {
    }
    }