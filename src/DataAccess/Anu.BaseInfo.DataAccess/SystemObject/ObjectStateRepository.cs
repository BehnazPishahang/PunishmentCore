using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataAccess.SystemObject
{
    public class ObjectStateRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.SystemObject.ObjectState>,
        Domain.SystemObject.IObjectStateRepository
    {
        public ObjectStateRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Anu.BaseInfo.DataModel.SystemObject.ObjectState> GetObjectsByParentCode(string parentCode)
        {
            return _context.Set<Anu.BaseInfo.DataModel.SystemObject.ObjectState>().AsNoTracking().Where(x => x.Code == parentCode);
        }

        public IEnumerable<Anu.BaseInfo.DataModel.SystemObject.ObjectState> GetObjectsByUniqueNo(string uniqueNo)
        {
            //return _context.Set<ObjectState>().Where(x => x.Code == uniqueNo).ToList();
            return _context.Set<Anu.BaseInfo.DataModel.SystemObject.ObjectState>().FromSqlRaw("");
        }
    }
}
