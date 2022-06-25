using Microsoft.EntityFrameworkCore;

namespace PunishmentOrg.DataAccess.Repositories.BaseInfo.Anu.BaseInfo.SystemObject
{
    public class ObjectStateRepository : GenericRepository<DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState>,
        Domain.Interface.BaseInfo.SystemObject.IObjectStateRepository
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
