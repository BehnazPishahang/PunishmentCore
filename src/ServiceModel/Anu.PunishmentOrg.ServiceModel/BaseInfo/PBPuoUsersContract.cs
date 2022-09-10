using Anu.BaseInfo.Enumerations;

namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    public class PBPuoUsersContract
    {
        public string? NationalCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? BirthDate { get; set; }
        public SexType Sex { get; set; }
    }
}
