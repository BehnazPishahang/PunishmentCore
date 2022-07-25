
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("سمت اداره کننده / صاحب پروانه در سرويس")]
    public class PInspectionReportPost
    {
        public PInspectionReportPost()
        {
        }
            
            
            [System.ComponentModel.DisplayName("سمت شخص")]
            public Anu.PunishmentOrg.Enumerations.PSuspectPostType PostType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("اداره کننده/صاحب پروانه در سرويس")]
            public PInspectionReportDirectors ThePInspectionReportDirectors { get; set ;} 
            

    }
    }
