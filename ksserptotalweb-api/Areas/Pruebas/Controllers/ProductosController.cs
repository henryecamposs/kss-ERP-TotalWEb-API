using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ksserptotalweb_api.Capas.Datos;

namespace ksserptotalweb_api.Areas.Pruebas.Controllers
{
    public class ProductosController : Controller
    {
        private kss_dbEntities db = new kss_dbEntities();

        // GET: Pruebas/Productos
        public async Task<ActionResult> Index()
        {
            var productos = db.Productos.Include(p => p.Productos_Familias).Include(p => p.TiposUnidadesMedida);
            return View(await productos.ToListAsync());
        }

        // GET: Pruebas/Productos/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = await db.Productos.FindAsync(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            return View(productos);
        }

        // GET: Pruebas/Productos/Create
        public ActionResult Create()
        {
            ViewBag.id_Productos_familias = new SelectList(db.Productos_Familias, "id_Productos_Familias", "FamiliaProducto");
            ViewBag.id_TiposUnidadesMedida = new SelectList(db.TiposUnidadesMedida, "id_TiposUnidadesMedida", "UnidadMedida");
            return View();
        }

        // POST: Pruebas/Productos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id_Productos,id_Productos_familias,id_TiposMarcas,id_TiposUnidadesMedida,cantidadUnidadVenta,CodigoAdicional,CodigoBarras,CodigoInterno,FechaCreacion,FechaUltimaCompra,FechaUltimaModificacion,FechaUltimaVenta,MargenGananciaPrecio1,MargenGananciaPrecio2,MargenGananciaPrecio3,MontoCostoPromedio,MontoPrecio1,MontoPrecio2,MontoPrecio3,MontoUltimoCosto,nDiasGarantia,Producto,Producto_DescripcionLarga,Producto_LinkWeb,nStockMaximo,nStockMinimo,esAvisoStockMinimo,esAvisoStockMaximo,MedidaAlto,MedidaAncho,MedidaLargo,esActivo,esCodigoAlterno,esCompuesto,esFavorito,esGarantia,esImportado,esInventario,esPideComentario,esPidePeso,esPidePrecio,esPideTipoProducto,esUsoInterno,esControlVenta,nCantidadMaxventa")] Productos productos)
        {
            if (ModelState.IsValid)
            {
                db.Productos.Add(productos);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.id_Productos_familias = new SelectList(db.Productos_Familias, "id_Productos_Familias", "FamiliaProducto", productos.id_Productos_familias);
            ViewBag.id_TiposUnidadesMedida = new SelectList(db.TiposUnidadesMedida, "id_TiposUnidadesMedida", "UnidadMedida", productos.id_TiposUnidadesMedida);
            return View(productos);
        }

        // GET: Pruebas/Productos/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = await db.Productos.FindAsync(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_Productos_familias = new SelectList(db.Productos_Familias, "id_Productos_Familias", "FamiliaProducto", productos.id_Productos_familias);
            ViewBag.id_TiposUnidadesMedida = new SelectList(db.TiposUnidadesMedida, "id_TiposUnidadesMedida", "UnidadMedida", productos.id_TiposUnidadesMedida);
            return View(productos);
        }

        // POST: Pruebas/Productos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id_Productos,id_Productos_familias,id_TiposMarcas,id_TiposUnidadesMedida,cantidadUnidadVenta,CodigoAdicional,CodigoBarras,CodigoInterno,FechaCreacion,FechaUltimaCompra,FechaUltimaModificacion,FechaUltimaVenta,MargenGananciaPrecio1,MargenGananciaPrecio2,MargenGananciaPrecio3,MontoCostoPromedio,MontoPrecio1,MontoPrecio2,MontoPrecio3,MontoUltimoCosto,nDiasGarantia,Producto,Producto_DescripcionLarga,Producto_LinkWeb,nStockMaximo,nStockMinimo,esAvisoStockMinimo,esAvisoStockMaximo,MedidaAlto,MedidaAncho,MedidaLargo,esActivo,esCodigoAlterno,esCompuesto,esFavorito,esGarantia,esImportado,esInventario,esPideComentario,esPidePeso,esPidePrecio,esPideTipoProducto,esUsoInterno,esControlVenta,nCantidadMaxventa")] Productos productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productos).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.id_Productos_familias = new SelectList(db.Productos_Familias, "id_Productos_Familias", "FamiliaProducto", productos.id_Productos_familias);
            ViewBag.id_TiposUnidadesMedida = new SelectList(db.TiposUnidadesMedida, "id_TiposUnidadesMedida", "UnidadMedida", productos.id_TiposUnidadesMedida);
            return View(productos);
        }

        // GET: Pruebas/Productos/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = await db.Productos.FindAsync(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            return View(productos);
        }

        // POST: Pruebas/Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            Productos productos = await db.Productos.FindAsync(id);
            db.Productos.Remove(productos);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
