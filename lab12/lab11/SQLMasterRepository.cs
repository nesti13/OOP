using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class SQLMasterRepository : IRepository
    {
        private lab10Entities db;

        public SQLMasterRepository()
        {
            this.db = new lab10Entities();
        }
        public SQLMasterRepository(OrderContext context)
        {
            this.db = context;
        }
        public IEnumerable<master> GetBookList()
        {
            return db.masters;
        }

        public master GetDoctor(int id)
        {
            return db.masters.Find(id);
        }

        public void Create(master book)
        {
            db.masters.Add(book);
        }

        public void Delete(int id)
        {
            master book = db.masters.Find(id);
            if (book != null)
                db.masters.Remove(book);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        master IRepository.GetMaster(int id)
        {
            throw new NotImplementedException();
        }
    }
}
