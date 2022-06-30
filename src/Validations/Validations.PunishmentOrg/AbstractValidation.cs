using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Validation
{
    public abstract class AbstractValidation<TEntity> : IAbstractValidation<TEntity> where TEntity : class
    {
        public abstract List<System.ComponentModel.DataAnnotations.ValidationResult> Execute(TEntity entity);

        public virtual bool NeedExecute()
        { 
            return true;
        }
    }
}
