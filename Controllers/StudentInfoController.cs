using Microsoft.AspNetCore.Mvc;
using Singularity_Test.DataAccess;
using Singularity_Test.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Singularity_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentInfoController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public StudentInfoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: api/<StudentInfoController>
        [HttpGet]
        public async Task<IEnumerable<StudentInfo>> Get()
        {

            return await unitOfWork.StudentInfo.GetAsync();
        }

        // GET api/<StudentInfoController>/5
        [HttpGet("{id}")]
        public async Task<StudentInfo> Get(int id)
        {
            return await unitOfWork.StudentInfo.GetByIDAsync(id);
        }

        // POST api/<StudentInfoController>
        [HttpPost]
        public void Post( StudentInfo entity)
        {
            try
            {
                unitOfWork.StudentInfo.Insert(entity);
                unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        // PUT api/<StudentInfoController>/5
        [HttpPut("{id}")]
        public void Put(int id,StudentInfo entity)
        {
            try
            {
                unitOfWork.StudentInfo.Update(entity);
                unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/<StudentInfoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                unitOfWork.StudentInfo.DeleteWhere(x=>x.Id==id);
                unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
