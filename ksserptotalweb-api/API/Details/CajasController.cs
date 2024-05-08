using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ksserptotalweb_api.Capas.Datos;

namespace ksserptotalweb_api.API.Details
{
    public class CajasController : ApiController
    {
        private kss_dbEntities db = new kss_dbEntities();

        // GET: api/Cajas
        public IQueryable<Cajas> GetCajas()
        {
            return db.Cajas;
        }

        // GET: api/Cajas/5
        [ResponseType(typeof(Cajas))]
        public async Task<IHttpActionResult> GetCajas(short id)
        {
            Cajas cajas = await db.Cajas.FindAsync(id);
            if (cajas == null)
            {
                return NotFound();
            }

            return Ok(cajas);
        }

        // PUT: api/Cajas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCajas(short id, Cajas cajas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cajas.id_Cajas)
            {
                return BadRequest();
            }

            db.Entry(cajas).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CajasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Cajas
        [ResponseType(typeof(Cajas))]
        public async Task<IHttpActionResult> PostCajas(Cajas cajas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cajas.Add(cajas);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cajas.id_Cajas }, cajas);
        }

        // DELETE: api/Cajas/5
        [ResponseType(typeof(Cajas))]
        public async Task<IHttpActionResult> DeleteCajas(short id)
        {
            Cajas cajas = await db.Cajas.FindAsync(id);
            if (cajas == null)
            {
                return NotFound();
            }

            db.Cajas.Remove(cajas);
            await db.SaveChangesAsync();

            return Ok(cajas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CajasExists(short id)
        {
            return db.Cajas.Count(e => e.id_Cajas == id) > 0;
        }
    }
}