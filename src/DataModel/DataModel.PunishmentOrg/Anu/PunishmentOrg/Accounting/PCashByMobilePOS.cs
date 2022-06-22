

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Accounting
{
    public abstract class PCashByMobilePOSBase : PunishmentOrgEntity<string>
    {

		[Column("CARDNO")]
		public virtual string? CardNo { get; set; }

		[Column("CHECKFICHENO")]
		public virtual string? CheckFicheNo { get; set; }

		[Column("OUTERCASENO")]
		public virtual string? OuterCaseNo { get; set; }

		[Column("RECEIVERNO")]
		public virtual string? ReceiverNo { get; set; }

		[Column("TERMINALID")]
		public virtual string? TerminalID { get; set; }

		[ForeignKey("ACCOUNTSID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.Accounts? TheAccounts { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePCashByMobilePOS")]
		public virtual List<Anu.PunishmentOrg.Accounting.PCash>? ThePCashList { get; set; }

		[ForeignKey("PMOBILEPOSREGISTERID")]
		public virtual Anu.PunishmentOrg.Accounting.PMobilePOSRegister? ThePMobilePOSRegister { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("TOTALPAIDCOST")]
		public virtual long? TotalPaidCost { get; set; }

		[Column("TRANSACTIONDATETIMESECOND")]
		public virtual string? TransactionDateTimeSecond { get; set; }

		[Column("TRANSACTIONRECEIPT")]
		public virtual string? TransactionReceipt { get; set; }

    }
    [Table("PCASHBYMOBILEPOS")]
    public partial class PCashByMobilePOS : PCashByMobilePOSBase { }

    }


