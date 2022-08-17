using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.SystemObject
{
    public class SystemFormRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.SystemObject.SystemForm>,
        Domain.SystemObject.ISystemFormRepository
    {

        public SystemFormRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }
    }
}
