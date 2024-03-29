﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PInstallmentBindingSubjectBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("OLDCASEBINDINGIDS")]
        public virtual string? OldCaseBindingIDs { get; set; }

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PINSTALLMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PInstallment? ThePInstallment { get; set; }

        }

    [Table("PINSTALLMENTBINDINGSUBJECT")]
    public partial class PInstallmentBindingSubject : PInstallmentBindingSubjectBase
    {
    }
    }