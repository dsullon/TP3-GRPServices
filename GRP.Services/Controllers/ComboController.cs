using GRP.Core;
using GRP.Logic;
using System.Web.Http;

namespace GRP.Services.Controllers
{
    [RoutePrefix("api/combo")]
    public class ComboController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            var resultData = ComboBL.Get(id);
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        public IHttpActionResult GetAll()
        {
            var resultData = ComboBL.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        [Route("retiro")]
        public IHttpActionResult GetAllWithRelations()
        {
            var resultData = ComboBL.GetAllWithRelations();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        [Route("{id:int}/detalle")]
        public IHttpActionResult GetDetails(int id)
        {
            var resultData = ComboBL.GetDetails(id);
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        public IHttpActionResult PostCombo(Combo combo)
        {
            ComboBL.Add(combo);
            return Ok(combo);
        }

        public IHttpActionResult PutCombo(Combo combo)
        {
            ComboBL.Update(combo);
            return Ok(combo);
        }
    }
}