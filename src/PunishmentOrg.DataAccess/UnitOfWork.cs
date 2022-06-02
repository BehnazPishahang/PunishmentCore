using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.DataAccess
{
    public class UnitOfWork : Domain.Interface.IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Unit= new Repositories.Anu.BaseInfo.OrganizationChart.UnitRepository(_context);
            GUnitType = new Repositories.Anu.BaseInfo.OrganizationChart.GUnitTypeRepository(_context);
        }
        public Domain.Interface.Anu.BaseInfo.OrganizationChart.IUnitRepository Unit { get; private set; }
        public Domain.Interface.Anu.BaseInfo.OrganizationChart.IGUnitTypeRepository GUnitType { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
