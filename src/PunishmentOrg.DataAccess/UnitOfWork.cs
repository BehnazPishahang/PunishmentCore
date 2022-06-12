using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.DataAccess
{
    public partial class UnitOfWork : Domain.Interface.IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        #region Unit
        private Domain.Interface.Anu.BaseInfo.OrganizationChart.IUnitRepository _Unit;
        public Domain.Interface.Anu.BaseInfo.OrganizationChart.IUnitRepository Unit
        {
            get
            {
                if (this._Unit is not null)
                {
                    return this._Unit;
                }
                Domain.Interface.Anu.BaseInfo.OrganizationChart.IUnitRepository _Unit = new Repositories.Anu.BaseInfo.OrganizationChart.UnitRepository(_context);
                return _Unit;
            }
        }
        #endregion Unit

        #region GUnitType
        private Domain.Interface.Anu.BaseInfo.OrganizationChart.IGUnitTypeRepository _GUnitType;
        public Domain.Interface.Anu.BaseInfo.OrganizationChart.IGUnitTypeRepository GUnitType
        {
            get
            {
                if (this._GUnitType is not null)
                {
                    return this._GUnitType;
                }

                Domain.Interface.Anu.BaseInfo.OrganizationChart.IGUnitTypeRepository _GUnitType = new Repositories.Anu.BaseInfo.OrganizationChart.GUnitTypeRepository(_context);
                return _GUnitType;
            }
        }
        #endregion GUnitType

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
