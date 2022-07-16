
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع سند يا پيوست در سرويس")]
    public class AttachmentType
    {
        public AttachmentType()
        {
        }

        
        [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }


        
        [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State State { get; set; }


        
        [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }


    }
}