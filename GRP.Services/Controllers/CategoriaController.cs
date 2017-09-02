using GRP.Logic;
using System.Web.Http;

namespace GRP.Services.Controllers
{
    public class CategoriaController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            var resultData = CategoriaBL.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }
    }
}