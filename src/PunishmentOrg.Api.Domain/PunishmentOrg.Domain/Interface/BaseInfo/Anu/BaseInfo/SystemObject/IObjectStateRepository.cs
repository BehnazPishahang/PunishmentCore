using DataModel.BaseInfo.Anu.BaseInfo.SystemObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.Domain.Interface
{
    public interface IObjectStateRepository : IGenericRepository<DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState> 
    {
        public IEnumerable<DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState> GetObjectsByUniqueNo(string uniqueNo);

        public IEnumerable<DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState> GetObjectsByParentCode(string parentCode);

    }
}

