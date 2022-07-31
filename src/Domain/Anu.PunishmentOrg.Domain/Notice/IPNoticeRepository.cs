using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Domain.Notice
{
    public interface IPNoticeRepository : Anu.Domain.IGenericRepository<DataModel.Notice.PNotice>
    {
        public Task<IEnumerable<DataModel.Notice.PNotice>> GetAllPNoticeByNationalCode(string NationalCode);
    }
}
