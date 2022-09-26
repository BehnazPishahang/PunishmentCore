namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("GetCountOfPaidPBill4PaidByNationalCodeContract")]
    public class GetCountOfPaidPBill4PaidByNationalCodeContract
    {
        public GetCountOfPaidPBill4PaidByNationalCodeContract()
        {

        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تعداد کل قبض های شخص")]
        public long? TotalCountOfPBill4Paid { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تعداد قبض های پرداخت شده شخص")]
        public long? CountOfPaidPBill4Paid { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تعداد قبض های پرداخت نشده شخص")]
        public long? CountOfNotPaidPBill4Paid { get; set; }
    }
}