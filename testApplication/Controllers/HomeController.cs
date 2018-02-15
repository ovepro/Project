using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using testApplication.Models;

namespace testApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Rootobject viewModel = new Rootobject();
            return View();
        }

        string Baseurl = "http://services.groupkt.com/";
        string requestUri = "state/get/USA/all/";

        
        public async Task<ActionResult> searchMethod ( string serach)
        {
            Rootobject searchInfo = new Rootobject();
            Restresponse responseInfo = new Restresponse();
            Result resultInfo = new Result();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));                
                HttpResponseMessage Res = await client.GetAsync(requestUri);                 
                if (Res.IsSuccessStatusCode)
                {                    
                    var searchResponse = Res.Content.ReadAsStringAsync().Result;
                     searchInfo = JsonConvert.DeserializeObject<Rootobject>(searchResponse);
                   
                }
                return Json(searchInfo,JsonRequestBehavior.AllowGet);                   
            }
        }
             
    }
}