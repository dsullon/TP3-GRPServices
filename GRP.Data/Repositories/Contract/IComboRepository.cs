using GRP.Core;
using System.Collections.Generic;

namespace GRP.Data.Repositories.Contract
{
    public interface IComboRepository: IRepository<Combo>
    {
        IEnumerable<dynamic> GetAllWithRelations();
    }
}