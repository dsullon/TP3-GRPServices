using GRP.Logic;
using System.Web.Http;

namespace GRP.Services.Controllers
{
    public class NutricionalController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            var resultData = InformacionNutricionalBL.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        public IHttpActionResult Get(int id)
        {
            var resultData = InformacionNutricionalBL.Get(id);
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }
    }
}
