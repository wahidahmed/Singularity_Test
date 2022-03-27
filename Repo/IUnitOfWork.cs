using Singularity_Test.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singularity_Test.Repo
{
   public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<StudentInfo> StudentInfo { get; }
        Task<string> SaveChangesAsync();
        string SaveChanges();
    }
}
