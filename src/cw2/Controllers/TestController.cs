using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace cw2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [Route("index")]
        public JsonResult Index()
        {
            return Json(JObject.Parse("{'nic':'nic'}"));
        }

        [Route("create")]
        public JsonResult Create()
        {
            return Json(JObject.Parse("{'cos':'cos'}"));
        }

        [Route("create/{id:int}/{name:alpha}")]
        public JsonResult Create(int id, string name)
        {
            return Json(JObject.Parse("{"+$"'cos':'{id}', alpha: '{name}'"+"}"));
        }
    }
}