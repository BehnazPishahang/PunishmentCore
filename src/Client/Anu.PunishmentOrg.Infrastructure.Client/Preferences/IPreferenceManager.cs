using Anu.PunishmentOrg.Client.Infrastructure.Settings;
using Anu.PunishmentOrg.Client.Infrastructure.Wrapper;

namespace Anu.PunishmentOrg.Client.Infrastructure.Preferences
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}