
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("واحد هاي سازماني ساير سازمان ها در وب سرويس")]
    public class NAJAUnit
    {
        public NAJAUnit()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آدرس")]
        public string Address { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("كد يکتاي واحد در سامانه")]
        public string Code { get; set; }


        [System.ComponentModel.DisplayName("فيلد موقت 1")]
        public string Desc1 { get; set; }


        [System.ComponentModel.DisplayName("فيلد موقت 2")]
        public string Desc2 { get; set; }


        [System.ComponentModel.DisplayName("فيلد موقت 3")]
        public string Desc3 { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("كد سطح واحد")]
        public string LevelCode { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کد واحد در سازمان مربوطه")]
        public string NAJACode { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت")]
        public DataModel.BaseInfo.Anu.Enumerations.State State { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("عنوان واحد")]
        public string UnitName { get; set; }


    }
}
