using Anu.PunishmentOrg.Client.Infrastructure.Authorization;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Authorization;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Notice;
using Anu.PunishmentOrg.Client.Infrastructure.Notice;

namespace Anu.PunishmentOrg.Client
{
    public static  class IOCManager
    {
        public static IServiceCollection ManageIOC(this IServiceCollection services, ConfigurationManager configuration )
        {
            services.AddScoped<INoticeService, NoticeService>();
            services.AddScoped<IAnuAuthorizationService, AnuAuthorizationService>();
            services.AddSingleton<AppConfiguration>(configuration.GetSection(AppConfiguration.ConfigurationPosition).Get<AppConfiguration>());

            return services;
        }
       
    }
}
