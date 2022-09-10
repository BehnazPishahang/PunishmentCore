using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.SystemObject
{
    public interface ISystemObjectRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.SystemObject.SystemObject>
    {
        public Task<IEnumerable<DataModel.SystemObject.SystemObject>> GetSystemObjectByCode(string code);
    }
}
