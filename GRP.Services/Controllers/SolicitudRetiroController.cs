using GRP.Core;
using GRP.Logic;
using System.Web.Http;

namespace GRP.Services.Controllers
{
    [RoutePrefix("api/solicitudretiro")]
    public class SolicitudRetiroController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            var resultData = SolicitudRetiroBL.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        public IHttpActionResult Get(int id)
        {
            var resultData = SolicitudRetiroBL.Get(id);
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        public IHttpActionResult PostSolicitudRetiro(SolicitudRetiro solicitud)
        {
            SolicitudRetiroBL.Add(solicitud);
            return Ok(solicitud);
        }
    }
}