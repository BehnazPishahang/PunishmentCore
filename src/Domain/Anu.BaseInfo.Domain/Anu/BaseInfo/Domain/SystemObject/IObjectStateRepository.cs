namespace Anu.BaseInfo.Domain.SystemObject
{
    public interface IObjectStateRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.SystemObject.ObjectState>
    {
        public IEnumerable<Anu.BaseInfo.DataModel.SystemObject.ObjectState> GetObjectsByUniqueNo(string uniqueNo);

        public IEnumerable<Anu.BaseInfo.DataModel.SystemObject.ObjectState> GetObjectsByParentCode(string parentCode);

    }
}

