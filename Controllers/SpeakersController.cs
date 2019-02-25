using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SpeakersController : Controller
    {

        [HttpGet]
        public IEnumerable<SpeakersModel> Get()
        {
            var allText = System.IO.File.ReadAllText(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "data/speakers.json"));

            var jsonObject = JsonConvert.DeserializeObject<IEnumerable<SpeakersModel>>(allText);
            return jsonObject;
        }
    }
}
