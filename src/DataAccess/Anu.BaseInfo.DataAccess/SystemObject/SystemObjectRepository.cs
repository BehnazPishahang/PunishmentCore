using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.SystemObject
{
    public class SystemObjectRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.SystemObject.SystemObject>, Domain.SystemObject.ISystemObjectRepository
    {
        public SystemObjectRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<DataModel.SystemObject.SystemObject>> GetSystemObjectByCode(string code)
        {
            return await _context.Set<DataModel.SystemObject.SystemObject>().Where(x => x.Code == code).ToListAsync();
        }


    }
}
