﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.MechanizedLetter
{
    public abstract class GMechanizedLetterRelLettersBase : BaseInfoEntity<string>
    {

        [Column("RELATIONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MechanizedLetterRelType? RelationType { get; set; }

        [Unicode(false)]
        [Column("RELLETTERDATE")]
        public virtual string? RelLetterDate { get; set; }

        [Column("RELLETTERGETTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MechanizedLetterRelLetterGetType? RelLetterGetType { get; set; }

        [Unicode(false)]
        [Column("RELLETTERNO")]
        public virtual string? RelLetterNo { get; set; }

        [ForeignKey("MAINLETTERID")]
        public virtual Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter? TheMainLetter { get; set; }

        [ForeignKey("RELLETTERID")]
        public virtual Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter? TheRelLetter { get; set; }

        }

    [Table("GMECHANIZEDLETTERRELLETTERS")]
    public partial class GMechanizedLetterRelLetters : GMechanizedLetterRelLettersBase
    {
    }
    }