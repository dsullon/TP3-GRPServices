using GRP.Logic;
using System.Web.Http;

namespace GRP.Services.Controllers
{
    public class ArticuloController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            var resultData = ArticuloBL.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }
    }
}
