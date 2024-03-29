﻿
namespace Anu.BaseInfo.ServiceModel.OrganizationChart
{
    [System.ComponentModel.DisplayName("واحد سازماني در سرویس")]
    public class UnitContract
    {
        public UnitContract()
        {
        TheChildUnitsList = new List<Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract>();

        TheGUnitRelatedNajaUnitContractList = new List<Anu.BaseInfo.ServiceModel.ExchangeData.GUnitRelatedNajaUnitContract>();

        }
            
            [System.ComponentModel.DisplayName("آدرس")]
        public string? Address { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اداره کل مربوطه")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract? HighOffice { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد سطح")]
        public string? LevelCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد دبيرخانه مربوط به واحد")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract? SecretariatOffice { get; set; }

            
            
            [System.ComponentModel.DisplayName("عنوان فارسي واحد جهت پيامک")]
        public string? SMSFarsiName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحدهاي زيردست")]
        public List<Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract>? TheChildUnitsList { get; set; }

            
            
            [System.ComponentModel.DisplayName("سازمان مكانيزه در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.SystemConfiguration.CMSOrganizationContract>? TheCMSOrganizationContract { get; set; }

            
            
            [System.ComponentModel.DisplayName("مکان جغرافيايي در سرویس")]
        public Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract? TheGeoLocationContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد هاي ساير سازمان هاي مرتبط با واحد سازماني دروني در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.ExchangeData.GUnitRelatedNajaUnitContract>? TheGUnitRelatedNajaUnitContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع واحد سازماني در سرویس")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.GUnitTypeContract? TheGUnitTypeContract { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحد بالادست")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract? TheParentUnit { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? UnitName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره واحد")]
        public string? UnitNo { get; set; }

            

    }
    }
