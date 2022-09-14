namespace Anu.PunishmentOrg.Api.Accounting
{
    public class GetCountOfPaidPBill4PaidByNationalCodeContract
    {
        public long? TotalCountOfPBill4Paid { get; set; }

        public long? CountOfPaidPBill4Paid { get; set; }

        public long? CountOfNotPaidPBill4Paid { get; set; }
    }
}