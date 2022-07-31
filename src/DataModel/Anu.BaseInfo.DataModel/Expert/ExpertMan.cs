

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Expert
{
    public abstract class ExpertManBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("EMAILADDRESS")]
        public virtual string? EMailAddress { get; set; }

        [Unicode(false)]
        [Column("ENDCREDITLICENSEDATE")]
        public virtual string? EndCreditLicenseDate { get; set; }

        [Unicode(false)]
        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Column("EXPERTSTATE")]
        public virtual Anu.BaseInfo.Enumerations.ExpertState? ExpertState { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("IDENTITYNO")]
        public virtual string? IdentityNo { get; set; }

        [Column("ISDELETED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsDeleted { get; set; }

        [Column("JOBSTATE")]
        public virtual Anu.BaseInfo.Enumerations.ExpEmployeeType? JobState { get; set; }

        [Unicode(false)]
        [Column("LICENSENO")]
        public virtual string? LicenseNo { get; set; }

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

        [Unicode(false)]
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