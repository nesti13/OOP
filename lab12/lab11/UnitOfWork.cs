using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class OrderContext : DbContext
    {
        public DbSet<master> Books { get; set; }
    }
    class UnitOfWork : IDisposable
    {
        private OrderContext db = new OrderContext();
        private SQLMasterRepository masterRepository;


        public SQLMasterRepository master
        {
            get
            {
                if (masterRepository == null)
                    masterRepository = new SQLMasterRepository(db);
                return masterRepository;
            }
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
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
