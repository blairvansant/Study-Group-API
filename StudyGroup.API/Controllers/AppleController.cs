using StudyGroup.API.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudyGroup.API.Controllers
{
    public class AppleController : ApiController
    {
        readonly IAppleGetter _getter;

        public AppleController()
        {
            _getter = new AppleGetter();
        }

        public AppleController(IAppleGetter getter)
        {
            _getter = getter;
        }

        [HttpGet]
        [Route("api/apple/{id}")]
        public HttpResponseMessage CrazyTime(int id)
        {
            var apple = _getter.GetById(id);

            if (apple == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The Apple with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, apple);
        }
    }
}
