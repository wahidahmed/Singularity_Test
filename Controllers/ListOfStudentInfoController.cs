using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Singularity_Test.API_Services;
using Singularity_Test.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Singularity_Test.Controllers
{
    public class ListOfStudentInfoController : Controller
    {
        public ListOfStudentInfoController(IStudetntInfo_APIService studetntInfo_APIService)
        {
            this.studetntInfo_APIService = studetntInfo_APIService;
        }
        private readonly IStudetntInfo_APIService studetntInfo_APIService;

        public async Task<IActionResult> Index()
        {
            return View(await studetntInfo_APIService.GetStudentsList());
        }
    }
}
