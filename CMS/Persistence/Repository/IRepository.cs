using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public interface IRepository <T>
    {
        T Get(int id);
        void Save(T person);
        void Update(T person);
        void Delete(T person);
        long RowCount();
    }
}
