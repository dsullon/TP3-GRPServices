using GRP.Core;
using GRP.Logic;
using System.Web.Http;

namespace GRP.Services.Controllers
{
    [RoutePrefix("api/producto")]
    public class ProductoController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            try
            {
                var resultData = ProductoBL.GetAll();
                if (resultData == null)
                    return NotFound();
                return Ok(resultData);
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Get(int id)
        {
            if (id == 0)
                return BadRequest("No se ha indicado un id válido.");
            try
            {
                var resultData = ProductoBL.Get(id);
                if (resultData == null)
                    return NotFound();
                return Ok(resultData);
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("{id:int}/details")]
        public IHttpActionResult GetDetails(int id)
        {
            if (id == 0)
                return BadRequest("No se ha indicado un id válido.");
            try
            {
                var resultData = ProductoBL.GetDetails(id);
                if (resultData == null)
                    return NotFound();
                return Ok(resultData);
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("item")]
        public IHttpActionResult GetPerItem([FromUri]int[] id)
        {
            if (id == null || id.Length == 0)
                return BadRequest("No se ha seleccionado los articulos");
            try
            {
                var resultData = ProductoBL.GetPerItem(id);
                if (resultData == null)
                    return NotFound();
                return Ok(resultData);
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult PostProducto(Producto producto)
        {
            if (producto == null)
                return BadRequest("No se agregó el producto");
            if (producto.Insumos == null || producto.Insumos.Count == 0)
                return BadRequest("No se agregó el producto");
            try
            {
                ProductoBL.Add(producto);
                return Ok(producto);
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }            
        }

        public IHttpActionResult PutProducto(Producto producto)
        {
            if (producto == null)
                return BadRequest("No se agregó el producto.");
            if(producto.Insumos == null || producto.Insumos.Count == 0)
                return BadRequest("No se agregaron los insumos.");
            try
            {
                ProductoBL.Update(producto);
                return Ok(producto);
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult DeleteCombo(int id)
        {
            if (id == 0)
                return BadRequest("No se ha indicado un id válido.");
            try
            {
                ProductoBL.Remove(id);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}