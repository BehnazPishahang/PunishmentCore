using Microsoft.EntityFrameworkCore;
using PunishmentOrg.Domain.Interface;

namespace PunishmentOrg.DataAccess.Repositories
{
    public class ObjectStateRepository : GenericRepository<DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState>,
        IObjectStateRepository
    {
        public ObjectStateRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState> GetObjectsByParentCode(string parentCode)
        {
            return _context.Set<DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState>().AsNoTracking().Where(x => x.Code == parentCode);
        }

        public IEnumerable<DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState> GetObjectsByUniqueNo(string uniqueNo)
        {
            //return _context.Set<ObjectState>().Where(x => x.Code == uniqueNo).ToList();
            return _context.Set<DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState>().FromSqlRaw("");
        }
    }
}
