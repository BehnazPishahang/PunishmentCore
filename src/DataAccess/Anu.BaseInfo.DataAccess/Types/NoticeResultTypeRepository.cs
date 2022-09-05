using Anu.BaseInfo.DataModel.GeoInfo;
using Anu.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.Types
{
    public class NoticeResultTypeRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.Types.NoticeResultType>, Anu.BaseInfo.Domain.Types.INoticeResultTypeRepository
    {
        public NoticeResultTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Anu.BaseInfo.DataModel.Types.NoticeResultType> GetNoticeResultTypeWithCode(string code)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.Types.NoticeResultType>().Where(x => x.Code == code).FirstOrDefaultAsync();
        }
    }
}
