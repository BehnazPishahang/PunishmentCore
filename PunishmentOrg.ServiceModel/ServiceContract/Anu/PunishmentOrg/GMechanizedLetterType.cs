
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع موضوع نامه مکانيزه در وب سرويس")]
    public class GMechanizedLetterType
    {
        public GMechanizedLetterType()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کد")]
        public string Code { get; set; }


        [System.ComponentModel.DisplayName("نياز به پاسخ")]
        public DataModel.BaseInfo.Anu.Enumerations.HaveNoHave NeedResult { get; set; }


        [System.ComponentModel.DisplayName("کدهاي انواع سمت اداري داراي دسترسي")]
        public string PostTypeAccess { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع گيرنده موضوع نامه")]
        public DataModel.BaseInfo.Anu.Enumerations.MechanizedLetterOrgTypeReceiver ReceiverType { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع فرستنده موضوع نامه")]
        public DataModel.BaseInfo.Anu.Enumerations.MechanizedLetterOrgTypeReceiver SenderType { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت")]
        public DataModel.BaseInfo.Anu.Enumerations.State State { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("عنوان")]
        public string Title { get; set; }


        [System.ComponentModel.DisplayName("کدهاي انواع سطوح واحدهاي داراي دسترسي")]
        public string UnitLevelAccess { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کدهاي انواع واحدهاي داراي دسترسي")]
        public string UnitTypeAccess { get; set; }


    }
}
