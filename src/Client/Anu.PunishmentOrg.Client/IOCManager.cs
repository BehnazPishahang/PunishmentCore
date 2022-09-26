using Anu.PunishmentOrg.Client.Infrastructure.Authorization;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Authorization;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Notice;
using Anu.PunishmentOrg.Client.Infrastructure.Notice;
using Anu.PunishmentOrg.Client.Infrastructure.Granovment;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Granovment;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.BaseInfo.GeoLocation;
using Anu.PunishmentOrg.Client.Infrastructure.BaseInfo.GeoLocation;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.PCase;
using Anu.PunishmentOrg.Client.Infrastructure.Pcase;

namespace Anu.PunishmentOrg.Client
{
    public static  class IOCManager
    {
        public static IServiceCollection ManageIOC(this IServiceCollection services, ConfigurationManager configuration )
        {
            services.AddScoped<INoticeService, NoticeService>();
            services.AddScoped<IPCaseService, PCaseService>();
            services.AddScoped<IAnuAuthorizationService, AnuAuthorizationService>();
            
            
            services.AddScoped<IPGravamenService, PGravamenService>();
            services.AddScoped<IGeoLoactionService, GeoLoactionService>();



            services.AddSingleton<AppConfiguration>(configuration.GetSection(AppConfiguration.ConfigurationPosition).Get<AppConfiguration>());

            return services;
        }
       
    }
}
