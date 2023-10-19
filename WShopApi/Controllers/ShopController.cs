using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WShopApi.Model;
using WShopApi.Repository;

namespace WShopApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {

        
        [Route("GetListProduct")]
        [HttpPost]
        public ActionResult<List<Producto>> getListProduct() {
            List<Producto> listPrd = new List<Producto>();
            IShopBiz shop=  new ShopBiz();
            try {

                listPrd = shop.GetProductos();            

            } catch (Exception ex) { 
            
            }
            return listPrd;
        }
    }
}
