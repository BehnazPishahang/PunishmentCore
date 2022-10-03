
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("سمت اداره کننده/صاحب پروانه در سرویس")]
    public class PInspectionReportPostContract
    {
        public PInspectionReportPostContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت شخص")]
        public Anu.PunishmentOrg.Enumerations.PSuspectPostType? PostType { get; set; }

            

    }
    }
