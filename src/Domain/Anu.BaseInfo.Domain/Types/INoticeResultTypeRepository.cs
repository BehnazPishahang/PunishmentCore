using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.Types
{
    public interface INoticeResultTypeRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.Types.NoticeResultType>
    {
        public Task<Anu.BaseInfo.DataModel.Types.NoticeResultType> GetNoticeResultTypeWithCode(string code);
    }
}
