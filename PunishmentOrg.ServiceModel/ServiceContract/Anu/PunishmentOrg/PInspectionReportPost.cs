
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("سمت اداره کننده / صاحب پروانه در سرويس")]
    public class PInspectionReportPost
    {
        public PInspectionReportPost()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت شخص")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PSuspectPostType PostType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اداره کننده/صاحب پروانه در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PInspectionReportDirectors ThePInspectionReportDirectors { get; set ;} 
            

    }
    }
