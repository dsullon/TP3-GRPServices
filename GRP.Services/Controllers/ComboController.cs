using GRP.Core;
using GRP.Logic;
using System.Web.Http;

namespace GRP.Services.Controllers
{
    [RoutePrefix("api/combo")]
    public class ComboController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            var resultData = ComboBL.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }
    }
}