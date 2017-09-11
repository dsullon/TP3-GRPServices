using GRP.Logic;
using System.Web.Http;

namespace GRP.Services.Controllers
{
    [RoutePrefix("api/articulo")]
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

        [Route("umbral")]
        public IHttpActionResult GetUmbral()
        {
            var resultData = ArticuloBL.GetUmbral();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        [Route("umbral/{id:int}")]
        public IHttpActionResult GetUmbralPerId(int id)
        {
            var resultData = ArticuloBL.GetUmbralPerId(id);
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }
    }
}