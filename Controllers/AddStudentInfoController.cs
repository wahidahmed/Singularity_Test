using Microsoft.AspNetCore.Mvc;
using Singularity_Test.API_Services;
using Singularity_Test.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singularity_Test.Controllers
{
    public class AddStudentInfoController : Controller
    {
        private readonly IStudetntInfo_APIService studetntInfo_APIService;
        public AddStudentInfoController(IStudetntInfo_APIService studetntInfo_APIService)
        {
            this.studetntInfo_APIService = studetntInfo_APIService;
        }
   
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(StudentInfoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                await studetntInfo_APIService.Add(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
          

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            return View(await studetntInfo_APIService.GetStudentById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(StudentInfoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                await studetntInfo_APIService.Update(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await studetntInfo_APIService.GetStudentById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(StudentInfoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                await studetntInfo_APIService.Delete(model.Id);
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return RedirectToAction(nameof(Index));
        }
    }
}
