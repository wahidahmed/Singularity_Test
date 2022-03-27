using Newtonsoft.Json;
using Singularity_Test.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Singularity_Test.API_Services
{
    public class StudetntInfo_APIService: IStudetntInfo_APIService
    {
        HttpClient httpClient = new HttpClient
        {

        };

        public async Task<IEnumerable<StudentInfoViewModel>> GetStudentsList()
        {
            httpClient.Timeout = TimeSpan.FromMinutes(20);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            List<StudentInfoViewModel> list = new List<StudentInfoViewModel>();
            using (Stream s = await httpClient.GetStreamAsync("http://localhost:59197/api/StudentInfo"))
            using (StreamReader sr = new StreamReader(s))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                JsonSerializer serializer = new JsonSerializer();
                list = serializer.Deserialize<List<StudentInfoViewModel>>(reader);
            }

            return list;
        }

        public async Task<StudentInfoViewModel> GetStudentById(int id)
        {
            StudentInfoViewModel list = new StudentInfoViewModel();
            try
            {
                using (Stream s = await httpClient.GetStreamAsync("http://localhost:59197/api/StudentInfo/"+id+""))
                using (StreamReader sr = new StreamReader(s))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    list = serializer.Deserialize<StudentInfoViewModel>(reader);
                }

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public async Task<bool> Add(StudentInfoViewModel entity)
        {
            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync("http://localhost:59197/api/StudentInfo", entity).ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public async Task<bool> Update(StudentInfoViewModel entity)
        {
            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.PutAsJsonAsync("http://localhost:59197/api/StudentInfo/"+entity.Id+"", entity).ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public async Task<bool> Delete(int id)
        {
            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync("http://localhost:59197/api/StudentInfo/" + id + "").ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
