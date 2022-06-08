using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.ServiceModels.ServiceContract.Anu.PunishmentOrg;

public class ApiPerson
{
    [System.ComponentModel.DisplayName("نام")]
    public string FName { get; set; }

    [System.ComponentModel.DisplayName("نام خانوادگی")]
    public string LName{ get; set; }

    [System.ComponentModel.DisplayName("کد ملی")]
    public string NationalCode { get; set; }

    [System.ComponentModel.DisplayName("نام پدر")]
    public string FatherName { get; set; }

    [System.ComponentModel.DisplayName("نام نقش")]
    public string RoleNameEn { get; set; }

    [System.ComponentModel.DisplayName("نوع شخص")]
    public PersonType PersonTypeId { get; set; }

    public enum PersonType
    {
        Real=1,
        Legal
    }

}