using Anu.BaseInfo.FrontEndSecurity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.DateTimeUtility;

namespace PunishmentOrg.DataAccess.Repositories.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public class GFESUserRepository : GenericRepository<GFESUser>, Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserRepository
    {
        public GFESUserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
