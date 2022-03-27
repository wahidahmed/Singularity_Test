using Singularity_Test.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singularity_Test.Repo
{
    public class UnitOfWork:IUnitOfWork
    {
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private readonly AppDbContext dbContext;

        private GenericRepository<StudentInfo> _studentInfo;

        public IGenericRepository<StudentInfo> StudentInfo { get { return _studentInfo ?? (_studentInfo = new GenericRepository<StudentInfo>(dbContext)); } }


        public async Task<string> SaveChangesAsync()
        {
            string result = "";
            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        public string SaveChanges()
        {



            string result = "";
            //_dbContext.SaveChanges();
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return result;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
