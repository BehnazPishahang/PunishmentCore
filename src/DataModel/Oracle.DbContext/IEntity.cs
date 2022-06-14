using Microsoft.EntityFrameworkCore;

namespace Oracle.DbContext
{
    public interface IEntity
    {
        void Validate(EntityState state);

    }
}
