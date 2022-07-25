﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GNewspaperBase : BaseInfoEntity<string>
    {

        [Column("CERTIFICATETYPE")]
        public virtual Anu.BaseInfo.Enumerations.NewspaperCertificateType? CertificateType { get; set; }

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("ERSHADCODE")]
        public virtual string? ErshadCode { get; set; }

        [Column("GROUPLEVEL")]
        public virtual Anu.BaseInfo.Enumerations.NewspaperGroupLevel? GroupLevel { get; set; }

        [Column("PERIOD")]
        public virtual Anu.BaseInfo.Enumerations.NewspaperPeriod? Period { get; set; }

        [Column("PRINTAREA")]
        public virtual Anu.BaseInfo.Enumerations.NewspaperPrintArea? PrintArea { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheGNewspaper")]
        public virtual List<Anu.BaseInfo.DataModel.Types.GNewspaperUnit>? TheGNewspaperUnitList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GNEWSPAPER")]
    public partial class GNewspaper : GNewspaperBase
    {
    }
}