using Anu.BaseInfo.SystemObject;
using PunishmentOrg.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace PunishmentOrg.DataAccess.Repositories
{
    public class ObjectStateRepository : GenericRepository<Anu.BaseInfo.SystemObject.ObjectState>,
        IObjectStateRepository
    {
        public ObjectStateRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<ObjectState> GetObjectsByParentCode(string parentCode)
        {
            return _context.Set<ObjectState>().AsNoTracking().Where(x => x.Code == parentCode);
        }

        public IEnumerable<ObjectState> GetObjectsByUniqueNo(string uniqueNo)
        {
            //return _context.Set<ObjectState>().Where(x => x.Code == uniqueNo).ToList();
            return _context.Set<ObjectState>().FromSqlRaw("");
        }
    }
}
