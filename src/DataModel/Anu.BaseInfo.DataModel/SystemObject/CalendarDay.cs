﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class CalendarDayBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATE")]
        public virtual string? CreateDate { get; set; }

        [Column("DAYCOUNTER")]
        public virtual long? DayCounter { get; set; }

        [Column("DAYKIND")]
        public virtual Anu.BaseInfo.Enumerations.HolidayKind? DayKind { get; set; }

        [Column("WEEKDAY")]
        public virtual Anu.BaseInfo.Enumerations.WeekDay? WeekDay { get; set; }

        }

    [Table("CALENDARDAY")]
    public partial class CalendarDay : CalendarDayBase
    {
    }
    }