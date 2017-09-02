using GRP.Core;
using GRP.Logic;
using System.Web.Http;

namespace GRP.Services.Controllers
{
    public class ProductoController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            var resultData = ProductoBL.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        public IHttpActionResult Get(int id)
        {
            var resultData = ProductoBL.Get(id);
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        public IHttpActionResult PostProducto(Producto producto)
        {
            ProductoBL.Add(producto);
            
            return Ok(producto);
        }
    }
}