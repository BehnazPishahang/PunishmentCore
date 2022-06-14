using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.Domain.Interface
{
    public interface IObjectStateRepository : IGenericRepository<Anu.BaseInfo.SystemObject.ObjectState> 
    {
        public IEnumerable<Anu.BaseInfo.SystemObject.ObjectState> GetObjectsByUniqueNo(string uniqueNo);

        public IEnumerable<Anu.BaseInfo.SystemObject.ObjectState> GetObjectsByParentCode(string parentCode);

    }
}

