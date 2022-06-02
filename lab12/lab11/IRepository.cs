using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    interface IRepository : IDisposable 
    {
        IEnumerable<master> GetBookList();
        master GetMaster(int id);
        void Create(master item);
        void Delete(int id);
        void Save();
    }
}
