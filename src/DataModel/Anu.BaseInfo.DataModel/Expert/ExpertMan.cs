

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Expert
{
    public abstract class ExpertManBase : BaseInfoEntity<string>
    {

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("EMAILADDRESS")]
        public virtual string? EMailAddress { get; set; }

        [Column("ENDCREDITLICENSEDATE")]
        public virtual string? EndCreditLicenseDate { get; set; }

        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Column("EXPERTSTATE")]
        public virtual Anu.BaseInfo.Enumerations.ExpertState? ExpertState { get; set; }

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("IDENTITYNO")]
        public virtual string? IdentityNo { get; set; }

        [Column("ISDELETED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsDeleted { get; set; }

        [Column("JOBSTATE")]
        public virtual Anu.BaseInfo.Enumerations.ExpEmployeeType? JobState { get; set; }

        [Column("LICENSENO")]
        public virtual string? LicenseNo { get; set; }

        [Column("MOBILENUMBER4SMS")]
        public virtual string? MobileNumber4SMS { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NATIONALITYCODE")]
        public virtual string? NationalityCode { get; set; }

        [Column("PERSONPASSWORD")]
        public virtual string? PersonPassword { get; set; }

        [Column("TEL")]
        public virtual string? Tel { get; set; }

        [InverseProperty("TheExpertMan")]
        public virtual List<Anu.BaseInfo.DataModel.Expert.ExpertBackground>? TheExpertBackgroundList { get; set; }

        [ForeignKey("EXPERTCLUBID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertClub? TheExpertClub { get; set; }

        [InverseProperty("TheExpertMan")]
        public virtual List<Anu.BaseInfo.DataModel.Expert.ExpertManSubject>? TheExpertManSubjectList { get; set; }

        [InverseProperty("TheExpertMan")]
        public virtual List<Anu.BaseInfo.DataModel.Expert.ExpertWorkUnit>? TheExpertWorkUnitList { get; set; }

    }

    [Table("EXPERTMAN")]
    public partial class ExpertMan : ExpertManBase
    {
    }
}