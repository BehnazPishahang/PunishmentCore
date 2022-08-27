using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Expert
{
    public abstract class ExpertManSubjectBase : BaseInfoEntity<string>
    {

        [ForeignKey("EXPERTMAJORID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertMajor? TheExpertMajor { get; set; }

        [ForeignKey("EXPERTMANID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertMan? TheExpertMan { get; set; }

        }

    [Table("EXPERTMANSUBJECT")]
    public partial class ExpertManSubject : ExpertManSubjectBase
    {
    }
    }