using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.ServiceModels.ServiceContract.Anu.PunishmentOrg;

public class BillOwnershipOrganization
{
    public BillOwnershipOrganization()
    {
        ApiPerson = new List<ApiPerson>();
    }


    [System.ComponentModel.DisplayName("کد رهگيري رسيد در سامانه انبارها")]
    public string TrackingCodeStores { get; set; }

    [System.ComponentModel.DisplayName("کدینگ دستگاه کاشف")]
    public CodingDeviceDetectorId CodingDeviceDetector { get; set; }

    [System.ComponentModel.DisplayName("شناسه یکتا پرونده")]
    public string ParentContentNumber { get; set; }

    [System.ComponentModel.DisplayName("شماره قبض/رسيد")]
    public string BillNumber { get; set; }

    [System.ComponentModel.DisplayName("تاريخ قبض/رسيد")]
    public string BillDate { get; set; }

    [System.ComponentModel.DisplayName("شماره صورتجلسه")]
    public string ProceedingNumber { get; set; }

    [System.ComponentModel.DisplayName("اشخاص")]
    public IEnumerable<ApiPerson> ApiPerson { get; set; }


    public enum CodingDeviceDetectorId
    {
        ConsumerProducerProtectionOrganization = 1,
        Customs,
        MinistryOfInformation,
        Irgc,
        PoliceForce,
        MinistryOfAgriculture,
        FisheriesOrganization,
        ForestsOrganization,
        OilCompany,
        CentralBank,
        MinistryOfCulturalHeritage,
        EnvironmentalProtectionOrganization,
        FoodAndDrugAdministration,
    }
}