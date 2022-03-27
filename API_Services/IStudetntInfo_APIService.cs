using Singularity_Test.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singularity_Test.API_Services
{
   public interface IStudetntInfo_APIService
    {
        Task<bool> Add(StudentInfoViewModel entity);
        Task<IEnumerable<StudentInfoViewModel>> GetStudentsList();
        Task<StudentInfoViewModel> GetStudentById(int id);
        Task<bool> Update(StudentInfoViewModel entity);
        Task<bool> Delete(int id);
    }
}
