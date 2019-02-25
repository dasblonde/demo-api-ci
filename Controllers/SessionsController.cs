using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SessionsController : Controller
    {
        [HttpGet]
        public IEnumerable<SessionModel> Index()
        {
            var allText =
                System.IO.File.ReadAllText(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath,
                    "data/sessions.json"));

            var jsonObject = JsonConvert.DeserializeObject<IEnumerable<SessionModel>>(allText);
            return jsonObject;
        }
    }
}
