using WShopApi.Model;

namespace WShopApi.Repository
{
    public class ShopBiz : IShopBiz
    {
        public List<Producto> GetProductos()
        {

            // aqui ing llamar a la referencia web del soap service
            List<Producto> listPrd = new List<Producto>();
            Producto prd1 = new Producto();
            prd1.codigo = 1;
            prd1.Nombre = "Vajilla inglesa";
            prd1.precio = Convert.ToString(40.5);
            prd1.moneda = "BOB";

            Producto prd2 = new Producto();
            prd2.codigo = 2;
            prd2.Nombre = "Escoba diaria";
            prd2.precio = Convert.ToString(40.5);
            prd2.moneda = "BOB";

            listPrd.Add(prd1);
            listPrd.Add(prd2);
            return listPrd;

        }
    }
}
